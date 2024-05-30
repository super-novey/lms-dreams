using LMSDreams.BS_Layer;
using LMSDreams.GUI.FrmStudent;
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
    public partial class frmLogin : Form
    {
        BLUser bLUser = null;
        public static string sender;
        public frmLogin()
        {
            InitializeComponent();
            bLUser = new BLUser();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = checkUserPass(customeTextbox1.TextBox, customeTextbox2.TextBox);
            if (check)
            {
                showform(customeTextbox1.TextBox);
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!");
            }
        }

        private void showform(string username)
        {
            string id = bLUser.GetIdRole(username);
            switch(id)
            {
                case "1":
                    sender = username;
                    frmAdminDashBoard f = new frmAdminDashBoard(username);
                    f.ShowDialog();
    
                    break;
                case "2":
                    sender = username;
                    frmTeacherDashBoard a = new frmTeacherDashBoard(username);
                    a.ShowDialog();
                    
                    break;
                default:
                    frmStudentDashBoard b = new frmStudentDashBoard(username);
                    b.ShowDialog();
                    
                    break;
            }    
            
        }

        private bool checkUserPass(string user, string pass)
        {
            return bLUser.checkUserPass(user, pass);
        }
    }
}
