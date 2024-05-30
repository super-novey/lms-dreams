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

namespace LMSDreams.GUI.FrmStudent
{
    public partial class frmStudentScore : Form
    {
        private string UserName { get; set; }
        BLScore score = new BLScore();
        public frmStudentScore(string username)
        {
            InitializeComponent();
            UserName = username;
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = score.ShowScoreOfStudent(UserName); 
            this.dtgvScore.DataSource = dt;
            this.dtgvScore.ReadOnly = true;

            List<double> s = score.CalculateOveral(UserName);
            this.lblOveral.Text = s[0].ToString();
            this.lblCredit.Text = s[1].ToString();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }
    }
}
