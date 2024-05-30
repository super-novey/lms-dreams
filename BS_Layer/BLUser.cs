using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;

namespace LMSDreams.BS_Layer
{
    public class BLUser
    {
        DBMain db = null;
        List<string> columns = new List<string>(new string[] { "Username", "IdOTP", "IdInfo", "Password", "IdAvatar", "IdRole" });

        public BLUser()
        {
            db = new DBMain();
        }

        public DataSet GetInfo(string id)
        {
            return db.ExecuteQueryDataSet("select * from [USER] join [USERINFOR] on [USER].IdInfo = [USERINFOR].Id where [USER].Username = '" + id + "'", CommandType.Text);
        }

        public DataSet GetUser()
        {
            return db.ExecuteQueryDataSet("select * from [USER]", CommandType.Text);
        }

        public bool checkUserPass(string user, string pass)
        {
            foreach (DataRow row in GetUser().Tables[0].Rows)
            {
                if (row[0].ToString() == user)
                {
                    return row[3].ToString() == pass;
                }
            }
            return false;
        }

        public string GetIdRole(string id)
        {
            DataSet d = db.ExecuteQueryDataSet("select IdRole from [USER] where Username = '" + id+"'", CommandType.Text);
            DataTable t = d.Tables[0];
            return t.Rows[0]["IdRole"].ToString();

        }

        public string GetIdInfo(string id)
        {
            DataSet d = db.ExecuteQueryDataSet("select IdInfo from [USER] where Username = '" + id + "'", CommandType.Text);
            DataTable t = d.Tables[0];
            return t.Rows[0]["IdInfo"].ToString();
        }

        public DataSet GetUserByUsername(string username)
        {
            return db.ExecuteQueryDataSet("select * from [USER] where Username = '"+ username + "'", CommandType.Text);
        }

        public bool AddUser(string user, string otp, string infor, string pass, string avatar, string role)
        {
            string sqlString = "exec pro_addUSER '" + user + "','" + otp + "','" +
                infor + "','" + pass + "','" + avatar + "','" + role + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateUser(string user, string otp, string infor, string pass, string avatar, string role)
        {
            string sqlString = "exec pro_updateUSER '" + user + "','" + otp + "','" +
                infor + "','" + pass + "','" + avatar + "','" + role + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdatePass(string user, string pass)
        {
            string sqlString = "update dbo.[USER]\r\nset Password= '" + pass + "'\r\nwhere Username = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteUser(string user)
        {
            string sqlString = "exec pro_deleteUSER '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string GetColumnByUser(string user, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom [USER]\r\nwhere  [USER].Username = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
        public DataSet getRowByUser(string user)
        {
            string sqlString = " select * from [USER] where [USER].Username = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool CheckUser(string user)
        {
            foreach (DataRow row in GetUser().Tables[0].Rows)
            {
                if (row[0].ToString() == user)
                {
                    return true;
                }
            }
            return false;
        }

        public string CreateRamdomUsername(string role)
        {
            string result = role + "00";
            foreach (DataRow row in GetUser().Tables[0].Rows)
            {
                string user = row[0].ToString();

                if (user[0].ToString() == role)
                {
                    int num1 = int.Parse(user);
                    int num2 = int.Parse(result);
                    if (num1 >= num2)
                        result = (num1 + 1).ToString();
                }
            }
            return result;
        }

        public string GetIdAvatar(string username)
        {
            DataSet d = db.ExecuteQueryDataSet("select * from [USER] where Username = '" + username + "'", CommandType.Text);
            DataTable t = d.Tables[0];
            return t.Rows[0]["IdAvatar"].ToString();
        }
    }
}
