using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLTrainingForm
    {
        DBMain db;
        List<string> columns = new List<string>(new string[] { "Id", "Displayname" });

        public BLTrainingForm()
        {
            db = new DBMain();
        }

        public DataSet GetTrainingForm()
        {
            return db.ExecuteQueryDataSet("select * from dbo.TRAININGFORM", CommandType.Text);
        }

        public bool AddTrainingForm(string id, string name)
        {
            string sqlString = "exec pro_addTRAININGFORM '"+id+"', N'"+name+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        
        public bool DeleteTrainingForm(string id)
        {
            string sqlString = "exec pro_deleteTRAININGFORM '"+id+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool UpdateTrainingForm(string id, string name)
        {
            string sqlString = "exec pro_updateTRAININGFORM '"+ id +"', N'"+ name +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataSet GetTrainingFormById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.TRAININGFORM  where Id = '" + id + "'", CommandType.Text);
        }

        public DataSet GetTrainingFormByName(string name)
        {
            return db.ExecuteQueryDataSet("select * from dbo.TRAININGFORM where dbo.TRAININGFORM.Displayname like N'%" + name + "%'", CommandType.Text);
        }

        public string GetColumnById(string id, int index)
        {
            string sqlString = "select " + columns[index] + "\r\nfrom TRAININGFORM\r\nwhere  TRAININGFORM.Id = '" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
    }
}
