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

namespace LMSDreams.GUI.FrmNotification
{
    public partial class frmReceiveNotification : Form
    {
        string Username { get; set; }
        BLData bLData = new BLData();
        public frmReceiveNotification()
        {
            InitializeComponent();
        }
        public frmReceiveNotification(string user)
        {
            InitializeComponent();
            this.Username = user;
            loadData();
            init();
        }
        private void init()
        {
            this.txtcontent.ResetText();
            this.txttopic.ResetText();
            this.txtnamesend.ResetText();
            this.txtcontent.Enabled = false;
            this.txtnamesend.Enabled = false;
            this.txttopic.Enabled = false;
        }
        private void loadData()
        {
            try
            {
                dtgvNotification.DataSource = bLData.GetLstNotificationOfUser(Username).Tables[0];
                dtgvNotification.AutoResizeColumns();
                dtgvNotification.ReadOnly = true;

                dtgvNotification.Columns[0].HeaderCell.Value = "ID";
                dtgvNotification.Columns[1].HeaderCell.Value = "Tiêu đề";
                dtgvNotification.Columns[2].HeaderCell.Value = "Người gửi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lổi hiện thông báo");
            }
        }

        private void dtgvNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvNotification.CurrentCell.RowIndex;
            string id = dtgvNotification.Rows[r].Cells[0].Value.ToString();
            string send = dtgvNotification.Rows[r].Cells[2].Value.ToString();
            this.txtnamesend.Text = bLData.GetNameByUser(send);
            this.txttopic.Text = dtgvNotification.Rows[r].Cells[1].Value.ToString();
            this.txtcontent.Text = bLData.GetContentById(id);
        }

        private void frmReceiveNotification_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
