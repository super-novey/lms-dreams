﻿using System;
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
    public partial class frmAddTrainingForm : Form
    {
        public bool isAddTrainingForm = false;
        public frmAddTrainingForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddTrainingForm = true;
            this.Close();
        }
    }
}
