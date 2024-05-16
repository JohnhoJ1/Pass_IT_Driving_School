namespace Pass_IT_Driving_School
{
    partial class LogIn_Form
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblLogIn = new Label();
            btnLogIn = new Button();
            llblMessage = new Label();
            llblShowPassword = new Label();
            lchkBox = new CheckBox();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(333, 351);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(135, 32);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(483, 348);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(347, 39);
            txtUserName.TabIndex = 1;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(483, 418);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(347, 39);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(333, 421);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 32);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogIn.Location = new Point(469, 241);
            lblLogIn.Margin = new Padding(4, 0, 4, 0);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(514, 62);
            lblLogIn.TabIndex = 4;
            lblLogIn.Text = "Pass IT Driving School";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkOliveGreen;
            btnLogIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.Control;
            btnLogIn.Location = new Point(899, 362);
            btnLogIn.Margin = new Padding(4, 5, 4, 5);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(272, 73);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // llblMessage
            // 
            llblMessage.AutoSize = true;
            llblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            llblMessage.Location = new Point(483, 552);
            llblMessage.Margin = new Padding(4, 0, 4, 0);
            llblMessage.Name = "llblMessage";
            llblMessage.Size = new Size(0, 32);
            llblMessage.TabIndex = 9;
            // 
            // llblShowPassword
            // 
            llblShowPassword.AutoSize = true;
            llblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llblShowPassword.Location = new Point(513, 474);
            llblShowPassword.Margin = new Padding(4, 0, 4, 0);
            llblShowPassword.Name = "llblShowPassword";
            llblShowPassword.Size = new Size(192, 32);
            llblShowPassword.TabIndex = 10;
            llblShowPassword.Text = "Show Password?";
            // 
            // lchkBox
            // 
            lchkBox.AutoSize = true;
            lchkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lchkBox.Location = new Point(483, 474);
            lchkBox.Margin = new Padding(4, 5, 4, 5);
            lchkBox.Name = "lchkBox";
            lchkBox.Size = new Size(22, 21);
            lchkBox.TabIndex = 11;
            lchkBox.UseVisualStyleBackColor = true;
            lchkBox.CheckedChanged += lchkBox_CheckedChanged;
            // 
            // LogIn_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1256, 767);
            Controls.Add(lchkBox);
            Controls.Add(llblShowPassword);
            Controls.Add(llblMessage);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LogIn_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In Page";
            Load += Log_In_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblLogIn;
        private Button btnLogIn;
        private Label llblMessage;
        private Label llblShowPassword;
        private CheckBox lchkBox;
    }
}