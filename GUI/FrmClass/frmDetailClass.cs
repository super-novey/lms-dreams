using LMSDreams.BS_Layer;
using LMSDreams.GUI.FrmAdmin;
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

namespace LMSDreams.GUI
{
    public partial class frmDetailClass : Form
    {
        frmDocumentsInClass document;
        frmNotificationsInClass notification;
        frmStudentsInClass students;
        BLSubjectClass subjectClass = new BLSubjectClass();

        private string Classid { get; set; }

        public frmDetailClass(string id)
        {
            InitializeComponent();
            Classid = id;
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

        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (document == null)
            {
                document = new frmDocumentsInClass(Classid);
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

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (notification == null)
            {
                notification = new frmNotificationsInClass();
                notification.FormClosed += Notification_FormClosed;
                notification.MdiParent = this;
                notification.Dock = DockStyle.Fill;
                notification.Show();
            }
            else
            {
                notification.Activate();
            }
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            notification = null;
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            if (students == null)
            {
                students = new frmStudentsInClass(Classid);
                students.FormClosed += Students_FormClosed;
                students.MdiParent = this;
                students.Dock = DockStyle.Fill;
                students.Show();
            }
            else
            {
                students.Activate();
            }
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            students = null;
        }

        private void frmDetailClass_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
