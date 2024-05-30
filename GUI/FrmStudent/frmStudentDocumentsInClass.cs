using LMSDreams.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.GUI.FrmStudent
{
    public partial class frmStudentDocumentsInClass : Form
    {
        BLDocument doc = new BLDocument();
        BLData data = new BLData();

        string IdClass { get; set; }

        public frmStudentDocumentsInClass(string idClass)
        {
            InitializeComponent();
            IdClass = idClass;
        }

        private void frmDocumentsInClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != "")  
                SaveFile(dlg.FileName);
            LoadData();
        }


        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var f = new FileInfo(filePath);
                string name = f.Name;
                string extn = f.Extension;
                long size = f.Length / 1024;
                doc.AddDocument(buffer, name, size, extn, IdClass, frmLogin.sender);
            }
        }

        private void LoadData()
        {
            dtgvDocuments.DataSource = doc.GetDocumentsByIdClass(IdClass);
            if (dtgvDocuments.RowCount > 0)
            {
                //dtgvDocuments.Columns[0].Visible = false;
                dtgvDocuments.Columns[1].HeaderCell.Value = "Tên file";
                dtgvDocuments.Columns[2].HeaderCell.Value = "Người đăng";
                dtgvDocuments.Columns[3].HeaderCell.Value = "Thời gian";
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            int r = dtgvDocuments.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dtgvDocuments.Rows[r].Cells[0].Value);
            OpenFile(id);
        }

        private void OpenFile(int id)
        {
            DataTable reader = doc.GetDocumentsById(id);

            var name = reader.Rows[0]["Displayname"].ToString();
            var data = (byte[])reader.Rows[0]["Data"];
            var extn = reader.Rows[0]["Extension"].ToString();
            var newFilename = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = newFilename;
            saveFileDialog.ShowDialog();
            File.WriteAllBytes(saveFileDialog.FileName, data);
        }

        private void dtgvDocuments_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvDocuments.CurrentCell.RowIndex;
            string name = dtgvDocuments.Rows[r].Cells[1].Value.ToString();

            if (name != "")
            {
                txtDisplayname.Text = name;
                DateTime t = Convert.ToDateTime(dtgvDocuments.Rows[r].Cells[3].Value);
                lblTime.Text = t.ToString("dd/MM/yyyy HH:mm:ss");
                lblSender.Text = data.GetNameByUser(dtgvDocuments.Rows[r].Cells[2].Value.ToString());
            }

        }

    }
}
