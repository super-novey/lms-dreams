using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLDataBaseImageTable
    {
        DBMain db = null;

        public BLDataBaseImageTable()
        {
            db = new DBMain();
        }
        public DataSet GetDataBaseImageTable()
        {
            return db.ExecuteQueryDataSet("select * from DATABASEIMAGETABLE", CommandType.Text);
        }

        /*public bool AddDataBaseImageTable(string id, string image)
        {
            string sqlString = "exec pro_addDATABASEIMAGETABLE '" + id + "','" + image + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }*/

        public bool AddDataBaseImageTable(string id, byte[] image)
        {
            string sqlString = "exec pro_addDATABASEIMAGETABLE @id , @image";
            return db.ExecuteNonQuery(sqlString, new object[] {id,image});
        }


        public bool UpdateDataBaseImageTable(string id, byte[] image)
        {
            string sqlString = "exec pro_updateDATABASEIMAGETABLE @id , @image";
            return db.ExecuteNonQuery(sqlString, new object[] { id, image });
        }
        public bool DeleteDataBaseImageTable(string id)
        {
            string sqlString = "exec pro_deleteDATABASEIMAGETABLE '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public string CreateRamdomImage()
        {
            string result = "000";
            foreach (DataRow row in GetDataBaseImageTable().Tables[0].Rows)
            {
                int num1 = int.Parse(row[0].ToString().Substring(2, 3));
                int num2 = int.Parse(result);
                if (num1 >= num2)
                    result = (num1 + 1).ToString();
            }
            while (result.Length < 3) result = "0" + result;
            return "AV" + result;
        }

        public DataSet GetDataImgeById(string id)
        {
            return db.ExecuteQueryDataSet("select * from dbo.DATABASEIMAGETABLE where id = '"+ id + "'", CommandType.Text);
        }

        public byte[] GetImageString(string id)
        {
            DataTable d = this.GetDataImgeById(id).Tables[0];
            return (byte[])d.Rows[0]["Image"];
        }

        

        
    }
}
