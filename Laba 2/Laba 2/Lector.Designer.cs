namespace Laba_2
{
    partial class Lector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LectorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.LectionDate = new System.Windows.Forms.DateTimePicker();
            this.SelectDateLabel = new System.Windows.Forms.Label();
            this.SubmitLectorBut = new System.Windows.Forms.Button();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LectorLabel
            // 
            this.LectorLabel.AutoSize = true;
            this.LectorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LectorLabel.Location = new System.Drawing.Point(250, 23);
            this.LectorLabel.Name = "LectorLabel";
            this.LectorLabel.Size = new System.Drawing.Size(65, 25);
            this.LectorLabel.TabIndex = 0;
            this.LectorLabel.Text = "Lector";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(65, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(206, 73);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(275, 23);
            this.Name.TabIndex = 1;
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // LectionDate
            // 
            this.LectionDate.Location = new System.Drawing.Point(182, 243);
            this.LectionDate.Name = "LectionDate";
            this.LectionDate.Size = new System.Drawing.Size(200, 23);
            this.LectionDate.TabIndex = 2;
            // 
            // SelectDateLabel
            // 
            this.SelectDateLabel.AutoSize = true;
            this.SelectDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectDateLabel.Location = new System.Drawing.Point(199, 209);
            this.SelectDateLabel.Name = "SelectDateLabel";
            this.SelectDateLabel.Size = new System.Drawing.Size(169, 25);
            this.SelectDateLabel.TabIndex = 0;
            this.SelectDateLabel.Text = "Select lection date";
            // 
            // SubmitLectorBut
            // 
            this.SubmitLectorBut.Location = new System.Drawing.Point(244, 480);
            this.SubmitLectorBut.Name = "SubmitLectorBut";
            this.SubmitLectorBut.Size = new System.Drawing.Size(85, 48);
            this.SubmitLectorBut.TabIndex = 3;
            this.SubmitLectorBut.Text = "Submit ";
            this.SubmitLectorBut.UseVisualStyleBackColor = true;
            this.SubmitLectorBut.Click += new System.EventHandler(this.SubmitLectorBut_Click);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepartmentLabel.Location = new System.Drawing.Point(65, 140);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(170, 25);
            this.DepartmentLabel.TabIndex = 0;
            this.DepartmentLabel.Text = "Select department";
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Items.AddRange(new object[] {
            "ISIT",
            "Design",
            "Programming Engineering"});
            this.DepartmentBox.Location = new System.Drawing.Point(261, 140);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(220, 23);
            this.DepartmentBox.TabIndex = 4;
            this.DepartmentBox.Text = "Department";
            // 
            // Lector
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 560);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.SubmitLectorBut);
            this.Controls.Add(this.SelectDateLabel);
            this.Controls.Add(this.LectionDate);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LectorLabel);
            this.Name.Name = "Lector";
            this.Text = "Lector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LectorLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.DateTimePicker LectionDate;
        private System.Windows.Forms.Label SelectDateLabel;
        private System.Windows.Forms.Button SubmitLectorBut;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.ComboBox DepartmentBox;
    }
}

