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
    public partial class frmUpdateSubjectClass : Form
    {
        public frmUpdateSubjectClass(string id, string trainingform, string subject, string teacher, string semeter, string thumbnail,string quantity)
        {
            InitializeComponent();
            this.txbClassId.Text = id;
            this.txbQuantity.Text = quantity;
            this.txbSemeter.Text = semeter;
            this.txbTraningForm.Text = trainingform;
            this.txbTeachId.Text = teacher;
            this.txbSubjectId.Text = subject;
    
        }
        public bool isSave = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isSave = true;
            this.Close();
        }
    }
}
