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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMSDreams.GUI.FrmNotification
{
    public partial class frmTeacherNotification : Form
    {
        string username { get; set; }
        BLData bLData = new BLData();
        bool add = false;


        public frmTeacherNotification(string user)
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
            this.txtTopic.ResetText();
            this.txtTopic.Enabled = false;
            chblstClass.Items.Clear();
            chblstClass.Items.Add("All class");

            foreach (string idclass in bLData.GetLstClassByTeacher(username))
            {
                chblstClass.Items.Add(idclass);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtContent.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.txtTopic.Enabled = true;
            add = true;
        }

        private void sendtoclass(string topic, string content, string idclass)
        {
            foreach (DataRow row in bLData.GetStudentInClass(idclass).Tables[0].Rows)
            {
                string receive = row[0].ToString();
                string id = bLData.GetRandomIdNotification();
                bLData.CreateNotification(id, topic, content, username, receive);
            }
        }
        private void sendallstudent(string topic, string content)
        {
            List<string> list = bLData.GetLstClassByTeacher(username);
            foreach (string idclass in list)
            {
                sendtoclass(topic, content, idclass);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (add)
            {
                string topic = this.txtTopic.Text;
                string content = this.txtContent.Text;
                for (int i = 0; i < chblstClass.Items.Count; i++)
                {
                    if (chblstClass.GetItemChecked(i))
                    {
                        if (i == 0)
                        {
                            sendallstudent(topic, content);
                            break;
                        }
                        sendtoclass(topic, content, chblstClass.Items[i].ToString());
                    }
                }
                MessageBox.Show("Đã gửi");
                add = false;
            }
            init();
        }

        private void frmTeacherNotification_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
