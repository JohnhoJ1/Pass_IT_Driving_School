namespace Pass_IT_Driving_School
{
    partial class Admin_Form
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
            cmbGender = new ComboBox();
            tabHome = new TabControl();
            tabAdmin = new TabPage();
            btnEditInstructor = new Button();
            btnAddInstructor = new Button();
            btnEditStudent = new Button();
            btnRegisterStudent = new Button();
            btnAddAdmin = new Button();
            tabStudentRegistration = new TabPage();
            btnProgressTrack = new Button();
            button1 = new Button();
            label12 = new Label();
            label10 = new Label();
            lblStudentMessage = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            cmbCourse = new ComboBox();
            lblCourseChoosen = new Label();
            cmbInstructor = new ComboBox();
            txtAddress = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblEnrollDate = new Label();
            lblInstructor = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblLastName = new Label();
            lblMiddleName = new Label();
            lblFirstName = new Label();
            tabStudentList = new TabPage();
            gvStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnStudentSearch = new Button();
            txtStudentSearch = new TextBox();
            tabInstructorRegistration = new TabPage();
            label1 = new Label();
            lblMessage = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInstructorUpdate = new Button();
            btnInstructorClear = new Button();
            btnInstructorDelete = new Button();
            btnInstructorSave = new Button();
            cmbInstructorJobType = new ComboBox();
            txtInstructorMiddleName = new TextBox();
            txtInstructorLastName = new TextBox();
            txtInstructorAddress = new TextBox();
            txtInstructorPhoneNumber = new TextBox();
            txtInstructorFirstName = new TextBox();
            lblPhoneNumber = new Label();
            lblInstructorAddredd = new Label();
            lblInstructorJobType = new Label();
            lblInstructorLastName = new Label();
            lblInstructorMiddleName = new Label();
            lblInstructorFirstName = new Label();
            tabInstructorList = new TabPage();
            gvInstructor = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            btnSearchInstructor = new Button();
            txtSearchInstructor = new TextBox();
            lblLogout = new LinkLabel();
            panel1 = new Panel();
            label9 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            tabHome.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabStudentRegistration.SuspendLayout();
            tabStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            tabInstructorRegistration.SuspendLayout();
            tabInstructorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.ImeMode = ImeMode.NoControl;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(792, 153);
            cmbGender.Margin = new Padding(4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(350, 40);
            cmbGender.TabIndex = 11;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabAdmin);
            tabHome.Controls.Add(tabStudentRegistration);
            tabHome.Controls.Add(tabStudentList);
            tabHome.Controls.Add(tabInstructorRegistration);
            tabHome.Controls.Add(tabInstructorList);
            tabHome.Location = new Point(62, 38);
            tabHome.Margin = new Padding(4);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(1255, 607);
            tabHome.TabIndex = 2;
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = Color.LightGray;
            tabAdmin.Controls.Add(panel2);
            tabAdmin.Controls.Add(panel1);
            tabAdmin.Controls.Add(btnAddAdmin);
            tabAdmin.Location = new Point(4, 41);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1247, 562);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Home";
            tabAdmin.Click += tabAdmin_Click;
            // 
            // btnEditInstructor
            // 
            btnEditInstructor.BackColor = Color.Azure;
            btnEditInstructor.ForeColor = SystemColors.ActiveCaptionText;
            btnEditInstructor.Location = new Point(177, 78);
            btnEditInstructor.Name = "btnEditInstructor";
            btnEditInstructor.Size = new Size(145, 51);
            btnEditInstructor.TabIndex = 7;
            btnEditInstructor.Text = "View Instructor";
            btnEditInstructor.UseVisualStyleBackColor = false;
            btnEditInstructor.Click += btnEditInstructor_Click;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.BackColor = Color.Azure;
            btnAddInstructor.ForeColor = SystemColors.ActiveCaptionText;
            btnAddInstructor.Location = new Point(30, 78);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Size = new Size(141, 51);
            btnAddInstructor.TabIndex = 6;
            btnAddInstructor.Text = "Add Instructor";
            btnAddInstructor.UseVisualStyleBackColor = false;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = Color.Azure;
            btnEditStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnEditStudent.Location = new Point(172, 69);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(147, 51);
            btnEditStudent.TabIndex = 5;
            btnEditStudent.Text = "View Student";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.BackColor = Color.Azure;
            btnRegisterStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnRegisterStudent.Location = new Point(22, 69);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(144, 51);
            btnRegisterStudent.TabIndex = 4;
            btnRegisterStudent.Text = "Add Student";
            btnRegisterStudent.UseVisualStyleBackColor = false;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.Azure;
            btnAddAdmin.ForeColor = SystemColors.ActiveCaptionText;
            btnAddAdmin.Location = new Point(307, 298);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(169, 57);
            btnAddAdmin.TabIndex = 3;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // tabStudentRegistration
            // 
            tabStudentRegistration.BackColor = Color.RosyBrown;
            tabStudentRegistration.Controls.Add(btnProgressTrack);
            tabStudentRegistration.Controls.Add(button1);
            tabStudentRegistration.Controls.Add(label12);
            tabStudentRegistration.Controls.Add(label10);
            tabStudentRegistration.Controls.Add(lblStudentMessage);
            tabStudentRegistration.Controls.Add(label11);
            tabStudentRegistration.Controls.Add(label8);
            tabStudentRegistration.Controls.Add(label7);
            tabStudentRegistration.Controls.Add(label6);
            tabStudentRegistration.Controls.Add(btnUpdate);
            tabStudentRegistration.Controls.Add(btnClear);
            tabStudentRegistration.Controls.Add(btnDelete);
            tabStudentRegistration.Controls.Add(btnSave);
            tabStudentRegistration.Controls.Add(dateTimePicker1);
            tabStudentRegistration.Controls.Add(cmbCourse);
            tabStudentRegistration.Controls.Add(lblCourseChoosen);
            tabStudentRegistration.Controls.Add(cmbInstructor);
            tabStudentRegistration.Controls.Add(cmbGender);
            tabStudentRegistration.Controls.Add(txtAddress);
            tabStudentRegistration.Controls.Add(txtMiddleName);
            tabStudentRegistration.Controls.Add(txtLastName);
            tabStudentRegistration.Controls.Add(txtFirstName);
            tabStudentRegistration.Controls.Add(lblEnrollDate);
            tabStudentRegistration.Controls.Add(lblInstructor);
            tabStudentRegistration.Controls.Add(lblAddress);
            tabStudentRegistration.Controls.Add(lblGender);
            tabStudentRegistration.Controls.Add(lblLastName);
            tabStudentRegistration.Controls.Add(lblMiddleName);
            tabStudentRegistration.Controls.Add(lblFirstName);
            tabStudentRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabStudentRegistration.Location = new Point(4, 41);
            tabStudentRegistration.Margin = new Padding(4);
            tabStudentRegistration.Name = "tabStudentRegistration";
            tabStudentRegistration.Padding = new Padding(4);
            tabStudentRegistration.Size = new Size(1247, 562);
            tabStudentRegistration.TabIndex = 0;
            tabStudentRegistration.Text = "Student Registration";
            tabStudentRegistration.Click += tabStudentRegistration_Click;
            // 
            // btnProgressTrack
            // 
            btnProgressTrack.BackColor = Color.Green;
            btnProgressTrack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProgressTrack.ForeColor = SystemColors.ButtonFace;
            btnProgressTrack.Location = new Point(648, 476);
            btnProgressTrack.Margin = new Padding(4);
            btnProgressTrack.Name = "btnProgressTrack";
            btnProgressTrack.Size = new Size(131, 62);
            btnProgressTrack.TabIndex = 36;
            btnProgressTrack.Text = "View Progress";
            btnProgressTrack.UseVisualStyleBackColor = false;
            btnProgressTrack.Click += btnProgressTrack_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(496, 476);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(131, 62);
            button1.TabIndex = 35;
            button1.Text = "Book Lesson";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1151, 323);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 32);
            label12.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1151, 246);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 32);
            label10.TabIndex = 33;
            // 
            // lblStudentMessage
            // 
            lblStudentMessage.AutoSize = true;
            lblStudentMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentMessage.Location = new Point(174, 397);
            lblStudentMessage.Margin = new Padding(4, 0, 4, 0);
            lblStudentMessage.Name = "lblStudentMessage";
            lblStudentMessage.Size = new Size(0, 32);
            lblStudentMessage.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(532, 246);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 32);
            label11.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(1151, 161);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 32);
            label8.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(532, 161);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(532, 73);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Tan;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(517, 397);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 62);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Green;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(809, 397);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 62);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(670, 397);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 62);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(353, 397);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 62);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(174, 321);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 39);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2023, 11, 16, 23, 6, 53, 0);
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Introductary", "Standard", "Pass Plus", "Driving Test" });
            cmbCourse.Location = new Point(792, 312);
            cmbCourse.Margin = new Padding(4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(350, 40);
            cmbCourse.TabIndex = 14;
            // 
            // lblCourseChoosen
            // 
            lblCourseChoosen.AutoSize = true;
            lblCourseChoosen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourseChoosen.Location = new Point(618, 319);
            lblCourseChoosen.Margin = new Padding(4, 0, 4, 0);
            lblCourseChoosen.Name = "lblCourseChoosen";
            lblCourseChoosen.Size = new Size(89, 32);
            lblCourseChoosen.TabIndex = 13;
            lblCourseChoosen.Text = "Course";
            // 
            // cmbInstructor
            // 
            cmbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Items.AddRange(new object[] { "David", "Shree", "Naren", });
            cmbInstructor.Location = new Point(792, 232);
            cmbInstructor.Margin = new Padding(4);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(350, 40);
            cmbInstructor.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(174, 235);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 39);
            txtAddress.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddleName.Location = new Point(792, 73);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(350, 39);
            txtMiddleName.TabIndex = 9;
            txtMiddleName.TextChanged += txtMiddleName_TextChanged;
            txtMiddleName.KeyPress += txtMiddleName_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(174, 150);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 39);
            txtLastName.TabIndex = 8;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(174, 76);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 39);
            txtFirstName.TabIndex = 7;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnrollDate.Location = new Point(0, 332);
            lblEnrollDate.Margin = new Padding(4, 0, 4, 0);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(161, 32);
            lblEnrollDate.TabIndex = 6;
            lblEnrollDate.Text = "Enrolled Date";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructor.Location = new Point(618, 241);
            lblInstructor.Margin = new Padding(4, 0, 4, 0);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(120, 32);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(8, 246);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 32);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(618, 162);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(94, 32);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(4, 161);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(130, 32);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(618, 84);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(161, 32);
            lblMiddleName.TabIndex = 1;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(9, 76);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(132, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // tabStudentList
            // 
            tabStudentList.BackColor = Color.LightGray;
            tabStudentList.Controls.Add(gvStudent);
            tabStudentList.Controls.Add(btnStudentSearch);
            tabStudentList.Controls.Add(txtStudentSearch);
            tabStudentList.Location = new Point(4, 41);
            tabStudentList.Margin = new Padding(4);
            tabStudentList.Name = "tabStudentList";
            tabStudentList.Padding = new Padding(4);
            tabStudentList.Size = new Size(1247, 562);
            tabStudentList.TabIndex = 1;
            tabStudentList.Text = "Student List";
            tabStudentList.Click += tabStudentList_Click;
            // 
            // gvStudent
            // 
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5, Column7, Column8 });
            gvStudent.Location = new Point(7, 56);
            gvStudent.Name = "gvStudent";
            gvStudent.RowHeadersWidth = 62;
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(1228, 480);
            gvStudent.TabIndex = 2;
            gvStudent.CellContentClick += gvStudent_CellContentClick;
            gvStudent.MouseDoubleClick += gvStudent_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Middle Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column6
            // 
            Column6.FillWeight = 200F;
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column5
            // 
            Column5.FillWeight = 200F;
            Column5.HeaderText = "Instructor";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column7
            // 
            Column7.FillWeight = 150F;
            Column7.HeaderText = "Enrolled Date";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Course";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Location = new Point(1135, 20);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(75, 29);
            btnStudentSearch.TabIndex = 1;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Location = new Point(919, 21);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(220, 39);
            txtStudentSearch.TabIndex = 0;
            // 
            // tabInstructorRegistration
            // 
            tabInstructorRegistration.BackColor = Color.RosyBrown;
            tabInstructorRegistration.Controls.Add(label1);
            tabInstructorRegistration.Controls.Add(lblMessage);
            tabInstructorRegistration.Controls.Add(label5);
            tabInstructorRegistration.Controls.Add(label4);
            tabInstructorRegistration.Controls.Add(label3);
            tabInstructorRegistration.Controls.Add(label2);
            tabInstructorRegistration.Controls.Add(btnInstructorUpdate);
            tabInstructorRegistration.Controls.Add(btnInstructorClear);
            tabInstructorRegistration.Controls.Add(btnInstructorDelete);
            tabInstructorRegistration.Controls.Add(btnInstructorSave);
            tabInstructorRegistration.Controls.Add(cmbInstructorJobType);
            tabInstructorRegistration.Controls.Add(txtInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(txtInstructorLastName);
            tabInstructorRegistration.Controls.Add(txtInstructorAddress);
            tabInstructorRegistration.Controls.Add(txtInstructorPhoneNumber);
            tabInstructorRegistration.Controls.Add(txtInstructorFirstName);
            tabInstructorRegistration.Controls.Add(lblPhoneNumber);
            tabInstructorRegistration.Controls.Add(lblInstructorAddredd);
            tabInstructorRegistration.Controls.Add(lblInstructorJobType);
            tabInstructorRegistration.Controls.Add(lblInstructorLastName);
            tabInstructorRegistration.Controls.Add(lblInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(lblInstructorFirstName);
            tabInstructorRegistration.Location = new Point(4, 41);
            tabInstructorRegistration.Margin = new Padding(4);
            tabInstructorRegistration.Name = "tabInstructorRegistration";
            tabInstructorRegistration.Padding = new Padding(4);
            tabInstructorRegistration.Size = new Size(1247, 562);
            tabInstructorRegistration.TabIndex = 2;
            tabInstructorRegistration.Text = "Instructor Registration";
            tabInstructorRegistration.Click += tabInstructorRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(509, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 29;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(132, 295);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 32);
            lblMessage.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1093, 150);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1093, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(509, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(509, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 19;
            // 
            // btnInstructorUpdate
            // 
            btnInstructorUpdate.BackColor = Color.Tan;
            btnInstructorUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnInstructorUpdate.Location = new Point(493, 345);
            btnInstructorUpdate.Margin = new Padding(4);
            btnInstructorUpdate.Name = "btnInstructorUpdate";
            btnInstructorUpdate.Size = new Size(111, 64);
            btnInstructorUpdate.TabIndex = 16;
            btnInstructorUpdate.Text = "Update";
            btnInstructorUpdate.UseVisualStyleBackColor = false;
            btnInstructorUpdate.Click += btnInstructorUpdate_Click;
            // 
            // btnInstructorClear
            // 
            btnInstructorClear.BackColor = Color.FromArgb(192, 64, 0);
            btnInstructorClear.ForeColor = SystemColors.ButtonFace;
            btnInstructorClear.Location = new Point(761, 345);
            btnInstructorClear.Margin = new Padding(4);
            btnInstructorClear.Name = "btnInstructorClear";
            btnInstructorClear.Size = new Size(111, 63);
            btnInstructorClear.TabIndex = 15;
            btnInstructorClear.Text = "Clear";
            btnInstructorClear.UseVisualStyleBackColor = false;
            btnInstructorClear.Click += btnInstructorClear_Click;
            // 
            // btnInstructorDelete
            // 
            btnInstructorDelete.BackColor = Color.Brown;
            btnInstructorDelete.ForeColor = SystemColors.ButtonFace;
            btnInstructorDelete.Location = new Point(630, 345);
            btnInstructorDelete.Margin = new Padding(4);
            btnInstructorDelete.Name = "btnInstructorDelete";
            btnInstructorDelete.Size = new Size(111, 64);
            btnInstructorDelete.TabIndex = 14;
            btnInstructorDelete.Text = "Delete";
            btnInstructorDelete.UseVisualStyleBackColor = false;
            btnInstructorDelete.Click += btnInstructorDelete_Click;
            // 
            // btnInstructorSave
            // 
            btnInstructorSave.BackColor = Color.Honeydew;
            btnInstructorSave.ForeColor = SystemColors.ActiveCaptionText;
            btnInstructorSave.Location = new Point(345, 345);
            btnInstructorSave.Margin = new Padding(4);
            btnInstructorSave.Name = "btnInstructorSave";
            btnInstructorSave.Size = new Size(111, 64);
            btnInstructorSave.TabIndex = 13;
            btnInstructorSave.Text = "Save";
            btnInstructorSave.UseVisualStyleBackColor = false;
            btnInstructorSave.Click += btnInstructorSave_Click;
            // 
            // cmbInstructorJobType
            // 
            cmbInstructorJobType.FormattingEnabled = true;
            cmbInstructorJobType.Items.AddRange(new object[] { "Full Time", "Part Time" });
            cmbInstructorJobType.Location = new Point(749, 144);
            cmbInstructorJobType.Margin = new Padding(4);
            cmbInstructorJobType.Name = "cmbInstructorJobType";
            cmbInstructorJobType.Size = new Size(369, 40);
            cmbInstructorJobType.TabIndex = 11;
            // 
            // txtInstructorMiddleName
            // 
            txtInstructorMiddleName.Location = new Point(749, 55);
            txtInstructorMiddleName.Margin = new Padding(4);
            txtInstructorMiddleName.Name = "txtInstructorMiddleName";
            txtInstructorMiddleName.Size = new Size(369, 39);
            txtInstructorMiddleName.TabIndex = 10;
            txtInstructorMiddleName.KeyPress += txtInstructorMiddleName_KeyPress;
            // 
            // txtInstructorLastName
            // 
            txtInstructorLastName.Location = new Point(173, 141);
            txtInstructorLastName.Margin = new Padding(4);
            txtInstructorLastName.Name = "txtInstructorLastName";
            txtInstructorLastName.Size = new Size(369, 39);
            txtInstructorLastName.TabIndex = 9;
            txtInstructorLastName.TextChanged += txtInstructorLastName_TextChanged;
            txtInstructorLastName.KeyPress += txtInstructorLastName_KeyPress;
            // 
            // txtInstructorAddress
            // 
            txtInstructorAddress.Location = new Point(173, 233);
            txtInstructorAddress.Margin = new Padding(4);
            txtInstructorAddress.Name = "txtInstructorAddress";
            txtInstructorAddress.Size = new Size(369, 39);
            txtInstructorAddress.TabIndex = 8;
            // 
            // txtInstructorPhoneNumber
            // 
            txtInstructorPhoneNumber.Location = new Point(749, 226);
            txtInstructorPhoneNumber.Margin = new Padding(4);
            txtInstructorPhoneNumber.Name = "txtInstructorPhoneNumber";
            txtInstructorPhoneNumber.Size = new Size(369, 39);
            txtInstructorPhoneNumber.TabIndex = 7;
            txtInstructorPhoneNumber.KeyPress += txtInstructorPhoneNumber_KeyPress;
            // 
            // txtInstructorFirstName
            // 
            txtInstructorFirstName.Location = new Point(173, 48);
            txtInstructorFirstName.Margin = new Padding(4);
            txtInstructorFirstName.Name = "txtInstructorFirstName";
            txtInstructorFirstName.Size = new Size(369, 39);
            txtInstructorFirstName.TabIndex = 6;
            txtInstructorFirstName.KeyPress += txtInstructorFirstName_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(562, 233);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(179, 32);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblInstructorAddredd
            // 
            lblInstructorAddredd.AutoSize = true;
            lblInstructorAddredd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorAddredd.Location = new Point(24, 236);
            lblInstructorAddredd.Margin = new Padding(4, 0, 4, 0);
            lblInstructorAddredd.Name = "lblInstructorAddredd";
            lblInstructorAddredd.Size = new Size(100, 32);
            lblInstructorAddredd.TabIndex = 4;
            lblInstructorAddredd.Text = "Address";
            // 
            // lblInstructorJobType
            // 
            lblInstructorJobType.AutoSize = true;
            lblInstructorJobType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorJobType.Location = new Point(562, 144);
            lblInstructorJobType.Margin = new Padding(4, 0, 4, 0);
            lblInstructorJobType.Name = "lblInstructorJobType";
            lblInstructorJobType.Size = new Size(110, 32);
            lblInstructorJobType.TabIndex = 3;
            lblInstructorJobType.Text = "Job Type";
            // 
            // lblInstructorLastName
            // 
            lblInstructorLastName.AutoSize = true;
            lblInstructorLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorLastName.Location = new Point(24, 144);
            lblInstructorLastName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorLastName.Name = "lblInstructorLastName";
            lblInstructorLastName.Size = new Size(130, 32);
            lblInstructorLastName.TabIndex = 2;
            lblInstructorLastName.Text = "Last Name";
            // 
            // lblInstructorMiddleName
            // 
            lblInstructorMiddleName.AutoSize = true;
            lblInstructorMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorMiddleName.Location = new Point(562, 55);
            lblInstructorMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorMiddleName.Name = "lblInstructorMiddleName";
            lblInstructorMiddleName.Size = new Size(161, 32);
            lblInstructorMiddleName.TabIndex = 1;
            lblInstructorMiddleName.Text = "Middle Name";
            // 
            // lblInstructorFirstName
            // 
            lblInstructorFirstName.AutoSize = true;
            lblInstructorFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorFirstName.Location = new Point(24, 52);
            lblInstructorFirstName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorFirstName.Name = "lblInstructorFirstName";
            lblInstructorFirstName.Size = new Size(132, 32);
            lblInstructorFirstName.TabIndex = 0;
            lblInstructorFirstName.Text = "First Name";
            // 
            // tabInstructorList
            // 
            tabInstructorList.BackColor = Color.LightGray;
            tabInstructorList.Controls.Add(gvInstructor);
            tabInstructorList.Controls.Add(btnSearchInstructor);
            tabInstructorList.Controls.Add(txtSearchInstructor);
            tabInstructorList.Location = new Point(4, 34);
            tabInstructorList.Margin = new Padding(4);
            tabInstructorList.Name = "tabInstructorList";
            tabInstructorList.Padding = new Padding(4);
            tabInstructorList.Size = new Size(1242, 532);
            tabInstructorList.TabIndex = 3;
            tabInstructorList.Text = "Instructor List";
            // 
            // gvInstructor
            // 
            gvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInstructor.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12, Column13, Column14 });
            gvInstructor.Location = new Point(7, 69);
            gvInstructor.Name = "gvInstructor";
            gvInstructor.RowHeadersWidth = 62;
            gvInstructor.RowTemplate.Height = 25;
            gvInstructor.Size = new Size(1228, 432);
            gvInstructor.TabIndex = 2;
            gvInstructor.MouseDoubleClick += gvInstructor_MouseDoubleClick;
            // 
            // Column9
            // 
            Column9.FillWeight = 150F;
            Column9.HeaderText = "First Name";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.FillWeight = 150F;
            Column10.HeaderText = "Middle Name";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.FillWeight = 150F;
            Column11.HeaderText = "Last Name";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.FillWeight = 150F;
            Column12.HeaderText = "Job Type";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.FillWeight = 400F;
            Column13.HeaderText = "Address";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.Width = 400;
            // 
            // Column14
            // 
            Column14.FillWeight = 200F;
            Column14.HeaderText = "Phone Number";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.Width = 200;
            // 
            // btnSearchInstructor
            // 
            btnSearchInstructor.Location = new Point(1158, 33);
            btnSearchInstructor.Name = "btnSearchInstructor";
            btnSearchInstructor.Size = new Size(75, 29);
            btnSearchInstructor.TabIndex = 1;
            btnSearchInstructor.Text = "Search";
            btnSearchInstructor.UseVisualStyleBackColor = true;
            // 
            // txtSearchInstructor
            // 
            txtSearchInstructor.Location = new Point(952, 34);
            txtSearchInstructor.Name = "txtSearchInstructor";
            txtSearchInstructor.Size = new Size(210, 39);
            txtSearchInstructor.TabIndex = 0;
            // 
            // lblLogout
            // 
            lblLogout.ActiveLinkColor = Color.White;
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogout.LinkColor = Color.OrangeRed;
            lblLogout.Location = new Point(1211, 2);
            lblLogout.Margin = new Padding(4, 0, 4, 0);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(102, 32);
            lblLogout.TabIndex = 3;
            lblLogout.TabStop = true;
            lblLogout.Text = "Log out";
            lblLogout.LinkClicked += lblLogout_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnRegisterStudent);
            panel1.Controls.Add(btnEditStudent);
            panel1.Location = new Point(21, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 242);
            panel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(111, 13);
            label9.Name = "label9";
            label9.Size = new Size(99, 32);
            label9.TabIndex = 0;
            label9.Text = "Student";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(111, 13);
            label13.Name = "label13";
            label13.Size = new Size(120, 32);
            label13.TabIndex = 9;
            label13.Text = "Instructor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnAddInstructor);
            panel2.Controls.Add(btnEditInstructor);
            panel2.Location = new Point(435, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 246);
            panel2.TabIndex = 10;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1376, 644);
            Controls.Add(lblLogout);
            Controls.Add(tabHome);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Admin_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Form_Load;
            tabHome.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabStudentRegistration.ResumeLayout(false);
            tabStudentRegistration.PerformLayout();
            tabStudentList.ResumeLayout(false);
            tabStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            tabInstructorRegistration.ResumeLayout(false);
            tabInstructorRegistration.PerformLayout();
            tabInstructorList.ResumeLayout(false);
            tabInstructorList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabHome;
        private TabPage tabStudentRegistration;
        private TabPage tabStudentList;
        private TabPage tabInstructorRegistration;
        private TabPage tabInstructorList;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblEnrollDate;
        private Label lblInstructor;
        private Label lblAddress;
        private Label lblGender;
        private Label lblLastName;
        private Label lblMiddleName;
        private Label lblFirstName;
        private TextBox txtAddress;
        private Label lblCourseChoosen;
        private DateTimePicker dateTimePicker1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtInstructorFirstName;
        private Label lblPhoneNumber;
        private Label lblInstructorAddredd;
        private Label lblInstructorJobType;
        private Label lblInstructorLastName;
        private Label lblInstructorMiddleName;
        private Label lblInstructorFirstName;
        private TextBox txtInstructorMiddleName;
        private TextBox txtInstructorLastName;
        private TextBox txtInstructorAddress;
        private TextBox txtInstructorPhoneNumber;
        private ComboBox cmbInstructorJobType;
        private Button btnInstructorClear;
        private Button btnInstructorDelete;
        private Button btnInstructorSave;
        private LinkLabel lblLogout;
        private Button btnUpdate;
        private Button btnInstructorUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMessage;
        private Label lblStudentMessage;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label8;
        private ComboBox cmbCourse;
        private ComboBox cmbInstructor;
        private ComboBox cmbGender;
        private TextBox txtMiddleName;
        private Label label12;
        private Label label10;
        private Label label1;
        private Button btnStudentSearch;
        private TextBox txtStudentSearch;
        private DataGridView gvStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnSearchInstructor;
        private TextBox txtSearchInstructor;
        private DataGridView gvInstructor;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button btnProgressTrack;
        private Button button1;
        private TabPage tabAdmin;
        private Button btnEditInstructor;
        private Button btnAddInstructor;
        private Button btnEditStudent;
        private Button btnRegisterStudent;
        private Button btnAddAdmin;
        private Panel panel1;
        private Label label9;
        private Panel panel2;
        private Label label13;
    }
}