using LMSDreams.BS_Layer;
using LMSDreams.CustomControls;
using LMSDreams.GUI.FrmAdmin;
using LMSDreams.GUI.FrmNotification;
using LMSDreams.GUI.FrmTeacher;
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
    public partial class frmTeacherDashBoard : Form
    {
        private string UserName { get; set; }
        frmUserInfor infor;
        frmTeacherNotification send;
        frmReceiveNotification receive;
        frmTeacherClass teacherClass;
        frmAdminInit init;

        BLUser blUser = new BLUser();
        BLUserInfor blUserInfor = new BLUserInfor();
        BLUserRole blUserRole = new BLUserRole();
        BLDataBaseImageTable blimg = new BLDataBaseImageTable();


        public frmTeacherDashBoard(string userName)
        {
            InitializeComponent();
            UserName = userName;
            Init();
        }

        #region Switch Form
        bool menuExpand = false;
        
        private void btnNotification_Click(object sender, EventArgs e)
        {
            this.menuTrasition.Start();
        }

        private void menuTrasition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuTraining.Height += 3;
                if (menuTraining.Height >= 123)
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

        private void btnViewNotification_Click(object sender, EventArgs e)
        {
            if (receive == null)
            {
                receive = new frmReceiveNotification(UserName);
                receive.FormClosed += ReceiveNotification_FormClosed;
                receive.MdiParent = this;
                receive.Dock = DockStyle.Fill;
                receive.Show();
            }
            else
            {
                receive.Activate();
            }
        }

        private void ReceiveNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            receive = null;
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            if (send == null)
            {
                send = new frmTeacherNotification(UserName);
                send.FormClosed += TeacherNotification_FormClosed;
                send.MdiParent = this;
                send.Dock = DockStyle.Fill;
                send.Show();
            }
            else
            {
                send.Activate();
            }
        }

        private void TeacherNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            send = null;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (teacherClass == null)
            {
                teacherClass = new frmTeacherClass(UserName);
                teacherClass.FormClosed += TeacherClass_FormClosed;
                teacherClass.MdiParent = this;
                teacherClass.Dock = DockStyle.Fill;
                teacherClass.Show();
            }
            else
            {
                teacherClass.Activate();
            }
        }

        private void TeacherClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacherClass = null;
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
        #endregion

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
    }
}
