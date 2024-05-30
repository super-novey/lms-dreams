using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLSubjectClass
    {
        DBMain db;
        List<string> columns = new List<string>(new string[] { "Id", "IdTrainingForm", "IdSubject", "IdTeacher", "IdSemeter", "IdThumbnail", "Quantity" });
        public BLSubjectClass()
        {
            db = new DBMain();  
        }

        public DataSet GetSubjectClass()
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS", CommandType.Text);
        }

        public DataSet GetDetailSubjectClassById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS join dbo.SUBJECT on dbo.CLASS.IdSubject = dbo.SUBJECT.id where dbo.CLASS.id = '"+ id +"' ", CommandType.Text);
        }

        public DataSet GetSubjectClassById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS where Id = '" + id + "'", CommandType.Text);
        }
        public bool DeleteSubjectClass(string id)
        {
            string sqlString = "exec pro_deleteCLASS '"+id+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool AddSubjectClass(string id, string trainingForm, string subject, string teacher, string semeter, string idthumbnail, int quantity)
        {
            //string sqlString = "insert into dbo.CLASS values (' " + id + "', '"+trainingForm+"', '"+subject+"', '"+teacher+"', '"+semeter+"', '"+ idthumbnail + "', " + count + ")";
            string sqlString = "exec pro_addCLASS '"+ id + "','"+ trainingForm + "','"+ subject + "','"+ teacher + "','"+ semeter + "','"+ idthumbnail + "'," + quantity.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool UpdateSubjectClass(string id, string trainingForm, string subject, string teacher, string semeter, string idThumbnail,int quantity)
        {
            string sqlString = "exec pro_updateCLASS '"+ id + "', '"+ trainingForm + "','"+ subject + "','"+ teacher + "','"+ semeter + "','"+ idThumbnail + "'," + quantity.ToString();   
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataSet SearchSubjectClassById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS where Id like '%"+id+"%'", CommandType.Text);
        }

        public DataSet SearchSubjectClassByTeacherId(string teacherId)
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS where IdTeacher like '%"+ teacherId + "%'", CommandType.Text);
        }

        public int GetQuantity(string id)
        {
            DataSet d = db.ExecuteQueryDataSet("select COUNT(IdStudent) as SL from dbo.STUDENT_CLASS where IdClass = '"+id+"'", CommandType.Text);
            DataTable dt = d.Tables[0];
            return Convert.ToInt16(dt.Rows[0]["SL"]);
        }

        public string CreateIdClass()
        {
            string result = "000";
            foreach (DataRow row in GetSubjectClass().Tables[0].Rows)
            {
                int num1 = int.Parse(row[0].ToString().Substring(1, 3));
                int num2 = int.Parse(result);
                if (num1 >= num2)
                    result = (num1 + 1).ToString();
            }
            while (result.Length < 3) result = "0" + result;
            return "L" + result;
            
        }

        public DataSet GetLstStudentInClass(string Idclass)
        {
            string sqlString = "select STUDENT_CLASS.IdStudent, Fullname, Sex, Score\r\nfrom  [USER], USERINFOR, SCORE, STUDENT_CLASS, CLASS\r\nwhere [USER].IdInfo = USERINFOR.Id and STUDENT_CLASS.IdStudent = [USER].Username and STUDENT_CLASS.IdClass = CLASS.Id and\r\n\t\t\tCLASS.IdSubject = SCORE.IdSubject and SCORE.IdStudent = STUDENT_CLASS.IdStudent\r\n\t\t\t and CLASS.Id = '" + Idclass + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public string GetColumnById(string id, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom CLASS\r\nwhere  CLASS.Id = '" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }

        public DataSet GetClassByIdTeacher(string idTeacher)
        {
            return db.ExecuteQueryDataSet("select * from dbo.CLASS where IdTeacher = '" + idTeacher + "'", CommandType.Text);
        }


    }
}
