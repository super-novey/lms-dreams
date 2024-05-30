using LMSDreams.BS_Layer;
using LMSDreams.CustomControls;
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
    public partial class frmStudentClass : Form
    {
        BLSubjectClass sbclass = new BLSubjectClass();
        BLStudentClass student_class = new BLStudentClass();
        BLTeacher te = new BLTeacher();
        BLSubject subject = new BLSubject();
        BLStudentClass stu_clas = new BLStudentClass();

        private string UserName { get; set; }

        public frmStudentClass(string username)
        {
            InitializeComponent();
            UserName = username;
            LoadData();
            this.timer1.Start();
        }

        private void frmStudentClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadData()
        {
            DataTable stuClassTable = stu_clas.GetStudentClassByIdStudent(UserName).Tables[0];
            this.pnlClass.Controls.Clear();
            foreach (DataRow r in stuClassTable.Rows)
            {
                string idClass = r["IdClass"].ToString();
                DataTable dt = sbclass.GetSubjectClassById(idClass).Tables[0];
                string teacherId = dt.Rows[0]["IdTeacher"].ToString();
                string subjectId = dt.Rows[0]["IdSubject"].ToString();
                StudentClassItem item = new StudentClassItem(idClass, te.GetName(teacherId), subject.GetNameSubject(subjectId));
                this.pnlClass.Controls.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StudentClassItem.isViewDetailClass == true)
            {
                frmStudentDetailClass detail = new frmStudentDetailClass(StudentClassItem.temp_id);
                StudentClassItem.isViewDetailClass = false;
                detail.ShowDialog();
            }
        }

        private void frmStudentClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
