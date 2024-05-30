using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LMSDreams.BS_Layer
{
    public class BLUserRole
    {
        DBMain db;

        public BLUserRole()
        {
            db = new DBMain();
        }

        public DataSet GetUserRole(string id)
        {
            return db.ExecuteQueryDataSet("select * from [USERROLE] where [USERROLE].Id = '" + id + "'", CommandType.Text);
        }

        public DataSet GetUSerRole()
        {
            return db.ExecuteQueryDataSet("select * from USERROLE", CommandType.Text);
        }

        public bool AddUserRole(string id, string role)
        {
            string sqlString = "exec pro_addUserRole '" + id + "','" + role + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateUserRole(string id, string role)
        {
            string sqlString = "exec pro_updateUserRole'" + id + "','" + role + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteUserRole(string id)
        {
            string sqlString = "exec pro_deleteUserRole '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public string GetRole(string id)
        {
            DataSet d = this.GetUserRole(id);
            DataTable dt = d.Tables[0];
            return dt.Rows[0]["Role"].ToString();
        }
    }
}
