using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LMSDreams.BS_Layer
{
    internal class BLSubject
    {
        DBMain db;

        public BLSubject()
        {
            db = new DBMain();
        }

        public DataSet GetSubject()
        {
            return db.ExecuteQueryDataSet("select * from dbo.SUBJECT", CommandType.Text);
        }

        public bool AddSubject(string id, string name, string credit)
        {
            string sqlString = "insert into dbo.SUBJECT values ('" + id + "', N'" + name + "', '" + credit + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool DeleteSubject(string id)
        {
            string sqlString = "Delete From SUBJECT Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool UpdateSubject(string id, string name, string credit)
        {
            string sqlString = "Update SUBJECT Set Displayname=N'" +
            name + "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataSet SearchSubjectById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.SUBJECT where dbo.SUBJECT.id like '%" + id + "%'", CommandType.Text);
        }

        public DataSet SearchSubjectByName(string name)
        {
            return db.ExecuteQueryDataSet("select * from dbo.SUBJECT where dbo.SUBJECT.Displayname like N'%" + name + "%'", CommandType.Text);
        }

        public DataSet GetSubjectById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.Subject where id = '" + id + "'", CommandType.Text);
        }

        public string GetNameSubject(string id)
        {
            DataTable dt = this.GetSubjectById(id).Tables[0];
            return dt.Rows[0]["Displayname"].ToString();
        }

        public string GetCreditSubject(string id)
        {
            DataTable dt = this.GetSubjectById(id).Tables[0];
            return dt.Rows[0]["Credit"].ToString();
        }
    }
}
