using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLStudent
    {
        DBMain db = null;
        List<string> columns = new List<string>(new string[] { "Id", "IdFaculty", "IdTrainingForm", "Status" });
        public BLStudent()
        {
            db = new DBMain();
        }
        public DataSet GetStudent()
        {
            return db.ExecuteQueryDataSet("select * from STUDENT", CommandType.Text);
        }
        public bool AddStudent(string id, string faculty, string traingform, string status)
        {
            string sqlString = "exec pro_addSTUDENT '" + id + "','" + faculty + "','" + traingform + "'," + status;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateStudent(string id, string faculty, string traingform, string status)
        {
            string sqlString = "exec pro_updateSTUDENT '" + id + "','" + faculty + "','" + traingform + "'," + status;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteStudent(string id)
        {
            string sqlString = "exec pro_deleteSTUDENT '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string GetColumnByUser(string user, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom STUDENT\r\nwhere  STUDENT.Id= '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
    }
}
