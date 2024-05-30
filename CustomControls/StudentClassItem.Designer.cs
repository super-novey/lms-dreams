namespace LMSDreams.CustomControls
{
    partial class StudentClassItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentClassItem));
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btnShowDetail = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblIdClass = new System.Windows.Forms.Label();
            this.pbClass = new System.Windows.Forms.PictureBox();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainer.Controls.Add(this.btnShowDetail);
            this.pnContainer.Controls.Add(this.lblSubjectName);
            this.pnContainer.Controls.Add(this.label30);
            this.pnContainer.Controls.Add(this.lblTeacherName);
            this.pnContainer.Controls.Add(this.label32);
            this.pnContainer.Controls.Add(this.lblIdClass);
            this.pnContainer.Controls.Add(this.pbClass);
            this.pnContainer.Location = new System.Drawing.Point(3, 3);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(182, 203);
            this.pnContainer.TabIndex = 15;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetail.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnShowDetail.Location = new System.Drawing.Point(15, 166);
            this.btnShowDetail.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(140, 27);
            this.btnShowDetail.TabIndex = 6;
            this.btnShowDetail.Text = "Chi tiết lớp học";
            this.btnShowDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.ForeColor = System.Drawing.Color.Black;
            this.lblSubjectName.Location = new System.Drawing.Point(44, 149);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(15, 17);
            this.lblSubjectName.TabIndex = 5;
            this.lblSubjectName.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.DimGray;
            this.label30.Location = new System.Drawing.Point(3, 149);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "Môn:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherName.Location = new System.Drawing.Point(44, 123);
            this.lblTeacherName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(85, 17);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "Tên giáo viên";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.DimGray;
            this.label32.Location = new System.Drawing.Point(3, 123);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(28, 17);
            this.label32.TabIndex = 2;
            this.label32.Text = "GV:";
            // 
            // lblIdClass
            // 
            this.lblIdClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClass.Location = new System.Drawing.Point(14, 100);
            this.lblIdClass.Name = "lblIdClass";
            this.lblIdClass.Size = new System.Drawing.Size(149, 19);
            this.lblIdClass.TabIndex = 1;
            this.lblIdClass.Text = "IPPA233277_22_2_03 ";
            this.lblIdClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbClass
            // 
            this.pbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbClass.Image = ((System.Drawing.Image)(resources.GetObject("pbClass.Image")));
            this.pbClass.Location = new System.Drawing.Point(0, 0);
            this.pbClass.Name = "pbClass";
            this.pbClass.Size = new System.Drawing.Size(180, 97);
            this.pbClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClass.TabIndex = 0;
            this.pbClass.TabStop = false;
            // 
            // StudentClassItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentClassItem";
            this.Size = new System.Drawing.Size(190, 211);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentClassItem_Paint);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Label btnShowDetail;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblIdClass;
        private System.Windows.Forms.PictureBox pbClass;
    }
}
