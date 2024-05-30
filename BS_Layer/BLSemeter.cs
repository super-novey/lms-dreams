using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLSemeter
    {
        DBMain db = null;
        List<string> columns = new List<string>(new string[] { "Id", "Displayname", "CourseRegisterStatus" });

        public BLSemeter()
        {
            db = new DBMain();
        }

        public DataSet GetSemeter()
        {
            return db.ExecuteQueryDataSet("select * from dbo.SEMETER", System.Data.CommandType.Text);
        }

        public bool UpdateSemeter(string id, string CourseRegisterStatus)
        {
            string sqlstring = "update SEMETER\r\nset CourseRegisterStatus = " + CourseRegisterStatus + "\r\nwhere Id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlstring, CommandType.Text);
        }
        public string GetColumnById(string user, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom SEMETER\r\nwhere  SEMETER.Id = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
        public string GetIdByName(string Displayname)
        {
            string sqlString = "select Id\r\nfrom SEMETER\r\nwhere Displayname like N'%" + Displayname + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
    }
}
