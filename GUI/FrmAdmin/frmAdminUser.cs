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

namespace LMSDreams.GUI.FrmAdmin
{
    public partial class frmAdminUser : Form
    {
        BLData bLData = null;

        bool add;
        public frmAdminUser()
        {
            InitializeComponent();
            bLData = new BLData();
            init();
        }

        private void init()
        {
            NamePassRoleSex();
            add = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = true;
            this.btnCreate.Enabled = true;
            loadData();
        }

        private void NamePassRoleSex()
        {

            this.tbFullname.Enabled = false;
            this.tbPass.Enabled = false;
            this.tbUsername.Enabled = false;
            this.rbtnAdmin.Enabled = false;
            this.rbtnTeacher.Enabled = false;
            this.rbtnStudent.Enabled = false;
            this.rbtnNam.Enabled = false;
            this.rbtnNu.Enabled = false;
            this.cbFaculty.Enabled = false;
            this.cbTraingform.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void loadFacultyTrainingForm()
        {
            this.cbFaculty.Items.Clear();
            foreach (string str in bLData.GetFaculty())
            {
                this.cbFaculty.Items.Add(str);
            }
            this.cbFaculty.SelectedIndex = 0;

            this.cbTraingform.Items.Clear();
            foreach (string str in bLData.GetTrainingForm())
            {
                this.cbTraingform.Items.Add(str);
            }
            this.cbTraingform.SelectedIndex = 0;
        }

        private void setFaculty(string faculty)
        {
            for (int i = 0; i < bLData.GetFaculty().Count; i++)
            {
                if (faculty == bLData.GetFaculty()[i])
                {
                    this.cbFaculty.SelectedIndex = i;
                    break;
                }
            }
        }

        private void setTrainingForm(string trainingform)
        {
            for (int i = 0; i < bLData.GetTrainingForm().Count; i++)
            {
                if (trainingform == bLData.GetTrainingForm()[i])
                {
                    this.cbTraingform.SelectedIndex = i;
                    return;
                }
            }
        }

        private void loadData()
        {
            try
            {
                dtgvUser.DataSource = bLData.GetAdminUser().Tables[0];
                dtgvUser.AutoResizeColumns();
                dtgvUser.ReadOnly = true;

                // Đổi tên
                dtgvUser.Columns[0].HeaderCell.Value = "ID";
                dtgvUser.Columns[1].HeaderCell.Value = "Mật khẩu";
                dtgvUser.Columns[2].HeaderCell.Value = "Họ và tên";
                dtgvUser.Columns[3].HeaderCell.Value = "Giới tính";
                dtgvUser.Columns[4].HeaderCell.Value = "Vai trò";

                loadFacultyTrainingForm();
            }
            catch
            {
                MessageBox.Show("Erorr show data in dtgv!");
            }
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txbSearch.Text = "Nhập để tìm kiếm";
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            NamePassRoleSex();
            add = false;
            int r = dtgvUser.CurrentCell.RowIndex;
            string user = dtgvUser.Rows[r].Cells[0].Value.ToString();
            this.tbFullname.Text = dtgvUser.Rows[r].Cells[2].Value.ToString();
            this.tbPass.Text = dtgvUser.Rows[r].Cells[1].Value.ToString();
            this.tbUsername.Text = dtgvUser.Rows[r].Cells[0].Value.ToString();

            if (user == "")
            {
                btnHuy_Click(sender, e);
                return;
            }

            this.cbTraingform.SelectedIndex = -1;

            string role = bLData.GetIdRoleByUser(user);

            if (role == "1")
            {
                rbtnAdmin.Checked = true;
                this.cbFaculty.SelectedIndex = -1;
            }
            else
            if (role == "2")
            {
                rbtnTeacher.Checked = true;
            }
            else
            {
                rbtnStudent.Checked = true;
                setTrainingForm(bLData.GetTraingFormByUser(user));
            }

            string sex = bLData.GetSexByUser(user);
            if (sex == "True")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            setFaculty(bLData.GetFacultyByUser(user));
        }

        private void openButton()
        {
            this.tbFullname.Enabled = true;
            this.tbPass.Enabled = true;
            this.rbtnNu.Enabled = true;
            this.rbtnNam.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnHuy.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            openButton();
            this.cbFaculty.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string user = this.tbUsername.Text;
            string pass = this.tbPass.Text;
            string sex = (this.rbtnNam.Checked == true) ? "True" : "False";
            string name = this.tbFullname.Text;
            string faculty = bLData.GetfacultyByName(this.cbFaculty.Text);
            string trainingform = bLData.GetTrainingFormByName(this.cbTraingform.Text);

            if (name == "")
            {
                MessageBox.Show("Please enter complete information!");
                return;
            }

            if (add)
            {
                if (this.rbtnAdmin.Checked == true)
                {
                    bLData.CreateAdmin(user, pass, name, sex);
                }
                else
                if (this.rbtnStudent.Checked == true)
                {
                    bLData.CreateStudent(user, pass, name, sex, faculty, trainingform);
                }
                else
                {
                    bLData.CreateTeacher(user, pass, name, sex, faculty);
                }
                MessageBox.Show("Thêm thành công!");
                add = false;
            }
            else
            {
                bLData.UpdateUser(user, pass, name, sex);
            }
            init();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.tbFullname.ResetText();
            this.tbUsername.ResetText();
            this.tbPass.ResetText();
            init();
        }

        private void frmAdminUser_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.tbFullname.ResetText();

            openButton();

            this.rbtnAdmin.Enabled = true;
            this.rbtnTeacher.Enabled = true;
            this.rbtnStudent.Enabled = true;
            this.rbtnNam.Checked = true;
            this.rbtnStudent.Checked = true;

            add = true;
            this.create_click(sender, e);
        }

        private void SetCreateUser(List<string> list)
        {
            if (add)
            {
                this.tbPass.Text = list[1];
                this.tbUsername.Text = list[0];
            }
        }

        private void create_click(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = false;
            this.cbFaculty.Enabled = true;
            this.cbFaculty.SelectedIndex = 0;
            this.cbTraingform.Enabled = false;
            this.cbTraingform.SelectedIndex = -1;

            if (this.rbtnAdmin.Checked == true)
            {
                SetCreateUser(bLData.IdRamdom("1"));
                this.cbFaculty.Enabled = false;
                this.cbFaculty.SelectedIndex = -1;
            }
            else
            if (this.rbtnStudent.Checked == true)
            {
                SetCreateUser(bLData.IdRamdom("3"));
                this.cbTraingform.Enabled = true;
                this.cbTraingform.SelectedIndex = 0;
            }
            else
            {
                SetCreateUser(bLData.IdRamdom("2"));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string user = this.txbSearch.Text;
            if (user == "")
            {
                loadData();
                return;
            }
            DataSet ds = bLData.SearchIdUser(user);
            if (ds != null)
            {
                dtgvUser.DataSource = ds.Tables[0];
                dtgvUser.AutoResizeColumns();
                dtgvUser.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Not find it!");
            }

        }

        private void txbSearch_DoubleClick(object sender, EventArgs e)
        {
            this.txbSearch.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dtgvUser.CurrentCell.RowIndex;
            string user = dtgvUser.Rows[r].Cells[0].Value.ToString();
            string role = bLData.GetIdRoleByUser(user);
            bLData.DeleteUser(role, user);
            btnHuy_Click(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
