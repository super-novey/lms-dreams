using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLTeacher
    {
        DBMain db;
        List<string> columns = new List<string>(new string[] { "Id", "IdFaculty" });

        public BLTeacher()
        {
            db = new DBMain();
        }

        public string GetName(string id)
        {
            BLUser u = new BLUser();
            DataTable d = u.GetInfo(id).Tables[0];
            return d.Rows[0]["Fullname"].ToString();
        }

        public DataSet GetTeacher()
        {
            return db.ExecuteQueryDataSet("select * from TEACHER", CommandType.Text);
        }
        public bool AddTeacher(string id, string faculty)
        {
            string sqlString = "exec pro_addTEACHER '" + id + "','" + faculty + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateTeacher(string id, string faculty)
        {
            string sqlString = "exec pro_updateTEACHER '" + id + "','" + faculty + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteTeacher(string id)
        {
            string sqlString = "exec pro_deleteTEACHER '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string GetColumnByUser(string user, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom TEACHER\r\nwhere  TEACHER.Id = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
    }
}
