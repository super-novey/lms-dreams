using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLFaculty
    {
        DBMain db;
        List<string> columns = new List<string>(new string[] { "Id", "Displayname" });
        public BLFaculty()
        {
            db = new DBMain();
        }

        public DataSet GetFaculty()
        {
            return db.ExecuteQueryDataSet("select * from dbo.FACULTY", CommandType.Text);
        }

        public bool AddFaculty(string id, string name)
        {
            string sqlString = "insert into dbo.FACULTY values ('" + id + "', N'" + name + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool DeleteFaculty(string id)
        {
            string sqlString = "Delete From FACULTY Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool UpdateFaculty(string id, string name)
        {
            string sqlString = "Update FACULTY Set Displayname=N'" +
            name + "' Where Id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataSet SearchFacultyById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.FACULTY where dbo.FACULTY.Id like '%" + id + "%'", CommandType.Text);
        }   
        
        public DataSet SearchFacultyByName(string name)
        {
            return db.ExecuteQueryDataSet("select * from dbo.FACULTY where dbo.FACULTY.Displayname like N'%" + name + "%'", CommandType.Text);

        }
        public string GetColumnById(string id, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom FACULTY\r\nwhere  FACULTY.Id = '" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }

    }
}
