namespace LMSDreams.GUI.FrmStudent
{
    partial class frmTeacherDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayRole = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDisplayRole = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.avatar1 = new LMSDreams.CustomControls.avatar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuTrasition = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTraining = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnViewNotification = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuTraining.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDisplayRole);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblDisplayRole
            // 
            this.lblDisplayRole.AutoSize = true;
            this.lblDisplayRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisplayRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRole.Location = new System.Drawing.Point(306, 20);
            this.lblDisplayRole.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisplayRole.Name = "lblDisplayRole";
            this.lblDisplayRole.Size = new System.Drawing.Size(0, 21);
            this.lblDisplayRole.TabIndex = 5;
            this.lblDisplayRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelDisplayRole);
            this.panel5.Controls.Add(this.lblFullName);
            this.panel5.Controls.Add(this.avatar1);
            this.panel5.Location = new System.Drawing.Point(869, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 65);
            this.panel5.TabIndex = 4;
            // 
            // labelDisplayRole
            // 
            this.labelDisplayRole.AutoSize = true;
            this.labelDisplayRole.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayRole.ForeColor = System.Drawing.Color.DimGray;
            this.labelDisplayRole.Location = new System.Drawing.Point(96, 29);
            this.labelDisplayRole.Name = "labelDisplayRole";
            this.labelDisplayRole.Size = new System.Drawing.Size(0, 20);
            this.labelDisplayRole.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(68, 6);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(151, 21);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Lê Thị Thùy Duyên";
            // 
            // avatar1
            // 
            this.avatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar1.Image = ((System.Drawing.Image)(resources.GetObject("avatar1.Image")));
            this.avatar1.Location = new System.Drawing.Point(4, 4);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(60, 57);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar1.TabIndex = 3;
            this.avatar1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMSDreams.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 564);
            this.panel2.TabIndex = 1;
            // 
            // menuTrasition
            // 
            this.menuTrasition.Interval = 1;
            this.menuTrasition.Tick += new System.EventHandler(this.menuTrasition_Tick_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.flowLayoutPanel2.Controls.Add(this.menuTraining);
            this.flowLayoutPanel2.Controls.Add(this.btnInfo);
            this.flowLayoutPanel2.Controls.Add(this.btnClass);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(213, 564);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // menuTraining
            // 
            this.menuTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.menuTraining.Controls.Add(this.btnNotification);
            this.menuTraining.Controls.Add(this.btnViewNotification);
            this.menuTraining.Controls.Add(this.btnSendNotification);
            this.menuTraining.Location = new System.Drawing.Point(0, 0);
            this.menuTraining.Margin = new System.Windows.Forms.Padding(0);
            this.menuTraining.Name = "menuTraining";
            this.menuTraining.Size = new System.Drawing.Size(213, 40);
            this.menuTraining.TabIndex = 11;
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = global::LMSDreams.Properties.Resources.arrow_down_sign_to_navigate;
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotification.Location = new System.Drawing.Point(0, 0);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnNotification.Size = new System.Drawing.Size(213, 40);
            this.btnNotification.TabIndex = 1;
            this.btnNotification.Text = "Thông báo";
            this.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnViewNotification
            // 
            this.btnViewNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnViewNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewNotification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnViewNotification.FlatAppearance.BorderSize = 0;
            this.btnViewNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNotification.ForeColor = System.Drawing.Color.White;
            this.btnViewNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnViewNotification.Image")));
            this.btnViewNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewNotification.Location = new System.Drawing.Point(0, 40);
            this.btnViewNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewNotification.Name = "btnViewNotification";
            this.btnViewNotification.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnViewNotification.Size = new System.Drawing.Size(213, 40);
            this.btnViewNotification.TabIndex = 0;
            this.btnViewNotification.Text = "Xem thông báo";
            this.btnViewNotification.UseVisualStyleBackColor = false;
            this.btnViewNotification.Click += new System.EventHandler(this.btnViewNotification_Click);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSendNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendNotification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSendNotification.FlatAppearance.BorderSize = 0;
            this.btnSendNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnSendNotification.Image")));
            this.btnSendNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendNotification.Location = new System.Drawing.Point(0, 80);
            this.btnSendNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnSendNotification.Size = new System.Drawing.Size(213, 40);
            this.btnSendNotification.TabIndex = 0;
            this.btnSendNotification.Text = "Gửi thông báo";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 40);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnInfo.Size = new System.Drawing.Size(213, 40);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "          Thông tin cá nhân";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClass.Location = new System.Drawing.Point(0, 80);
            this.btnClass.Margin = new System.Windows.Forms.Padding(0);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnClass.Size = new System.Drawing.Size(210, 40);
            this.btnClass.TabIndex = 13;
            this.btnClass.Text = "Danh sách lớp học";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // frmTeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 634);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeacherDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý trang dạy học số";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuTraining.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDisplayRole;
        private System.Windows.Forms.Label lblFullName;
        private CustomControls.avatar avatar1;
        private System.Windows.Forms.Timer menuTrasition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel menuTraining;
        private System.Windows.Forms.Button btnViewNotification;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Label lblDisplayRole;
        private System.Windows.Forms.Button btnNotification;
    }
}