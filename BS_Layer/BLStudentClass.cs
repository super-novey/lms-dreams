using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLStudentClass
    {
        DBMain db = null;
        public BLStudentClass()
        {
            db = new DBMain();
        }
        public bool AddStudentClass(string student, string idclass)
        {
            string sqlstring = "exec pro_addSTUDENT_CLASS '" + student + "','" + idclass + "'";
            return db.MyExecuteNonQuery(sqlstring, CommandType.Text);
        }
        public bool DeleteStudentClass(string student, string idclass)
        {
            string sqlstring = "delete STUDENT_CLASS\r\nwhere IdStudent '" + student + "','" + idclass + "'";
            return db.MyExecuteNonQuery(sqlstring, CommandType.Text);
        }

        public bool DeleteStudentClassById(string idClass)
        {
            string sqlstring = "delete STUDENT_CLASS where IdClass = '"+ idClass + "'";
            return db.MyExecuteNonQuery(sqlstring, CommandType.Text);
        }

        public DataSet GetStudentClassByIdStudent(string idStudent)
        {
            return db.ExecuteQueryDataSet("select * from dbo.STUDENT_CLASS where IdStudent = '"+ idStudent + "'", CommandType.Text);
        }

        
    }
}
