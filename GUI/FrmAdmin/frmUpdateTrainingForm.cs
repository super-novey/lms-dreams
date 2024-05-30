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
    public partial class frmUpdateTrainingForm : Form
    {
        public bool isSave = false;
        public frmUpdateTrainingForm(string id, string name)
        {
            InitializeComponent();
            this.txtTrainingFormId.Text = id;
            this.txtTraningFormName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isSave = true;
            this.Close();
        }
    }
}
