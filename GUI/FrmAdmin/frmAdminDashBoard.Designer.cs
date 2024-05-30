namespace LMSDreams.GUI
{
    partial class frmAdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayRole = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDisplayRole = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuTrasition = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTraining = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnSubjectClass = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.avatar1 = new LMSDreams.CustomControls.avatar();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
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
            this.panel5.Size = new System.Drawing.Size(238, 65);
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
            this.menuTrasition.Tick += new System.EventHandler(this.menuTrasition_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.flowLayoutPanel2.Controls.Add(this.menuTraining);
            this.flowLayoutPanel2.Controls.Add(this.btnInfo);
            this.flowLayoutPanel2.Controls.Add(this.btnNotification);
            this.flowLayoutPanel2.Controls.Add(this.btnUser);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(213, 564);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // menuTraining
            // 
            this.menuTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.menuTraining.Controls.Add(this.btnTraining);
            this.menuTraining.Controls.Add(this.btnSubjectClass);
            this.menuTraining.Controls.Add(this.btnFaculty);
            this.menuTraining.Controls.Add(this.btnSubject);
            this.menuTraining.Location = new System.Drawing.Point(0, 0);
            this.menuTraining.Margin = new System.Windows.Forms.Padding(0);
            this.menuTraining.Name = "menuTraining";
            this.menuTraining.Size = new System.Drawing.Size(213, 40);
            this.menuTraining.TabIndex = 11;
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnTraining.FlatAppearance.BorderSize = 0;
            this.btnTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.ForeColor = System.Drawing.Color.White;
            this.btnTraining.Image = global::LMSDreams.Properties.Resources.arrow_down_sign_to_navigate;
            this.btnTraining.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraining.Location = new System.Drawing.Point(0, 0);
            this.btnTraining.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnTraining.Size = new System.Drawing.Size(213, 40);
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Text = "Cài đặt";
            this.btnTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click_1);
            // 
            // btnSubjectClass
            // 
            this.btnSubjectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSubjectClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSubjectClass.FlatAppearance.BorderSize = 0;
            this.btnSubjectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectClass.ForeColor = System.Drawing.Color.White;
            this.btnSubjectClass.Image = ((System.Drawing.Image)(resources.GetObject("btnSubjectClass.Image")));
            this.btnSubjectClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectClass.Location = new System.Drawing.Point(0, 40);
            this.btnSubjectClass.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectClass.Name = "btnSubjectClass";
            this.btnSubjectClass.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnSubjectClass.Size = new System.Drawing.Size(213, 40);
            this.btnSubjectClass.TabIndex = 0;
            this.btnSubjectClass.Text = "Lớp môn học";
            this.btnSubjectClass.UseVisualStyleBackColor = false;
            this.btnSubjectClass.Click += new System.EventHandler(this.btnSubjectClass_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaculty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnFaculty.FlatAppearance.BorderSize = 0;
            this.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.ForeColor = System.Drawing.Color.White;
            this.btnFaculty.Image = ((System.Drawing.Image)(resources.GetObject("btnFaculty.Image")));
            this.btnFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaculty.Location = new System.Drawing.Point(0, 80);
            this.btnFaculty.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnFaculty.Size = new System.Drawing.Size(213, 40);
            this.btnFaculty.TabIndex = 0;
            this.btnFaculty.Text = "          Khoa - Hệ đào tạo";
            this.btnFaculty.UseVisualStyleBackColor = false;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnSubject.Image")));
            this.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.Location = new System.Drawing.Point(0, 120);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnSubject.Size = new System.Drawing.Size(213, 40);
            this.btnSubject.TabIndex = 0;
            this.btnSubject.Text = "           Môn học";
            this.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.UseVisualStyleBackColor = false;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
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
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNotification.Image")));
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(0, 80);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnNotification.Size = new System.Drawing.Size(210, 40);
            this.btnNotification.TabIndex = 14;
            this.btnNotification.Text = "Gửi thông báo";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.Location = new System.Drawing.Point(0, 120);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnUser.Size = new System.Drawing.Size(210, 40);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "Người dùng hệ thống";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
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
            // frmAdminDashBoard
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
            this.Name = "frmAdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý trang dạy học số";
            this.Load += new System.EventHandler(this.frmAdminDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuTraining.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
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
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnSubjectClass;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblDisplayRole;
        private System.Windows.Forms.Button btnNotification;
    }
}