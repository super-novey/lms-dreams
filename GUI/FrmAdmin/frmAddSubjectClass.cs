using LMSDreams.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LMSDreams.GUI
{
    public partial class frmAddSubjectClass : Form
    {
        public bool isAddSubjectClass = false;
        BLData bLData = new BLData();
        BLSubjectClass bLSubjectClass = new BLSubjectClass();

        public string ClassId;
        public string SubjectId;
        public string TeacherId;
        public string TrainingFormId;
        public string SemeterID;
        public int MaxQuantity = 0;

        public frmAddSubjectClass()
        {
            InitializeComponent();
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassId = this.txbClassId.Text;
            TeacherId = this.cbTeacherId.Text;
            SemeterID = this.cbSemeter.Text;
            try
            {
                MaxQuantity = Convert.ToInt16(this.txtMaxQuantity.Text);
            }
            catch
            {
                MaxQuantity = 0;
            }
            SubjectId = this.cbSubjectId.Text;
            TrainingFormId = this.cbTrainingForm.Text;
            isAddSubjectClass = true;
            this.Close();
        }

        private void LoadData()
        {
            this.txbClassId.Text = bLSubjectClass.CreateIdClass();
            LoadCBTrainingForm();
            LoadCBSubjectId();
            LoadCBTeacherId();
            LoadCBSemeter();
        }

        private void LoadCBTrainingForm()
        {
            this.cbTrainingForm.Items.Clear();
            foreach (string str in bLData.GetTrainingFormId())
            {
                this.cbTrainingForm.Items.Add(str);
            }
            this.cbTrainingForm.SelectedIndex = 0;
        }

        private void LoadCBSubjectId()
        {
            this.cbSubjectId.Items.Clear();
            foreach (string str in bLData.GetSubject())
            {
                this.cbSubjectId.Items.Add(str);
            }
            this.cbSubjectId.SelectedIndex = 0;
        }

        private void LoadCBTeacherId()
        {
            this.cbTeacherId.Items.Clear();
            foreach (string str in bLData.GetTeacher())
            {
                this.cbTeacherId.Items.Add(str);
            }
            this.cbTeacherId.SelectedIndex = 0;
        }

        private void LoadCBSemeter()
        {
            this.cbSemeter.Items.Clear();
            foreach (string str in bLData.GetSemeter())
            {
                this.cbSemeter.Items.Add(str);
            }
            this.cbSemeter.SelectedIndex = 0;
        }
    }
}
