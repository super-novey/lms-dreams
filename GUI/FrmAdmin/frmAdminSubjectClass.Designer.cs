namespace LMSDreams.GUI
{
    partial class frmAdminSubjectClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminSubjectClass));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTeacherId = new System.Windows.Forms.Label();
            this.btnClassId = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.pnlClass = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblIdClass = new System.Windows.Forms.Label();
            this.lblSemeter = new System.Windows.Forms.Label();
            this.lblTraningForm = new System.Windows.Forms.Label();
            this.lblIdSubject = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSemeter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách lớp môn học";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTeacherId);
            this.panel1.Controls.Add(this.btnClassId);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(7, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 53);
            this.panel1.TabIndex = 7;
            // 
            // btnTeacherId
            // 
            this.btnTeacherId.BackColor = System.Drawing.Color.DimGray;
            this.btnTeacherId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherId.ForeColor = System.Drawing.Color.White;
            this.btnTeacherId.Location = new System.Drawing.Point(478, 12);
            this.btnTeacherId.Name = "btnTeacherId";
            this.btnTeacherId.Size = new System.Drawing.Size(90, 30);
            this.btnTeacherId.TabIndex = 4;
            this.btnTeacherId.Text = "Giáo viên";
            this.btnTeacherId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeacherId.Click += new System.EventHandler(this.btnTeacherId_Click);
            // 
            // btnClassId
            // 
            this.btnClassId.BackColor = System.Drawing.Color.DarkBlue;
            this.btnClassId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassId.ForeColor = System.Drawing.Color.White;
            this.btnClassId.Location = new System.Drawing.Point(382, 12);
            this.btnClassId.Name = "btnClassId";
            this.btnClassId.Size = new System.Drawing.Size(90, 30);
            this.btnClassId.TabIndex = 3;
            this.btnClassId.Text = "Mã lớp";
            this.btnClassId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClassId.Click += new System.EventHandler(this.btnClassId_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.LightGray;
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearch.Location = new System.Drawing.Point(6, 17);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(226, 20);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.Tag = "";
            this.txbSearch.Text = "Nhập để tìm kiếm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(266, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(591, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlClass
            // 
            this.pnlClass.AutoScroll = true;
            this.pnlClass.Location = new System.Drawing.Point(6, 118);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(633, 434);
            this.pnlClass.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(227, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(124, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblTeacherName);
            this.panel2.Controls.Add(this.lblIdClass);
            this.panel2.Controls.Add(this.lblSemeter);
            this.panel2.Controls.Add(this.lblTraningForm);
            this.panel2.Controls.Add(this.lblIdSubject);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblSubjectName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(645, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 369);
            this.panel2.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(120, 286);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 21);
            this.lblQuantity.TabIndex = 31;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.BackColor = System.Drawing.Color.White;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.DimGray;
            this.lblTeacherName.Location = new System.Drawing.Point(120, 253);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 21);
            this.lblTeacherName.TabIndex = 30;
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIdClass
            // 
            this.lblIdClass.AutoSize = true;
            this.lblIdClass.BackColor = System.Drawing.Color.White;
            this.lblIdClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClass.ForeColor = System.Drawing.Color.DimGray;
            this.lblIdClass.Location = new System.Drawing.Point(120, 218);
            this.lblIdClass.Name = "lblIdClass";
            this.lblIdClass.Size = new System.Drawing.Size(0, 21);
            this.lblIdClass.TabIndex = 29;
            this.lblIdClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSemeter
            // 
            this.lblSemeter.AutoSize = true;
            this.lblSemeter.BackColor = System.Drawing.Color.White;
            this.lblSemeter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemeter.ForeColor = System.Drawing.Color.DimGray;
            this.lblSemeter.Location = new System.Drawing.Point(120, 181);
            this.lblSemeter.Name = "lblSemeter";
            this.lblSemeter.Size = new System.Drawing.Size(0, 21);
            this.lblSemeter.TabIndex = 28;
            this.lblSemeter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTraningForm
            // 
            this.lblTraningForm.AutoSize = true;
            this.lblTraningForm.BackColor = System.Drawing.Color.White;
            this.lblTraningForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraningForm.ForeColor = System.Drawing.Color.DimGray;
            this.lblTraningForm.Location = new System.Drawing.Point(120, 144);
            this.lblTraningForm.Name = "lblTraningForm";
            this.lblTraningForm.Size = new System.Drawing.Size(0, 21);
            this.lblTraningForm.TabIndex = 27;
            this.lblTraningForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIdSubject
            // 
            this.lblIdSubject.AutoSize = true;
            this.lblIdSubject.BackColor = System.Drawing.Color.White;
            this.lblIdSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSubject.ForeColor = System.Drawing.Color.DimGray;
            this.lblIdSubject.Location = new System.Drawing.Point(120, 106);
            this.lblIdSubject.Name = "lblIdSubject";
            this.lblIdSubject.Size = new System.Drawing.Size(0, 21);
            this.lblIdSubject.TabIndex = 26;
            this.lblIdSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sĩ số:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giáo viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mã lớp học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Học kỳ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hệ đào tạo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mã môn học:";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.White;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubjectName.Location = new System.Drawing.Point(120, 71);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(0, 21);
            this.lblSubjectName.TabIndex = 19;
            this.lblSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Môn học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtNo);
            this.groupBox1.Controls.Add(this.rbtYes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSemeter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(650, 392);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(309, 155);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mở đăng kí môn học";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.ForeColor = System.Drawing.Color.Black;
            this.rbtNo.Location = new System.Drawing.Point(202, 74);
            this.rbtNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(97, 25);
            this.rbtNo.TabIndex = 6;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "Chưa mở";
            this.rbtNo.UseVisualStyleBackColor = true;
            this.rbtNo.CheckedChanged += new System.EventHandler(this.Register);
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.ForeColor = System.Drawing.Color.Black;
            this.rbtYes.Location = new System.Drawing.Point(124, 74);
            this.rbtYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(78, 25);
            this.rbtYes.TabIndex = 5;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Đã mở";
            this.rbtYes.UseVisualStyleBackColor = true;
            this.rbtYes.CheckedChanged += new System.EventHandler(this.Register);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // cbSemeter
            // 
            this.cbSemeter.ForeColor = System.Drawing.Color.DimGray;
            this.cbSemeter.FormattingEnabled = true;
            this.cbSemeter.Location = new System.Drawing.Point(124, 28);
            this.cbSemeter.Margin = new System.Windows.Forms.Padding(2);
            this.cbSemeter.Name = "cbSemeter";
            this.cbSemeter.Size = new System.Drawing.Size(167, 29);
            this.cbSemeter.TabIndex = 3;
            this.cbSemeter.SelectedIndexChanged += new System.EventHandler(this.StatusRegister);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kì";
            // 
            // frmAdminSubjectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 564);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSubjectClass";
            this.Text = "frmTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminSubjectClass_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminSubjectClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnTeacherId;
        private System.Windows.Forms.Label btnClassId;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblIdClass;
        private System.Windows.Forms.Label lblSemeter;
        private System.Windows.Forms.Label lblTraningForm;
        private System.Windows.Forms.Label lblIdSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSemeter;
        private System.Windows.Forms.Label label4;
    }
}