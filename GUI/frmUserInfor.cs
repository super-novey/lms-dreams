using LMSDreams.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.GUI
{
    public partial class frmUserInfor : Form
    {
        BLUser blUser;
        BLUserInfor blUserInfor;
        BLDataBaseImageTable blImg;
        private string Username;

        private static readonly ImageConverter _imageConverter = new ImageConverter();
        public frmUserInfor(string username)
        {
            InitializeComponent();
            blUser = new BLUser();
            blUserInfor = new BLUserInfor();
            blImg = new BLDataBaseImageTable();
            Username = username;
            LoadData();
        }

        private void LoadData()
        {
            string idInfo = blUser.GetIdInfo(Username);
            string idImage = blUser.GetIdAvatar(Username);
            DataTable userInfor = blUserInfor.GetUserInfor(idInfo).Tables[0];
            DataTable user = blUser.GetUserByUsername(Username).Tables[0];
            byte[] img = blImg.GetImageString(idImage);

            this.txtUserName.Text = user.Rows[0]["Username"].ToString();
            this.txtPassword.Text = user.Rows [0]["Password"].ToString();
            this.txtFullName.Text = userInfor.Rows[0]["Fullname"].ToString();

            if (userInfor.Rows[0]["Sex"].ToString() == "True")
            {
                this.rbtn_nam.Checked = true;
                this.rbtn_Nu.Checked = false;
            }
            else
            {
                this.rbtn_nam.Checked = false;
                this.rbtn_Nu.Checked = true;
            }
            this.avatarUser.Image = ConvertBytesToImg(img);
            DisableControls();
        }

        private void DisableControls()
        {
            this.txtFullName.Enabled = false;
            this.txtUserName.Enabled = false;
            this.txtPassword.Enabled = false;
            this.rbtn_nam.Enabled = false;
            this.rbtn_Nu.Enabled = false;
        }

        private void frmAdminInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtPassword.Enabled = true;
            this.txtPassword.Clear();
            this.txtPassword.Focus();
            this.avatarUser.Enabled = true;

            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            blUser.UpdatePass(Username, this.txtPassword.Text);
            blImg.UpdateDataBaseImageTable(blUser.GetIdAvatar(Username), ConvertImgToBytes(this.avatarUser.Image));
            MessageBox.Show("Lưu thành công!");
        }

        private void avatarUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarUser.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        public static byte[] ConvertImgToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }    
        }

        public static Image ConvertBytesToImg(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
    }
}
