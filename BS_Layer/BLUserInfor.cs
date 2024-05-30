using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LMSDreams.BS_Layer
{
    public class BLUserInfor
    {
        DBMain db;
        List<string> columns = new List<string>(new string[] { "Id", "Fullname", "Sex" });
        public BLUserInfor()
        {
            db = new DBMain();
        }

        public DataSet GetUserInfor(string id)
        {
            return db.ExecuteQueryDataSet("select * from USERINFOR where Id = '"+id+"'", CommandType.Text);
        }

        public DataSet GetUSerInfor()
        {
            return db.ExecuteQueryDataSet("select * from USERINFOR", CommandType.Text);
        }

        public bool AddUserInfor(string id, string fullname, string sex)
        {
            string sqlString = "exec pro_addUSERINFOR '" + id + "',N'" + fullname + "'," + sex;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool UpdateUserInfor(string id, string fullname, string sex)
        {
            string sqlString = "exec pro_updateUSERINFOR '" + id + "',N'" + fullname + "'," + sex;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateSex(string id, string Sex)
        {
            string sqlString = "update dbo.USERINFOR\nset Sex = " + Sex + "\nwhere id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteUserInfor(string id)
        {
            string sqlString = "exec pro_deleteUSERINFOR '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string GetColumnById(string id, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom USERINFOR\r\nwhere  USERINFOR.Id = '" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
        public DataSet getRowById(string id)
        {
            string sqlString = " select * from USERINFOR where USERINFOR.Id = '" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public string CreateRamdomIdInfor()
        {
            string result = "000";
            foreach (DataRow row in GetUSerInfor().Tables[0].Rows)
            {
                int num1 = int.Parse(row[0].ToString().Substring(2, 3));
                int num2 = int.Parse(result);
                if (num1 >= num2)
                    result = (num1 + 1).ToString();
            }
            while (result.Length < 3) result = "0" + result;
            return "IF" + result;
        }

        public string GetFullName(string id)
        {
            DataSet d = GetUserInfor(id);
            DataTable dt = d.Tables[0];
            return dt.Rows[0]["Fullname"].ToString();
        }
    }
}
