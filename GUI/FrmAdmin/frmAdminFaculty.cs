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

namespace LMSDreams.GUI.FrmAdmin
{
    public partial class frmAdminFaculty : Form
    {
        DataTable dtFaculty = null;
        DataTable dtTrainingForm = null;
        BLFaculty dbFaculty = new BLFaculty();
        BLTrainingForm dbTrainingForm = new BLTrainingForm();
        DataTable dt;
        bool isAdd = false;
        public frmAdminFaculty()
        {
            InitializeComponent();
            LoadTrainingForm();
            LoadFaculty();
            timer1.Start();
        }

        private void frmAdminFaculty_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoadTrainingForm()
        {
            dtTrainingForm = new DataTable();
            dtTrainingForm.Clear();

            DataSet dsTrain = dbTrainingForm.GetTrainingForm();
            dtTrainingForm = dsTrain.Tables[0];

            this.flowLayoutPanel1.Controls.Clear();
            foreach (DataRow r in dtTrainingForm.Rows)
            {
                TrainingFormItem item = new TrainingFormItem();
                item.Id = r["Id"].ToString();
                item.FacultyName = r["Displayname"].ToString();

                this.flowLayoutPanel1.Controls.Add(item);
            }    
            
        }

        void LoadFaculty()
        {
            dtFaculty = new DataTable();
            dtFaculty.Clear();

            DataSet ds = dbFaculty.GetFaculty();
            dtFaculty = ds.Tables[0];

            dgvFaculty.DataSource = dtFaculty;
            dgvFaculty.AutoResizeColumns();

            dgvFaculty.Columns[0].HeaderCell.Value = "Mã khoa";
            dgvFaculty.Columns[1].HeaderCell.Value = "Tên khoa";


            // Xóa trống các textbox
            this.txtFacultyId.ResetText();
            this.txtFacultyName.ResetText();

            // Cho thao tác các nút
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            //dgvFaculty_CellClick(null, null);
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvFaculty.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtFacultyId.Text = dgvFaculty.Rows[r].Cells[0].Value.ToString();
            this.txtFacultyName.Text = dgvFaculty.Rows[r].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;

            // Xóa trống các textbox
            this.txtFacultyId.ResetText();
            this.txtFacultyName.ResetText();
            

            // thao tác các nút lưu hủy
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            // không thao tác trên các nút thêm xóa
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtFacultyId.Focus();
        }

        private void btnAdd_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnAdd.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnAdd.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnAdd.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnUpdate_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnUpdate.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnUpdate.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnUpdate.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAdd = false;
            dgvFaculty_CellClick(null, null);

            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtFacultyId.Enabled = false;
            this.txtFacultyName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                BLFaculty blFaculty = new BLFaculty();
                blFaculty.AddFaculty(this.txtFacultyId.Text, this.txtFacultyName.Text);
                LoadFaculty();
            }    
            else
            {
                BLFaculty blFaculty = new BLFaculty();
                blFaculty.UpdateFaculty(this.txtFacultyId.Text, this.txtFacultyName.Text);
                LoadFaculty();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtFacultyName.ResetText();
            this.txtFacultyId.ResetText();

            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            btnSave.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnSave.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnSave.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnCancel_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnCancel.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnCancel.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnCancel.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnCancel.BackColor = button.Enabled == false ? Color.DimGray : System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98))))); ;
            btnCancel.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnCancel.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98))))); ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvFaculty.CurrentCell.RowIndex;

            string id  = dgvFaculty.Rows[r].Cells[0].Value.ToString();

            dbFaculty.DeleteFaculty(id);
            LoadFaculty();
        }

        private void trainingFormItem1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTrainingForm_Click(object sender, EventArgs e)
        {
            frmAddTrainingForm f = new frmAddTrainingForm();
            f.ShowDialog();
            if (f.isAddTrainingForm == true)
            {
                dbTrainingForm.AddTrainingForm(f.txtTrainingFormId.Text,f.txtTraningFormName.Text);
                LoadTrainingForm();
                f.isAddTrainingForm = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TrainingFormItem.isDeleteTrainingForm == true)
            {
                BLTrainingForm b = new BLTrainingForm();
                b.DeleteTrainingForm(TrainingFormItem.tempFacultyId);
                LoadTrainingForm();
                TrainingFormItem.isDeleteTrainingForm = false;
            }

            if (TrainingFormItem.isUpdateTrainingForm == true)
            {
                BLTrainingForm b = new BLTrainingForm();
                TrainingFormItem.isUpdateTrainingForm = false;
                DataSet a = b.GetTrainingFormById(TrainingFormItem.tempFacultyId.ToString());
                DataTable d = a.Tables[0];
                frmUpdateTrainingForm f = new frmUpdateTrainingForm(d.Rows[0]["Id"].ToString(), d.Rows[0]["Displayname"].ToString());
                LoadTrainingForm();
                f.ShowDialog();

                if (f.isSave == true)
                {
                    b.UpdateTrainingForm(TrainingFormItem.tempFacultyId, f.txtTraningFormName.Text);
                    LoadTrainingForm();
                    f.isSave = false;
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.btnTrainingFormId.BackColor == Color.DarkBlue)
            {
                dt = new DataTable();
                DataSet ds = dbFaculty.SearchFacultyById(this.txtSearch.Text);
                dt = ds.Tables[0];
                dgvFaculty.DataSource = dt;
            }
            else
            {
                dt = new DataTable();
                DataSet ds = dbFaculty.SearchFacultyByName(this.txtSearch.Text);
                dt = ds.Tables[0];
                dgvFaculty.DataSource = dt;
            }
        }

        private void btnTrainingFormId_Click(object sender, EventArgs e)
        {
            this.btnTrainingFormId.BackColor = Color.DarkBlue;
            this.btnTrainingFormName.BackColor = Color.DimGray;
        }

        private void btnTrainingFormName_Click(object sender, EventArgs e)
        {
            this.btnTrainingFormName.BackColor = Color.DarkBlue;
            this.btnTrainingFormId.BackColor = Color.DimGray;
        }
    }
}
