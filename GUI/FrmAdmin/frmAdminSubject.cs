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
    public partial class frmAdminSubject : Form
    {
        private const string DefaultText = "Nhập để tìm kiếm";
        DataTable dtSubject = null;
        BLSubject dbSubject = new BLSubject();
        bool isAdd = false;
        DataTable dt;
        public frmAdminSubject()
        {
            InitializeComponent();
            LoadSubject();
            InitializeTextBox();
        }

        private void InitializeTextBox()
        {
            txtSearch.Text = DefaultText;
            txtSearch.ForeColor = System.Drawing.Color.Gray;

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == DefaultText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = DefaultText;
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        void LoadSubject()
        {
            dtSubject = new DataTable();
            dtSubject.Clear();

            DataSet ds = dbSubject.GetSubject();
            dtSubject = ds.Tables[0];

            dgvSubject.DataSource = dtSubject;
            dgvSubject.AutoResizeColumns();

            dgvSubject.Columns[0].HeaderCell.Value = "Mã môn";
            dgvSubject.Columns[1].HeaderCell.Value = "Tên môn";
            dgvSubject.Columns[2].HeaderCell.Value = "Số tín chỉ";

            this.txtSubjectId.ResetText();
            this.txtSubjectName.ResetText();
            this.txtCredit.ResetText();

            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            //dgvSubject_CellClick(null, null);
        }

        private void frmAdminSubjectClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = dgvSubject.CurrentCell.RowIndex;

            this.txtSubjectId.Text = dgvSubject.Rows[r].Cells[0].Value.ToString();
            this.txtSubjectName.Text = dgvSubject.Rows[r].Cells[1].Value.ToString();
            this.txtCredit.Text = dgvSubject.Rows[r].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;

            this.txtSubjectId.ResetText();
            this.txtSubjectName.ResetText();
            this.txtCredit.ResetText();

            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtSubjectId.Focus();
            this.txtSubjectId.Enabled = true;
        }

        private void btnAdd_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnAdd.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnAdd.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnAdd.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAdd = false;
            dgvSubject_CellClick(null, null);

            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtSubjectId.Enabled = false;
            this.txtSubjectName.Focus();
            this.txtCredit.Focus();
        }

        private void btnUpdate_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnUpdate.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnUpdate.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnUpdate.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvSubject.CurrentCell.RowIndex;

            string id = dgvSubject.Rows[r].Cells[0].Value.ToString();

            dbSubject.DeleteSubject(id);
            LoadSubject();
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            btnCancel.BackColor = button.Enabled == false ? Color.DimGray : System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98))))); ;
            btnCancel.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnCancel.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98))))); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                BLSubject blSubject = new BLSubject();
                blSubject.AddSubject(this.txtSubjectId.Text, this.txtSubjectName.Text, this.txtCredit.Text);
                LoadSubject();
            }
            else
            {
                BLSubject blSubject = new BLSubject();
                blSubject.UpdateSubject(this.txtSubjectId.Text, this.txtSubjectName.Text, this.txtCredit.Text);
                LoadSubject();
            }
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
            btnSave.BackColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
            btnSave.ForeColor = button.Enabled == false ? Color.White : Color.White;
            btnSave.FlatAppearance.BorderColor = button.Enabled == false ? Color.DimGray : Color.DarkBlue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtSubjectId.ResetText();
            this.txtSubjectName.ResetText();
            this.txtCredit.ResetText();

            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;

            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.btnSubjectId.BackColor == Color.DarkBlue)
            {
                dt = new DataTable();
                DataSet ds = dbSubject.SearchSubjectById(this.txtSearch.Text);
                dt = ds.Tables[0];
                dgvSubject.DataSource = dt;
            }
            else
            {
                dt = new DataTable();
                DataSet ds = dbSubject.SearchSubjectByName(this.txtSearch.Text);
                dt = ds.Tables[0];
                dgvSubject.DataSource = dt;
            }
        }

        private void btnSubjectId_Click(object sender, EventArgs e)
        {
            this.btnSubjectId.BackColor = Color.DarkBlue;
            this.btnSubjectName.BackColor = Color.DimGray;
        }

        private void btnSubjectName_Click(object sender, EventArgs e)
        {
            this.btnSubjectId.BackColor = Color.DimGray;
            this.btnSubjectName.BackColor = Color.DarkBlue;
        }


    }
}
