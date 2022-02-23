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
            this.DisciplineTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemesterTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Labs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control_format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDiscipline = new System.Windows.Forms.DataGridView();
            this.LectorLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lection_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLector = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SemesterListBox = new System.Windows.Forms.CheckedListBox();
            this.Course1 = new System.Windows.Forms.RadioButton();
            this.Course2 = new System.Windows.Forms.RadioButton();
            this.Course3 = new System.Windows.Forms.RadioButton();
            this.Course4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableLector)).BeginInit();
            this.SuspendLayout();
            // 
            // Discipline
            // 
            this.Discipline.AutoSize = true;
            this.Discipline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Discipline.Location = new System.Drawing.Point(162, 19);
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
            this.DisciplineList.Location = new System.Drawing.Point(138, 175);
            this.DisciplineList.Name = "DisciplineList";
            this.DisciplineList.Size = new System.Drawing.Size(152, 23);
            this.DisciplineList.TabIndex = 1;
            this.DisciplineList.Text = "Select Specialization";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Semester.Location = new System.Drawing.Point(56, 100);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(91, 25);
            this.Semester.TabIndex = 2;
            this.Semester.Text = "Semester";
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(101, 57);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(214, 23);
            this.DisciplineName.TabIndex = 5;
            this.DisciplineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisciplineName_KeyPress);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseLabel.Location = new System.Drawing.Point(56, 218);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(71, 25);
            this.CourseLabel.TabIndex = 7;
            this.CourseLabel.Text = "Course";
            // 
            // AmountOfLections
            // 
            this.AmountOfLections.Location = new System.Drawing.Point(250, 336);
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
            this.LectionsLabel.Location = new System.Drawing.Point(56, 336);
            this.LectionsLabel.Name = "LectionsLabel";
            this.LectionsLabel.Size = new System.Drawing.Size(176, 25);
            this.LectionsLabel.TabIndex = 7;
            this.LectionsLabel.Text = "Amount of lections";
            // 
            // LabsLabel
            // 
            this.LabsLabel.AutoSize = true;
            this.LabsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabsLabel.Location = new System.Drawing.Point(101, 382);
            this.LabsLabel.Name = "LabsLabel";
            this.LabsLabel.Size = new System.Drawing.Size(154, 25);
            this.LabsLabel.TabIndex = 7;
            this.LabsLabel.Text = "Amount of labs :";
            // 
            // AmountOfLabs
            // 
            this.AmountOfLabs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AmountOfLabs.Location = new System.Drawing.Point(138, 424);
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
            this.AmountOfLabsValue.Location = new System.Drawing.Point(261, 384);
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
            this.ExamSelect.Location = new System.Drawing.Point(138, 475);
            this.ExamSelect.Name = "ExamSelect";
            this.ExamSelect.Size = new System.Drawing.Size(152, 23);
            this.ExamSelect.TabIndex = 1;
            this.ExamSelect.Text = "Select control format";
            // 
            // LectorButton
            // 
            this.LectorButton.Location = new System.Drawing.Point(31, 541);
            this.LectorButton.Name = "LectorButton";
            this.LectorButton.Size = new System.Drawing.Size(96, 48);
            this.LectorButton.TabIndex = 11;
            this.LectorButton.Text = "Lector";
            this.LectorButton.UseVisualStyleBackColor = true;
            this.LectorButton.Click += new System.EventHandler(this.LectorButton_Click);
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(138, 541);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(96, 48);
            this.SubmitBut.TabIndex = 12;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.Click += new System.EventHandler(this.SubmitBut_Click);
            // 
            // DisciplineTable
            // 
            this.DisciplineTable.HeaderText = "Discipline";
            this.DisciplineTable.Name = "DisciplineTable";
            this.DisciplineTable.ReadOnly = true;
            // 
            // SemesterTable
            // 
            this.SemesterTable.HeaderText = "Semester";
            this.SemesterTable.Name = "SemesterTable";
            this.SemesterTable.ReadOnly = true;
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Lections
            // 
            this.Lections.HeaderText = "Lections";
            this.Lections.Name = "Lections";
            this.Lections.ReadOnly = true;
            // 
            // Labs
            // 
            this.Labs.HeaderText = "Labs";
            this.Labs.Name = "Labs";
            this.Labs.ReadOnly = true;
            // 
            // Control_format
            // 
            this.Control_format.HeaderText = "Control format";
            this.Control_format.Name = "Control_format";
            this.Control_format.ReadOnly = true;
            // 
            // TableDiscipline
            // 
            this.TableDiscipline.AllowUserToDeleteRows = false;
            this.TableDiscipline.AllowUserToResizeColumns = false;
            this.TableDiscipline.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.TableDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDiscipline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisciplineTable,
            this.SemesterTable,
            this.Specialization,
            this.Course,
            this.Lections,
            this.Labs,
            this.Control_format});
            this.TableDiscipline.Location = new System.Drawing.Point(363, 57);
            this.TableDiscipline.Name = "TableDiscipline";
            this.TableDiscipline.ReadOnly = true;
            this.TableDiscipline.Size = new System.Drawing.Size(746, 254);
            this.TableDiscipline.TabIndex = 14;
            this.TableDiscipline.Text = "dataGridView1";
            // 
            // LectorLabel
            // 
            this.LectorLabel.AutoSize = true;
            this.LectorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LectorLabel.Location = new System.Drawing.Point(363, 330);
            this.LectorLabel.Name = "LectorLabel";
            this.LectorLabel.Size = new System.Drawing.Size(171, 25);
            this.LectorLabel.TabIndex = 0;
            this.LectorLabel.Text = "Info about lector : ";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Lection_date
            // 
            this.Lection_date.HeaderText = "Lection date";
            this.Lection_date.Name = "Lection_date";
            this.Lection_date.ReadOnly = true;
            // 
            // TableLector
            // 
            this.TableLector.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.TableLector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Department,
            this.Lection_date});
            this.TableLector.Location = new System.Drawing.Point(363, 360);
            this.TableLector.Name = "TableLector";
            this.TableLector.Size = new System.Drawing.Size(746, 229);
            this.TableLector.TabIndex = 15;
            this.TableLector.Text = "dataGridView1";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(250, 541);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(96, 48);
            this.ShowButton.TabIndex = 12;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SemesterListBox
            // 
            this.SemesterListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SemesterListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SemesterListBox.FormattingEnabled = true;
            this.SemesterListBox.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 2"});
            this.SemesterListBox.Location = new System.Drawing.Point(163, 106);
            this.SemesterListBox.Name = "SemesterListBox";
            this.SemesterListBox.Size = new System.Drawing.Size(118, 36);
            this.SemesterListBox.TabIndex = 16;
            // 
            // Course1
            // 
            this.Course1.AutoSize = true;
            this.Course1.Location = new System.Drawing.Point(163, 224);
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
            this.Course2.Location = new System.Drawing.Point(162, 249);
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
            this.Course3.Location = new System.Drawing.Point(163, 274);
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
            this.Course4.Location = new System.Drawing.Point(163, 299);
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
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 622);
            this.Controls.Add(this.SemesterListBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.LectorLabel);
            this.Controls.Add(this.TableLector);
            this.Controls.Add(this.TableDiscipline);
            this.Controls.Add(this.Course4);
            this.Controls.Add(this.Course3);
            this.Controls.Add(this.Course2);
            this.Controls.Add(this.Course1);
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
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name.Name = "Form1";
            this.Text = "Discipline";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfLabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableLector)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DisciplineTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemesterTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Labs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control_format;
        private System.Windows.Forms.DataGridView TableDiscipline;
        private System.Windows.Forms.DataGridView TableLector;
        private System.Windows.Forms.Label LectorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lection_date;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.CheckedListBox SemesterListBox;
        private System.Windows.Forms.RadioButton Course1;
        private System.Windows.Forms.RadioButton Course2;
        private System.Windows.Forms.RadioButton Course3;
        private System.Windows.Forms.RadioButton Course4;
    }
}

