using LMSDreams.BS_Layer;
using LMSDreams.GUI.FrmAdmin;
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

namespace LMSDreams.GUI
{
    public partial class frmAdminDashBoard : Form
    {
        frmUserInfor adminInfo;
        frmAdminSubject subject;
        frmAdminFaculty faculty;
        frmAdminSubjectClass subjectclass;
        frmAdminInit init;
        frmAdminUser user;
        frmAdminNotificationUser notification;

        BLUser blUser = new BLUser();
        BLUserInfor blUserInfor = new BLUserInfor();
        BLUserRole blUserRole = new BLUserRole();
        BLDataBaseImageTable blimg = new BLDataBaseImageTable();

        private string UserName { get; set; }

        public frmAdminDashBoard(string username)
        {
            InitializeComponent();
            UserName = username;
            frmInit();
            Init();
        }

        private void Init()
        {
            string idRole = blUser.GetIdRole(UserName);
            string idInfo = blUser.GetIdInfo(UserName);
            string idAvatar = blUser.GetIdAvatar(UserName);

            this.lblDisplayRole.Text = blUserRole.GetRole(idRole);
            this.labelDisplayRole.Text = blUserRole.GetRole(idRole);
            this.lblFullName.Text = blUserInfor.GetFullName(idInfo);
            this.avatar1.Image = frmUserInfor.ConvertBytesToImg(blimg.GetImageString(idAvatar));
        }

        bool menuExpand = false;
        private void menuTrasition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuTraining.Height += 3;
                if (menuTraining.Height >= 160)
                {
                    menuTrasition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuTraining.Height -= 3;
                if (menuTraining.Height <= 40)
                {
                    menuTrasition.Stop();
                    menuExpand = false;

                }
            }
        }

        private void btnTraining_Click_1(object sender, EventArgs e)
        {
            menuTrasition.Start();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (adminInfo == null)
            {
                adminInfo = new frmUserInfor(UserName);
                adminInfo.FormClosed += AdminInfo_FormClosed;
                adminInfo.MdiParent = this;
                adminInfo.Dock = DockStyle.Fill;
                adminInfo.Show();
            }
            else
            {
                adminInfo.Activate();
            }
        }

        private void AdminInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminInfo = null;
        }

        private void btnSubjectClass_Click(object sender, EventArgs e)
        {
            if (subjectclass == null)
            {
                subjectclass = new frmAdminSubjectClass();
                subjectclass.FormClosed += Subjectclass_FormClosed;
                subjectclass.MdiParent = this;
                subjectclass.Dock = DockStyle.Fill;
                subjectclass.Show();
            }
            else
            {
                subjectclass.Activate();
            }
        }

        private void Subjectclass_FormClosed(object sender, FormClosedEventArgs e)
        {
            subjectclass = null;
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            if (faculty == null)
            {
                faculty = new frmAdminFaculty();
                faculty.FormClosed += Faculty_FormClosed;
                faculty.MdiParent = this;
                faculty.Dock = DockStyle.Fill;
                faculty.Show();
            }
            else
            {
                faculty.Activate();
            }
        }

        private void Faculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            faculty = null;
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (subject == null)
            {
                subject = new frmAdminSubject();
                subject.FormClosed += Subject_FormClosed;
                subject.MdiParent = this;
                subject.Dock = DockStyle.Fill;
                subject.Show();
            }
            else
            {
                subject.Activate();
            }
        }

        private void Subject_FormClosed(object sender, FormClosedEventArgs e)
        {
            subject = null;
        }

        private void frmInit()
        {
            if (init == null)
            {
                init = new frmAdminInit();
                init.FormClosed += Init_FormClosed;
                init.MdiParent = this;
                init.Dock = DockStyle.Fill;
                init.Show();
            }
            else
            {
                init.Activate();
            }
        }

        private void Init_FormClosed(object sender, FormClosedEventArgs e)
        {
            init = null;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new frmAdminUser();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Dock = DockStyle.Fill;
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            user = null;
        }

        private void frmAdminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (notification == null)
            {
                notification = new frmAdminNotificationUser(UserName);
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
    }
}
