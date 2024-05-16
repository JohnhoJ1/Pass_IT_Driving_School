namespace Pass_IT_Driving_School
{
    partial class Registration_Form
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
            btnSignUp = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConformPassword = new TextBox();
            lblConformPassword = new Label();
            lblMessage = new Label();
            chkPassword = new CheckBox();
            lblShowPassword = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(24, 27);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(135, 32);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(250, 23);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(337, 39);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkOliveGreen;
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(250, 298);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(295, 60);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Add";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(250, 90);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(337, 39);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(24, 93);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(125, 32);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passsword";
            // 
            // txtConformPassword
            // 
            txtConformPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConformPassword.Location = new Point(250, 157);
            txtConformPassword.Margin = new Padding(4, 5, 4, 5);
            txtConformPassword.Name = "txtConformPassword";
            txtConformPassword.Size = new Size(337, 39);
            txtConformPassword.TabIndex = 2;
            // 
            // lblConformPassword
            // 
            lblConformPassword.AutoSize = true;
            lblConformPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConformPassword.Location = new Point(24, 160);
            lblConformPassword.Margin = new Padding(4, 0, 4, 0);
            lblConformPassword.Name = "lblConformPassword";
            lblConformPassword.Size = new Size(217, 32);
            lblConformPassword.TabIndex = 6;
            lblConformPassword.Text = "Conform Password";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(433, 620);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 32);
            lblMessage.TabIndex = 10;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkPassword.Location = new Point(444, 235);
            chkPassword.Margin = new Padding(4, 5, 4, 5);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(22, 21);
            chkPassword.TabIndex = 12;
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // lblShowPassword
            // 
            lblShowPassword.AutoSize = true;
            lblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowPassword.Location = new Point(250, 225);
            lblShowPassword.Margin = new Padding(4, 0, 4, 0);
            lblShowPassword.Name = "lblShowPassword";
            lblShowPassword.Size = new Size(192, 32);
            lblShowPassword.TabIndex = 13;
            lblShowPassword.Text = "Show Password?";
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(692, 402);
            Controls.Add(lblShowPassword);
            Controls.Add(chkPassword);
            Controls.Add(lblMessage);
            Controls.Add(txtConformPassword);
            Controls.Add(lblConformPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnSignUp);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Registration_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            Load += Registration_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnSignUp;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConformPassword;
        private Label lblConformPassword;
        private Label lblMessage;
        private CheckBox chkPassword;
        private Label lblShowPassword;
    }
}