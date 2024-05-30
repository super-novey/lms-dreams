using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.CustomControls
{
    public partial class StudentClassItem : UserControl
    {
        private string ClassId { get; set; }
        private string TeacherName { get; set; }
        private string SubjectName { get; set; }

        public static string temp_id;

        public StudentClassItem(string classId, string teacherName, string subjectName)
        {
            InitializeComponent();
            ClassId = classId;
            TeacherName = teacherName;
            SubjectName = subjectName;
        }

        private void StudentClassItem_Paint(object sender, PaintEventArgs e)
        {
            this.lblIdClass.Text = ClassId;
            this.lblTeacherName.Text = TeacherName;
            this.lblSubjectName.Text = SubjectName;
        }

        public static bool isViewDetailClass = false;
        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            temp_id = ClassId;
            isViewDetailClass = true;
        }
    }
}
