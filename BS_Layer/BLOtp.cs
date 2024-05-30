using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLOtp
    {
        DBMain db = null;
        public BLOtp()
        {
            db = new DBMain();
        }
        public DataSet GetOtp()
        {
            return db.ExecuteQueryDataSet("select * from OTP", CommandType.Text);
        }
        public bool AddOtp(string id, string code, string time)
        {
            string sqlString = "exec pro_addOTP '" + id + "','" + code + "'," + time;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateOtp(string id, string code, string time)
        {
            string sqlString = "exec pro_updateOTP '" + id + "','" + code + "'," + time;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteOtp(string id)
        {
            string sqlString = "exec pro_deleteOTP '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string CreateRamdomOtp()
        {
            string result = "000";
            foreach (DataRow row in GetOtp().Tables[0].Rows)
            {
                int num1 = int.Parse(row[0].ToString().Substring(2, 3));
                int num2 = int.Parse(result);
                if (num1 >= num2)
                    result = (num1 + 1).ToString();
            }
            while (result.Length < 3) result = "0" + result;
            return "OP" + result;
        }
    }
}
