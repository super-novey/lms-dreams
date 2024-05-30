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
    public partial class TrainingFormItem : UserControl
    {
        private string id = "label1";
        private string facultyName = "label1";
        private Color backColor = Color.DarkBlue;
        public static string tempFacultyId;
        public TrainingFormItem()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return id; }
            set { id = value;
            this.Invalidate();}
        }

        public string FacultyName
        {
            get { return facultyName; }
            set {
                facultyName = value;
            this.Invalidate(); }
        }

        private void TrainingFormItem_Paint(object sender, PaintEventArgs e)
        {
            this.lblId.Text = Id;
            this.lblName.Text = FacultyName;
            this.flowLayoutPanel1.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            tempFacultyId = this.Id;
        }

        bool isClick = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isClick == true)
            {
                this.flowLayoutPanel1.Show();
                isClick = false;

            }
            else
            {
                this.flowLayoutPanel1.Hide();
                isClick = true;

            }
        }
        public static bool isDeleteTrainingForm = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDeleteTrainingForm = true;
            tempFacultyId=this.Id;
            this.panel5.Hide();
        }
        public static bool isUpdateTrainingForm = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isUpdateTrainingForm = true;
            tempFacultyId = this.Id;
            this.panel5.Hide();
        }
    }
}
