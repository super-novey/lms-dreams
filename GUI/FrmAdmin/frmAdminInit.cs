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
    public partial class frmAdminInit : Form
    {
        public frmAdminInit()
        {
            InitializeComponent();
        }

        private void frmAdminInit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
