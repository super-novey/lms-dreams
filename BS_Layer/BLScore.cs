using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLScore
    {
        DBMain db = null;
        public BLScore()
        {
            db = new DBMain();
        }
        public DataSet GetScore()
        {
            return db.ExecuteQueryDataSet("select * from SCORE", CommandType.Text);
        }

        public DataSet GetScoreByIdStudent(string idStudent)
        {
            return db.ExecuteQueryDataSet("select * from dbo.SCORE where IdStudent = '" + idStudent + "'", CommandType.Text);
        }
        public bool AddScore(string student, string semeter, string subject, string score)
        {
            string sqlString = "exec pro_addSCORE '" + student + "','" + semeter + "','" + subject + "', " + score;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool UpdateScore(string student, string semeter, string subject, string score)
        {
            string sqlString = "update dbo.[SCORE]\r\nset  IdSemeter = '" + semeter + "', Score=" + score + "\r\nwhere IdStudent='" + student + "' and IdSubject='" + subject + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool DeleteScoreSdtuent(string idStduent, string subject)
        {
            string sqlString = "delete dbo.[SCORE]\r\nwhere IdStudent='" + idStduent + "' and IdSubject='" + subject + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataSet GetDetailScore(string idStudent)
        {
            return db.ExecuteQueryDataSet("select IdSubject, Displayname, Credit, Score from dbo.SCORE, dbo.SUBJECT where IdStudent = '"+ idStudent + "' and dbo.SCORE.IdSubject = dbo.SUBJECT.Id", CommandType.Text);
        }

        public DataTable ShowScoreOfStudent(string id)
        {
            DataTable dt = this.GetDetailScore(id).Tables[0];
            dt.Columns.Add("Result", typeof(bool));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDouble(dt.Rows[i]["Score"]) < 5.0)
                    dt.Rows[i]["Result"] = false;
                else
                    dt.Rows[i]["Result"] = true;
            }
            return dt;
        }

        public List<double> CalculateOveral(string id)
        {
            double sum = 0;
            int count = 0;
            DataTable dt = this.GetDetailScore(id).Tables[0];
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double tmp = Convert.ToDouble(dt.Rows[i]["Score"]);
                int credit = Convert.ToInt16(dt.Rows[i]["Credit"]);
                if (tmp >= 5.0)
                {
                    sum += tmp * credit;
                    count += credit;
                }    
            }    

            return new List<double>{Math.Round(sum / count,2), count};
        }

    }
}
