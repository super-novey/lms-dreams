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

namespace LMSDreams.GUI.FrmClass
{
    public partial class frmStudentsInClass : Form
    {
        BLData bLData = new BLData();
        string IdClass { get; set; }
        bool add = false;
        public frmStudentsInClass()
        {
            InitializeComponent();
        }
        public frmStudentsInClass(string id)
        {
            InitializeComponent();
            IdClass = id;
            loadData();
            init();
        }

        private void frmStudentsInClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void loadData()
        {
            try
            {
                dgvStudent.DataSource = bLData.GetStudentInClass(IdClass).Tables[0];
                dgvStudent.AutoResizeColumns();
                dgvStudent.ReadOnly = true;
                dgvStudent.Columns[0].HeaderCell.Value = "MSSV";
                dgvStudent.Columns[1].HeaderCell.Value = "Họ và tên";
                dgvStudent.Columns[2].HeaderCell.Value = "Giới tính";
                dgvStudent.Columns[3].HeaderCell.Value = "Điểm";
            }
            catch
            {
                MessageBox.Show("Erorr data!");
            }
        }
        private void init()
        {
            this.txtStudentId.Enabled = false;
            this.txtStudentName.Enabled = false;
            this.txtStudentScore.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.rbtnNam.Enabled = false;
            this.rbtnNu.Enabled = false;
        }
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txbSearch.Text = "Nhập để tìm kiếm";
            add = false;
            int r = dgvStudent.CurrentCell.RowIndex;
            string user = dgvStudent.Rows[r].Cells[0].Value.ToString();
            string name = dgvStudent.Rows[r].Cells[1].Value.ToString();
            string sex = dgvStudent.Rows[r].Cells[2].Value.ToString();
            string score = dgvStudent.Rows[r].Cells[3].Value.ToString();

            this.txtStudentId.Text = user;
            this.txtStudentName.Text = name;
            this.txtStudentScore.Text = score;

            if (sex == "True")
            {
                this.rbtnNam.Checked = true;
            }
            else
            {
                this.rbtnNu.Checked = true;
            }
            this.txtStudentScore.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.txtStudentScore.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvStudent.CurrentCell.RowIndex;
            string user = dgvStudent.Rows[r].Cells[0].Value.ToString();

            bLData.DeleteStudentInClass(user, IdClass);
            init();
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string student = this.txtStudentId.Text;
            string score = this.txtStudentScore.Text;
            if (add)
            {
                bLData.AddStudentToClass(student, IdClass, score);
                add = false;
            }
            else
            {
                bLData.UpdateScoreByUser(student, IdClass, score);
            }
            loadData();
            init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtStudentId.ResetText();
            this.txtStudentId.Enabled = true;
            this.btnSave.Enabled = true;
            add = true;
            this.btnDelete.Enabled = false;
            this.btnUpdate.Enabled = false;
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            this.txtStudentName.ResetText();
            this.txtStudentScore.Enabled = false;
            this.txtStudentScore.ResetText();
            this.rbtnNu.Checked = false;
            this.rbtnNam.Checked = false;
            string user = this.txtStudentId.Text;
            if (bLData.CheckUser(user, "3") && !bLData.CheckStudentInClass(user, IdClass))
            {
                this.txtStudentName.Text = bLData.GetNameByUser(user);
                if (bLData.GetSexByUser(user) == "True")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                this.txtStudentScore.Enabled = true;
                this.txtStudentScore.Text = "-1";
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string student = this.txbSearch.Text;
            if (bLData.CheckUser(student, "3"))
            {
                dgvStudent.DataSource = bLData.SearchStudentByClass(student, IdClass).Tables[0];
                dgvStudent.AutoResizeColumns();
                dgvStudent.ReadOnly = true;
            }
            if (student == "")
            {
                loadData();
            }
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            this.txbSearch.ResetText();
        }
    }
}
