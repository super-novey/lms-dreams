using LMSDreams.BS_Layer;
using LMSDreams.GUI.FrmNotification;
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
    public partial class frmStudentDashBoard : Form
    {
        frmStudentClass classes;
        frmUserInfor infor;
        frmStudentScore score;
        frmReceiveNotification notification;
        frmStudentCourseRegisterStatus register;

        BLUser blUser = new BLUser();
        BLUserRole blUserRole = new BLUserRole();
        BLUserInfor bLUserInfor = new BLUserInfor();
        BLDataBaseImageTable blimg = new BLDataBaseImageTable();
        
        private string UserName { get; set; }
        public frmStudentDashBoard(string username)
        {
            InitializeComponent();
            UserName = username;
            Init();
        }

        public void Init()
        {
            string idRole = blUser.GetIdRole(UserName);
            string idInfo = blUser.GetIdInfo(UserName);
            string idAvatar = blUser.GetIdAvatar(UserName);


            this.lblDisplayRole.Text = blUserRole.GetRole(idRole);
            this.labelDisplayRole.Text = blUserRole.GetRole(idRole);
            this.lblFullName.Text = bLUserInfor.GetFullName(idInfo);
            this.avatar1.Image = frmUserInfor.ConvertBytesToImg(blimg.GetImageString(idAvatar));
        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            if (classes == null)
            {
                classes = new frmStudentClass(UserName);
                classes.FormClosed += StudentClass_FormClosed;
                classes.MdiParent = this;
                classes.Dock = DockStyle.Fill;
                classes.Show();
            }
            else
            {
                classes.Activate();
            }
        }

        private void StudentClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            classes = null;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (infor == null)
            {
                infor = new frmUserInfor(UserName);
                infor.FormClosed += UserInfo_FormClosed;
                infor.MdiParent = this;
                infor.Dock = DockStyle.Fill;
                infor.Show();
            }
            else
            {
                infor.Activate();
            }
        }

        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            infor = null;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (score == null)
            {
                score = new frmStudentScore(UserName);
                score.FormClosed += StudentScore_FormClosed;
                score.MdiParent = this;
                score.Dock = DockStyle.Fill;
                score.Show();
            }
            else
            {
                score.Activate();
            }
        }

        private void StudentScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            score = null;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (notification == null)
            {
                notification = new frmReceiveNotification(UserName);
                notification.FormClosed += Notification_FormClosed;
                notification.MdiParent = this;
                notification.Dock = DockStyle.Fill;
                notification.Show();
            }
            else
            {
                notification.Activate();
            }
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            notification = null;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (register == null)
            {
                register = new frmStudentCourseRegisterStatus(UserName);
                register.FormClosed += Register_FormClosed;
                register.MdiParent = this;
                register.Dock = DockStyle.Fill;
                register.Show();
            }
            else
            {
                register.Activate();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            notification = null;
        }
    }
}
