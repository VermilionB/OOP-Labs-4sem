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
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SelectDateLabel = new System.Windows.Forms.Label();
            this.SubmitLectorBut = new System.Windows.Forms.Button();
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
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(56, 73);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(88, 25);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(197, 74);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(275, 23);
            this.Surname.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(56, 117);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(197, 118);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(275, 23);
            this.Name.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
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
            // 
            // Lector
            // 
            this.ClientSize = new System.Drawing.Size(564, 560);
            this.Controls.Add(this.SubmitLectorBut);
            this.Controls.Add(this.SelectDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.LectorLabel);
            this.Name = "Lector";
            this.Text = "Lector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LectorLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label SelectDateLabel;
        private System.Windows.Forms.Button SubmitLectorBut;
    }
}

