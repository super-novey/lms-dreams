using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    internal class BLDocument
    {
        DBMain db = null;
        public BLDocument()
        {
            db = new DBMain();
        }

        public bool AddDocument(byte[] data, string name, long size, string extn ,string idClass, string idSender)
        {
            string query = "exec dbo.pro_AddDocument @data , @name , @size , @extn , @idClass , @idSender , @t";
            return db.ExecuteNonQuery(query, new object[] { data, name, size, extn, idClass, idSender, DateTime.Now});
        }

        public DataTable GetDocuments()
        {
            string query = "select Id,Displayname,Time from DOCUMENTS";
            return db.ExecuteQuery(query);
        }

        public DataTable GetDocumentsByIdClass(string idClass)
        {
            string query = "select Id,Displayname,IdSender,Time from DOCUMENTS where IdClass = '" + idClass +"'";
            return db.ExecuteQuery(query);
        }

        public bool DeleteDocument(string id)
        {
            string query = "delete from DOCUMENTS where Id = '"+ id +"'";
            return db.ExecuteNonQuery(query);
        }

        public DataTable GetDocumentsById(int id)
        {
            string query = "select * from DOCUMENTS where Id = '" + id + "'";
            return db.ExecuteQuery(query);
        }
    }
}
