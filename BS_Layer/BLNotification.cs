using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLNotification
    {
        DBMain db = null;
        public BLNotification()
        {
            db = new DBMain();
        }
        public DataSet GetNotification()
        {
            string sqlstring = "select * from NOTIFICATION";
            return db.ExecuteQueryDataSet(sqlstring, CommandType.Text); ;
        }
        public bool CreateNotification(string id, string topic, string content, string send, string receive)
        {
            string sqlstring = "insert into NOTIFICATION values ('" + id + "', N'" + topic + "', N'" + content + "', '" + send + "', '" + receive + "')";
            return db.MyExecuteNonQuery(sqlstring, CommandType.Text);
        }
        public string GetIDRamdom()
        {
            int values = 1000;
            foreach (DataRow row in GetNotification().Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                if (id != values)
                    break;
                values++;
            }
            return (values).ToString();
        }
        public string GetContentByID(string Id)
        {
            foreach (DataRow row in GetNotification().Tables[0].Rows)
            {
                if (row["Id"].ToString() == Id)
                    return row["Content"].ToString();
            }
            return "";
        }
    }
}
