using LMSDreams.BS_Layer;
using LMSDreams.GUI.FrmClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.GUI.FrmStudent
{
    public partial class frmStudentDetailClass : Form
    {
        private string Classid { get; set; }
        BLSubjectClass subjectClass = new BLSubjectClass();
        frmStudentDocumentsInClass document;
        public frmStudentDetailClass(string classid)
        {
            InitializeComponent();
            Classid = classid;
        }

        private void LoadData()
        {
            DataSet d = subjectClass.GetDetailSubjectClassById(Classid);
            DataTable dt = d.Tables[0];
            BLTeacher te = new BLTeacher();

            this.lblClassId.Text = dt.Rows[0]["Id"].ToString();
            this.lblTeacherName.Text = te.GetName(dt.Rows[0]["IdTeacher"].ToString());
            this.lblSubjectName.Text = dt.Rows[0]["Displayname"].ToString();
        }

        private void frmStudentDetailClass_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (document == null)
            {
                document = new frmStudentDocumentsInClass(Classid);
                document.FormClosed += Document_FormClosed;
                document.MdiParent = this;
                document.Dock = DockStyle.Fill;
                document.Show();
            }
            else
            {
                document.Activate();
            }
        }

        private void Document_FormClosed(object sender, FormClosedEventArgs e)
        {
            document = null;
        }
    }
}
