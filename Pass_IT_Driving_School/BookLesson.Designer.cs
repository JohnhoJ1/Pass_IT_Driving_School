namespace Pass_IT_Driving_School
{
    partial class BookLesson
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
            lblLBName = new Label();
            lblLBNameDisplay = new Label();
            lblLBLastnameDisplay = new Label();
            lblDate = new Label();
            lalblTimeDuration = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            btnSave = new Button();
            btnCancle = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblLBName
            // 
            lblLBName.AutoSize = true;
            lblLBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLBName.ForeColor = Color.Black;
            lblLBName.Location = new Point(306, 80);
            lblLBName.Margin = new Padding(4, 0, 4, 0);
            lblLBName.Name = "lblLBName";
            lblLBName.Size = new Size(92, 32);
            lblLBName.TabIndex = 0;
            lblLBName.Text = "Name :";
            // 
            // lblLBNameDisplay
            // 
            lblLBNameDisplay.AutoSize = true;
            lblLBNameDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLBNameDisplay.ForeColor = Color.Black;
            lblLBNameDisplay.Location = new Point(131, 55);
            lblLBNameDisplay.Margin = new Padding(4, 0, 4, 0);
            lblLBNameDisplay.Name = "lblLBNameDisplay";
            lblLBNameDisplay.Size = new Size(0, 32);
            lblLBNameDisplay.TabIndex = 1;
            // 
            // lblLBLastnameDisplay
            // 
            lblLBLastnameDisplay.AutoSize = true;
            lblLBLastnameDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLBLastnameDisplay.ForeColor = Color.Black;
            lblLBLastnameDisplay.Location = new Point(131, 108);
            lblLBLastnameDisplay.Margin = new Padding(4, 0, 4, 0);
            lblLBLastnameDisplay.Name = "lblLBLastnameDisplay";
            lblLBLastnameDisplay.Size = new Size(0, 32);
            lblLBLastnameDisplay.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(306, 128);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(138, 32);
            lblDate.TabIndex = 3;
            lblDate.Text = "Select Date";
            // 
            // lalblTimeDuration
            // 
            lalblTimeDuration.AutoSize = true;
            lalblTimeDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lalblTimeDuration.ForeColor = Color.Black;
            lalblTimeDuration.Location = new Point(306, 175);
            lalblTimeDuration.Margin = new Padding(4, 0, 4, 0);
            lalblTimeDuration.Name = "lalblTimeDuration";
            lalblTimeDuration.Size = new Size(170, 32);
            lalblTimeDuration.TabIndex = 4;
            lalblTimeDuration.Text = "Time Duration";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(503, 119);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 39);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(503, 168);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 39);
            numericUpDown1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(306, 272);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 67);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Maroon;
            btnCancle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(480, 272);
            btnCancle.Margin = new Padding(4, 5, 4, 5);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(161, 67);
            btnCancle.TabIndex = 8;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // BookLesson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1091, 435);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lalblTimeDuration);
            Controls.Add(lblDate);
            Controls.Add(lblLBLastnameDisplay);
            Controls.Add(lblLBNameDisplay);
            Controls.Add(lblLBName);
            ForeColor = Color.AliceBlue;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "BookLesson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Lesson";
            Load += BookLesson_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLBName;
        private Label lblLBNameDisplay;
        private Label lblLBLastnameDisplay;
        private Label lblDate;
        private Label lalblTimeDuration;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Button btnSave;
        private Button btnCancle;
    }
}