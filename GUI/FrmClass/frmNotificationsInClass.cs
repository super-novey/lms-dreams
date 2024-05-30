using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.GUI.FrmClass
{
    public partial class frmNotificationsInClass : Form
    {
        public frmNotificationsInClass()
        {
            InitializeComponent();
        }

        private void frmNotificationsInClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
