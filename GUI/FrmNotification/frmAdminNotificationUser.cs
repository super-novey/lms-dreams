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

namespace LMSDreams.GUI.FrmNotification
{
    public partial class frmAdminNotificationUser : Form
    {
        string username { get; set; }
        BLData bLData = new BLData();
        bool add = false;

        public frmAdminNotificationUser()
        {
            InitializeComponent();
            init();
        }
        public frmAdminNotificationUser(string user)
        {
            InitializeComponent();
            this.username = user;
            init();
        }

        private void init()
        {
            this.txtsend.Text = bLData.GetNameByUser(username);
            this.txtsend.Enabled = false;
            this.txtContent.ResetText();
            this.txtId.ResetText();
            this.txtTopic.ResetText();
            this.txtTopic.Enabled = false;
            this.txtId.Enabled = false;

            this.cbUser.Items.Clear();
            this.cbUser.Items.Add("Sinh viên");
            this.cbUser.Items.Add("Giảng viên");

            this.cbUser.Enabled = false;
            this.cbFaculty.Enabled = false;
            this.cbTrainingForm.Enabled = false;

            this.cbFaculty.Items.Clear();
            foreach (string faculty in bLData.GetFaculty())
            {
                this.cbFaculty.Items.Add(faculty);
            }
            this.cbFaculty.SelectedIndex = 0;

            this.cbTrainingForm.Items.Clear();
            foreach (string trainingform in bLData.GetTrainingForm())
            {
                this.cbTrainingForm.Items.Add(trainingform);
            }
            this.cbTrainingForm.SelectedIndex = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtContent.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            init();
        }

        private void sendToListId(string topic, string content, List<string> list)
        {
            foreach (string receive in list)
            {
                string id = bLData.GetRandomIdNotification();
                bLData.CreateNotification(id, topic, content, username, receive);
            }
        }
        private void SendByFaculty(string topic, string content, string faculty, string role)
        {
            if (role == "1")
            {
                List<string> list = bLData.GetlstIdUserByFaculty(faculty);
                sendToListId(topic, content, list);
            }
            else
            if (role == "2")
            {
                List<string> list = bLData.GetIdTeacherByFaculty(faculty);
                sendToListId(topic, content, list);
            }
            else
            {
                List<string> list = bLData.GetIdStudentByFaculty(faculty);
                sendToListId(topic, content, list);
            }
        }
        private void SendTeacher(string topic, string content)
        {
            if (this.chbFaculty.Checked == true)
            {
                string faculty = bLData.GetfacultyByName(this.cbFaculty.Text);
                SendByFaculty(topic, content, faculty, "2");
            }
            else
            {
                List<string> list = bLData.GetIdTeacher();
                sendToListId(topic, content, list);
            }
        }
        private void SendStudent(string topic, string content)
        {
            if (this.chbFaculty.Checked == true)
            {
                string faculty = bLData.GetfacultyByName(this.cbFaculty.Text);
                if (this.chbTrainingform.Checked)
                {
                    string trainingform = bLData.GetTrainingFormByName(this.cbTrainingForm.Text);
                    List<string> list = bLData.GetIdStudentByFacultyTrainingForm(faculty, trainingform);
                    sendToListId(topic, content, list);
                }
                else
                {
                    SendByFaculty(topic, content, faculty, "3");
                }
            }
            else
            {
                List<string> list = bLData.GetIdStudent();
                sendToListId(topic, content, list);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (add)
            {
                string topic = this.txtTopic.Text;
                string content = this.txtContent.Text;

                if (this.chbUser.Checked == false && this.chbFaculty.Checked == false)
                {
                    string receive = this.txtId.Text;
                    if (bLData.CheckUser(receive, receive[0].ToString()))
                    {
                        string id = bLData.GetRandomIdNotification();
                        bLData.CreateNotification(id, topic, content, username, receive);
                        MessageBox.Show("Đã gửi!");
                    }
                    else
                    {
                        MessageBox.Show("Id not in data!");
                    }

                }
                else
                {
                    if (this.chbUser.Checked == true)
                    {
                        if (this.cbUser.Text == "Giảng viên")
                        {
                            SendTeacher(topic, content);
                        }
                        else
                        {
                            SendStudent(topic, content);
                        }
                    }
                    else
                    if (this.chbFaculty.Checked == true)
                    {
                        string faculty = bLData.GetfacultyByName(this.cbFaculty.Text);
                        SendByFaculty(topic, content, faculty, "1");
                    }
                }

                add = false;
            }
            init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            add = true;
            this.txtId.Enabled = true;
            this.txtTopic.Enabled = true;
        }

        private void cbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            string user = this.cbUser.Text;
            if (user == "Giảng viên")
            {
                this.cbTrainingForm.Enabled = false;
                this.cbTrainingForm.SelectedIndex = -1;
            }
            else
            {
                this.cbTrainingForm.Enabled = true;
                this.cbTrainingForm.SelectedIndex = 0;
            }
        }

        private void chbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbUser.Checked)
            {
                this.cbUser.Enabled = true;
                this.txtId.ResetText();
            }
            else
            {
                this.cbUser.Enabled = false;
                this.cbTrainingForm.Enabled = false;
            }
        }

        private void chbFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbFaculty.Checked)
            {
                this.cbFaculty.Enabled = true;
                this.txtId.ResetText();
            }
            else
            {
                this.cbFaculty.Enabled = false;
            }
        }

        private void chbTrainingform_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbTrainingform.Checked && this.cbUser.Enabled && this.cbUser.SelectedIndex == 0)
            {
                this.cbTrainingForm.Enabled = true;
            }
            else
            {
                this.cbTrainingForm.Enabled = false;
            }
        }

        private void frmAdminNotificationUser_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
