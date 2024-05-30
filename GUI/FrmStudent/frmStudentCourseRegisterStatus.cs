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

namespace LMSDreams.GUI.FrmStudent
{
    public partial class frmStudentCourseRegisterStatus : Form
    {
        string UserName { get; set; }
        string trainingForm { get; set; }

        BLData bLData = new BLData();
        BLSubjectClass sbclass = new BLSubjectClass();
        BLSubject bLSubject = new BLSubject();

        bool add = false;
        bool delete = false;
        public frmStudentCourseRegisterStatus()
        {
            InitializeComponent();
        }
        public frmStudentCourseRegisterStatus(string user)
        {
            InitializeComponent();
            UserName = user;
            trainingForm = bLData.GetIdTrainingFormByStudent(user);
            loadData();

        }
        private void loadData()
        {
            dtgvClass.DataSource = bLData.GetLstClassByTrainingForm(trainingForm).Tables[0];
            dtgvClass.AutoResizeColumns();
            dtgvClass.ReadOnly = true;

            dtgvClass.Columns[0].HeaderCell.Value = "Mã môn";
            dtgvClass.Columns[1].HeaderCell.Value = "Tên môn";
            dtgvClass.Columns[2].HeaderCell.Value = "Giáo viên";
            dtgvClass.Columns[3].HeaderCell.Value = "Số tín chỉ";
            dtgvClass.Columns[4].HeaderCell.Value = "SL tối đa";

            DataTable dt = bLData.GetLstSelectedClassByStudent(UserName, trainingForm).Tables[0];
            int credit = 0;
            foreach (DataRow row in dt.Rows)
            {
                credit += int.Parse(row[3].ToString());
            }
            dtgvSelectedClass.DataSource = dt;
            dtgvSelectedClass.AutoResizeColumns();
            dtgvSelectedClass.ReadOnly = true;

            dtgvSelectedClass.Columns[0].HeaderCell.Value = "Mã môn";
            dtgvSelectedClass.Columns[1].HeaderCell.Value = "Tên môn";
            dtgvSelectedClass.Columns[2].HeaderCell.Value = "Giáo viên";
            dtgvSelectedClass.Columns[3].HeaderCell.Value = "Số tín chỉ";
            dtgvSelectedClass.Columns[4].HeaderCell.Value = "SL tối đa";

            this.lblCreditSelected.Text = credit.ToString();
        }

        private void dtgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvClass.CurrentCell.RowIndex;
            string id = dtgvClass.Rows[r].Cells[0].Value.ToString();
            add = true;
            delete = false;
            if (id == "")
                return;

            DataSet ds = sbclass.GetDetailSubjectClassById(id);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            BLTeacher te = new BLTeacher();

            this.lblSubjectName.Text = dt.Rows[0]["Displayname"].ToString();
            this.lblIdClass.Text = dt.Rows[0]["Id"].ToString();
            this.lblTraningForm.Text = dt.Rows[0]["IdTrainingForm"].ToString();
            this.lblTeacherName.Text = te.GetName(dt.Rows[0]["IdTeacher"].ToString());
            this.lblQuantity.Text = sbclass.GetQuantity(dt.Rows[0]["Id"].ToString()).ToString();
            string idSubject = dt.Rows[0]["IdSubject"].ToString();
            this.lblIdSubject.Text = idSubject;
            this.txtCredit.Text = bLSubject.GetCreditSubject(idSubject);
        }

        private void dtgvSelectedClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvSelectedClass.CurrentCell.RowIndex;
            string id = dtgvSelectedClass.Rows[r].Cells[0].Value.ToString();

            add = false;
            delete = true;

            if (id == "")
                return;

            DataSet ds = sbclass.GetDetailSubjectClassById(id);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            BLTeacher te = new BLTeacher();

            this.lblSubjectName.Text = dt.Rows[0]["Displayname"].ToString();
            this.lblIdClass.Text = dt.Rows[0]["Id"].ToString();
            this.lblTraningForm.Text = dt.Rows[0]["IdTrainingForm"].ToString();
            this.lblTeacherName.Text = te.GetName(dt.Rows[0]["IdTeacher"].ToString());
            this.lblQuantity.Text = sbclass.GetQuantity(dt.Rows[0]["Id"].ToString()).ToString();
            string idSubject = dt.Rows[0]["IdSubject"].ToString();
            this.lblIdSubject.Text = idSubject;
            this.txtCredit.Text = bLSubject.GetCreditSubject(idSubject);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (add)
            {
                int r = dtgvClass.CurrentCell.RowIndex;
                string id = dtgvClass.Rows[r].Cells[0].Value.ToString();
                bLData.AddStudentToClass(UserName, id, "-1");
                add = false;
            }
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delete)
            {
                int r = dtgvSelectedClass.CurrentCell.RowIndex;
                string id = dtgvSelectedClass.Rows[r].Cells[0].Value.ToString();
                bLData.DeleteStudentInClass(UserName, id);
                delete = false;
            }
            loadData();
        }

        private void frmStudentCourseRegisterStatus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
