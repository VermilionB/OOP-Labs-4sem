namespace Laba_2
{
    partial class Form1
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
            this.Discipline = new System.Windows.Forms.Label();
            this.DisciplineList = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.Label();
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.AmountOfLections = new System.Windows.Forms.NumericUpDown();
            this.LectionsLabel = new System.Windows.Forms.Label();
            this.LabsLabel = new System.Windows.Forms.Label();
            this.AmountOfLabs = new System.Windows.Forms.TrackBar();
            this.AmountOfLabsValue = new System.Windows.Forms.TextBox();
            this.ExamSelect = new System.Windows.Forms.ComboBox();
            this.LectorButton = new System.Windows.Forms.Button();
            this.SubmitBut = new System.Windows.Forms.Button();
            this.semester2 = new System.Windows.Forms.CheckBox();
            this.semester1 = new System.Windows.Forms.CheckBox();
            this.Course1 = new System.Windows.Forms.RadioButton();
            this.Course2 = new System.Windows.Forms.RadioButton();
            this.Course3 = new System.Windows.Forms.RadioButton();
            this.Course4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLabs)).BeginInit();
            this.SuspendLayout();
            // 
            // Discipline
            // 
            this.Discipline.AutoSize = true;
            this.Discipline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Discipline.Location = new System.Drawing.Point(350, 18);
            this.Discipline.Name = "Discipline";
            this.Discipline.Size = new System.Drawing.Size(95, 25);
            this.Discipline.TabIndex = 0;
            this.Discipline.Text = "Discipline";
            // 
            // DisciplineList
            // 
            this.DisciplineList.FormattingEnabled = true;
            this.DisciplineList.Items.AddRange(new object[] {
            "POIT",
            "ISIT",
            "POIBMS",
            "DEiWI"});
            this.DisciplineList.Location = new System.Drawing.Point(326, 174);
            this.DisciplineList.Name = "DisciplineList";
            this.DisciplineList.Size = new System.Drawing.Size(152, 23);
            this.DisciplineList.TabIndex = 1;
            this.DisciplineList.Text = "Select Specialization";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Semester.Location = new System.Drawing.Point(244, 99);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(91, 25);
            this.Semester.TabIndex = 2;
            this.Semester.Text = "Semester";
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(289, 56);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(214, 23);
            this.DisciplineName.TabIndex = 5;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseLabel.Location = new System.Drawing.Point(244, 217);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(71, 25);
            this.CourseLabel.TabIndex = 7;
            this.CourseLabel.Text = "Course";
            // 
            // AmountOfLections
            // 
            this.AmountOfLections.Location = new System.Drawing.Point(438, 335);
            this.AmountOfLections.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.AmountOfLections.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountOfLections.Name = "AmountOfLections";
            this.AmountOfLections.Size = new System.Drawing.Size(65, 23);
            this.AmountOfLections.TabIndex = 8;
            this.AmountOfLections.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LectionsLabel
            // 
            this.LectionsLabel.AutoSize = true;
            this.LectionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LectionsLabel.Location = new System.Drawing.Point(244, 335);
            this.LectionsLabel.Name = "LectionsLabel";
            this.LectionsLabel.Size = new System.Drawing.Size(176, 25);
            this.LectionsLabel.TabIndex = 7;
            this.LectionsLabel.Text = "Amount of lections";
            // 
            // LabsLabel
            // 
            this.LabsLabel.AutoSize = true;
            this.LabsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabsLabel.Location = new System.Drawing.Point(289, 381);
            this.LabsLabel.Name = "LabsLabel";
            this.LabsLabel.Size = new System.Drawing.Size(154, 25);
            this.LabsLabel.TabIndex = 7;
            this.LabsLabel.Text = "Amount of labs :";
            // 
            // AmountOfLabs
            // 
            this.AmountOfLabs.Location = new System.Drawing.Point(326, 423);
            this.AmountOfLabs.Maximum = 17;
            this.AmountOfLabs.Minimum = 9;
            this.AmountOfLabs.Name = "AmountOfLabs";
            this.AmountOfLabs.RightToLeftLayout = true;
            this.AmountOfLabs.Size = new System.Drawing.Size(152, 45);
            this.AmountOfLabs.TabIndex = 9;
            this.AmountOfLabs.Value = 9;
            this.AmountOfLabs.Scroll += new System.EventHandler(this.AmountOfLabs_Scroll);
            // 
            // AmountOfLabsValue
            // 
            this.AmountOfLabsValue.Location = new System.Drawing.Point(449, 383);
            this.AmountOfLabsValue.Name = "AmountOfLabsValue";
            this.AmountOfLabsValue.ReadOnly = true;
            this.AmountOfLabsValue.Size = new System.Drawing.Size(54, 23);
            this.AmountOfLabsValue.TabIndex = 10;
            // 
            // ExamSelect
            // 
            this.ExamSelect.FormattingEnabled = true;
            this.ExamSelect.Items.AddRange(new object[] {
            "Examination",
            "Test"});
            this.ExamSelect.Location = new System.Drawing.Point(326, 474);
            this.ExamSelect.Name = "ExamSelect";
            this.ExamSelect.Size = new System.Drawing.Size(152, 23);
            this.ExamSelect.TabIndex = 1;
            this.ExamSelect.Text = "Select control format";
            // 
            // LectorButton
            // 
            this.LectorButton.Location = new System.Drawing.Point(286, 540);
            this.LectorButton.Name = "LectorButton";
            this.LectorButton.Size = new System.Drawing.Size(96, 48);
            this.LectorButton.TabIndex = 11;
            this.LectorButton.Text = "Lector";
            this.LectorButton.UseVisualStyleBackColor = true;
            this.LectorButton.Click += new System.EventHandler(this.LectorButton_Click);
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(423, 540);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(96, 48);
            this.SubmitBut.TabIndex = 12;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            // 
            // semester2
            // 
            this.semester2.AutoSize = true;
            this.semester2.Location = new System.Drawing.Point(350, 131);
            this.semester2.Name = "semester2";
            this.semester2.Size = new System.Drawing.Size(83, 19);
            this.semester2.TabIndex = 6;
            this.semester2.Text = "Semester 2";
            this.semester2.UseVisualStyleBackColor = true;
            // 
            // semester1
            // 
            this.semester1.AutoSize = true;
            this.semester1.Location = new System.Drawing.Point(350, 106);
            this.semester1.Name = "semester1";
            this.semester1.Size = new System.Drawing.Size(83, 19);
            this.semester1.TabIndex = 6;
            this.semester1.Text = "Semester 1";
            this.semester1.UseVisualStyleBackColor = true;
            // 
            // Course1
            // 
            this.Course1.AutoSize = true;
            this.Course1.Location = new System.Drawing.Point(351, 223);
            this.Course1.Name = "Course1";
            this.Course1.Size = new System.Drawing.Size(31, 19);
            this.Course1.TabIndex = 13;
            this.Course1.TabStop = true;
            this.Course1.Text = "1";
            this.Course1.UseVisualStyleBackColor = true;
            // 
            // Course2
            // 
            this.Course2.AutoSize = true;
            this.Course2.Location = new System.Drawing.Point(350, 248);
            this.Course2.Name = "Course2";
            this.Course2.Size = new System.Drawing.Size(31, 19);
            this.Course2.TabIndex = 13;
            this.Course2.TabStop = true;
            this.Course2.Text = "2";
            this.Course2.UseVisualStyleBackColor = true;
            // 
            // Course3
            // 
            this.Course3.AutoSize = true;
            this.Course3.Location = new System.Drawing.Point(351, 273);
            this.Course3.Name = "Course3";
            this.Course3.Size = new System.Drawing.Size(31, 19);
            this.Course3.TabIndex = 13;
            this.Course3.TabStop = true;
            this.Course3.Text = "3";
            this.Course3.UseVisualStyleBackColor = true;
            // 
            // Course4
            // 
            this.Course4.AutoSize = true;
            this.Course4.Location = new System.Drawing.Point(351, 298);
            this.Course4.Name = "Course4";
            this.Course4.Size = new System.Drawing.Size(31, 19);
            this.Course4.TabIndex = 13;
            this.Course4.TabStop = true;
            this.Course4.Text = "4";
            this.Course4.UseVisualStyleBackColor = true;
            this.Course4.CheckedChanged += new System.EventHandler(this.Course4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.Course4);
            this.Controls.Add(this.Course3);
            this.Controls.Add(this.Course2);
            this.Controls.Add(this.Course1);
            this.Controls.Add(this.semester1);
            this.Controls.Add(this.semester2);
            this.Controls.Add(this.SubmitBut);
            this.Controls.Add(this.LectorButton);
            this.Controls.Add(this.ExamSelect);
            this.Controls.Add(this.AmountOfLabsValue);
            this.Controls.Add(this.AmountOfLabs);
            this.Controls.Add(this.LabsLabel);
            this.Controls.Add(this.LectionsLabel);
            this.Controls.Add(this.AmountOfLections);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.DisciplineList);
            this.Controls.Add(this.Discipline);
            this.Name = "Form1";
            this.Text = "Discipline";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLabs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Discipline;
        private System.Windows.Forms.ComboBox DisciplineList;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.NumericUpDown AmountOfLections;
        private System.Windows.Forms.Label LectionsLabel;
        private System.Windows.Forms.Label LabsLabel;
        private System.Windows.Forms.TrackBar AmountOfLabs;
        private System.Windows.Forms.TextBox AmountOfLabsValue;
        private System.Windows.Forms.ComboBox ExamSelect;
        private System.Windows.Forms.Button LectorButton;
        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.CheckBox semester2;
        private System.Windows.Forms.CheckBox semester1;
        private System.Windows.Forms.RadioButton Course1;
        private System.Windows.Forms.RadioButton Course2;
        private System.Windows.Forms.RadioButton Course3;
        private System.Windows.Forms.RadioButton Course4;
    }
}

