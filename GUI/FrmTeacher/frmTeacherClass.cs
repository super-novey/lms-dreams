using LMSDreams.BS_Layer;
using LMSDreams.CustomControls;
using LMSDreams.GUI.FrmStudent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.GUI.FrmTeacher
{
    public partial class frmTeacherClass : Form
    {
        private string UserName { get; set; }
        BLSubjectClass sbclass = new BLSubjectClass();
        BLStudentClass student_class = new BLStudentClass();
        BLTeacher te = new BLTeacher();
        BLSubject subject = new BLSubject();
        BLStudentClass stu_clas = new BLStudentClass();
        public frmTeacherClass(string userName)
        {
            InitializeComponent();
            UserName = userName;
            this.timer1.Start();
        }

        private void LoadData()
        {
            DataTable stuClassTable = sbclass.GetClassByIdTeacher(UserName).Tables[0];
            this.pnlClass.Controls.Clear();
            foreach (DataRow r in stuClassTable.Rows)
            {
                string idClass = r["Id"].ToString();
                DataTable dt = sbclass.GetSubjectClassById(idClass).Tables[0];
                string teacherId = dt.Rows[0]["IdTeacher"].ToString();
                string subjectId = dt.Rows[0]["IdSubject"].ToString();
                StudentClassItem item = new StudentClassItem(idClass, te.GetName(teacherId), subject.GetNameSubject(subjectId));
                this.pnlClass.Controls.Add(item);
            }
        }

        private void frmTeacherClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StudentClassItem.isViewDetailClass == true)
            {
                frmDetailClass detail = new frmDetailClass(StudentClassItem.temp_id);
                StudentClassItem.isViewDetailClass = false;
                detail.ShowDialog();
            }
        }

        private void frmTeacherClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
        #endregion
    }
}
