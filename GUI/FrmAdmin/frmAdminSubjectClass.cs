using LMSDreams.BS_Layer;
using LMSDreams.CustomControls;
using LMSDreams.GUI.FrmAdmin;
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
    public partial class frmAdminSubjectClass : Form
    {
        BLSubjectClass sbclass = new BLSubjectClass();
        BLStudentClass student_class = new BLStudentClass();
        BLSemeter bLSemeter = new BLSemeter();
        DataTable dt = null;
     
        public frmAdminSubjectClass()
        {
            InitializeComponent();
            LoadData();
            this.timer1.Start();
        }

        private void LoadData()
        {
            dt = new DataTable();
            DataSet ds = sbclass.GetSubjectClass();
            dt = ds.Tables[0];
            this.pnlClass.Controls.Clear();
            foreach (DataRow r in dt.Rows)
            {
                int quantity = sbclass.GetQuantity(r["Id"].ToString());
                SubjectClassItem item = new SubjectClassItem(r["Id"].ToString(), r["IdTeacher"].ToString(), quantity.ToString());
                this.pnlClass.Controls.Add(item);
            }

            this.cbSemeter.Items.Clear();
            foreach (DataRow row in bLSemeter.GetSemeter().Tables[0].Rows)
            {
                cbSemeter.Items.Add(row[1].ToString());
            }
            this.cbSemeter.SelectedIndex = 0;
            string status = bLSemeter.GetColumnById(bLSemeter.GetIdByName(this.cbSemeter.Text), 2);

            this.rbtYes.Checked = (status == "True");
            this.rbtNo.Checked = (status == "False");

        }

        private void frmAdminSubjectClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = sbclass.GetSubjectClassById(SubjectClassItem.temp_id);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            frmUpdateSubjectClass f = null;
            foreach (DataRow r in dt.Rows)
            {
                f = new frmUpdateSubjectClass(r["id"].ToString(), r["IdTrainingForm"].ToString(), r["IdSubject"].ToString(), r["IdTeacher"].ToString(), r["IdSemeter"].ToString(), "abc",r["Quantity"].ToString());
            }
            f.ShowDialog();
            if (f.isSave == true)
            {
                sbclass.UpdateSubjectClass(f.txbClassId.Text, f.txbTraningForm.Text, f.txbSubjectId.Text, f.txbTeachId.Text,f.txbSemeter.Text, "AV000" ,Convert.ToInt16(f.txbQuantity.Text));
                LoadData();
                f.isSave = false;
            }    
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSubjectClass f = new frmAddSubjectClass();
            f.ShowDialog();
            if (f.isAddSubjectClass == true)
            {
                sbclass.AddSubjectClass(f.ClassId, f.TrainingFormId, f.SubjectId, f.TeacherId, f.SemeterID, "AV001", f.MaxQuantity);
                LoadData();
                f.isAddSubjectClass = false;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SubjectClassItem.isSelect == true)
            {
                DataSet ds = sbclass.GetDetailSubjectClassById(SubjectClassItem.temp_id);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                BLTeacher te = new BLTeacher();

                this.lblSubjectName.Text = dt.Rows[0]["Displayname"].ToString();
                this.lblIdClass.Text = dt.Rows[0]["Id"].ToString();
                this.lblTraningForm.Text = dt.Rows[0]["IdTrainingForm"].ToString();
                this.lblTeacherName.Text = te.GetName(dt.Rows[0]["IdTeacher"].ToString());
                this.lblQuantity.Text = sbclass.GetQuantity(dt.Rows[0]["Id"].ToString()).ToString();
                this.lblSemeter.Text = dt.Rows[0]["IdSemeter"].ToString();
                this.lblIdSubject.Text = dt.Rows[0]["IdSubject"].ToString();

                SubjectClassItem.isSelect = false;

            }

            if (SubjectClassItem.isViewDetailClass == true)
            {
                frmDetailClass detail = new frmDetailClass(SubjectClassItem.temp_id);
                SubjectClassItem.isViewDetailClass = false;
                detail.ShowDialog();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            student_class.DeleteStudentClassById(SubjectClassItem.temp_id);
            sbclass.DeleteSubjectClass(SubjectClassItem.temp_id);
            LoadData();
        }

        private void btnClassId_Click(object sender, EventArgs e)
        {
            this.btnClassId.BackColor = Color.DarkBlue;
            this.btnTeacherId.BackColor = Color.DimGray;
        }

        private void btnTeacherId_Click(object sender, EventArgs e)
        {
            this.btnTeacherId.BackColor = Color.DarkBlue;
            this.btnClassId.BackColor = Color.DimGray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.btnTeacherId.BackColor == Color.DarkBlue)
            {
                dt = new DataTable();
                DataSet ds = sbclass.SearchSubjectClassByTeacherId(this.txbSearch.Text);
                dt = ds.Tables[0];
                this.pnlClass.Controls.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    SubjectClassItem item = new SubjectClassItem(r["Id"].ToString(), r["IdTeacher"].ToString(), r["Quantity"].ToString());
                    this.pnlClass.Controls.Add(item);
                }
            }
            else
            {
                dt = new DataTable();
                DataSet ds = sbclass.SearchSubjectClassById(this.txbSearch.Text);
                dt = ds.Tables[0];
                this.pnlClass.Controls.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    SubjectClassItem item = new SubjectClassItem(r["Id"].ToString(), r["IdTeacher"].ToString(), r["Quantity"].ToString());
                    this.pnlClass.Controls.Add(item);
                }
            }
        }

        private void frmAdminSubjectClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();
        }

        private void Register(object sender, EventArgs e)
        {
            string id = bLSemeter.GetIdByName(this.cbSemeter.Text);
            string status = this.rbtYes.Checked ? "1" : "0";
            bLSemeter.UpdateSemeter(id, status);
        }

        private void StatusRegister(object sender, EventArgs e)
        {
            string status = bLSemeter.GetColumnById(bLSemeter.GetIdByName(this.cbSemeter.Text), 2);

            this.rbtYes.Checked = (status == "True");
            this.rbtNo.Checked = (status == "False");
        }
    }
}
