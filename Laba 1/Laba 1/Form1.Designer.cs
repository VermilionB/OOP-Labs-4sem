namespace Laba_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.InputStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultStr = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceBut = new System.Windows.Forms.Button();
            this.DeleteSubstr = new System.Windows.Forms.Button();
            this.SymbolByIndexBut = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConsBut = new System.Windows.Forms.Button();
            this.VowBut = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ConsonantsBox = new System.Windows.Forms.Label();
            this.VowelsBox = new System.Windows.Forms.Label();
            this.SenBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(25, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click for length";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputStr
            // 
            this.InputStr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputStr.Location = new System.Drawing.Point(128, 59);
            this.InputStr.Name = "InputStr";
            this.InputStr.Size = new System.Drawing.Size(673, 23);
            this.InputStr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // ResultStr
            // 
            this.ResultStr.Location = new System.Drawing.Point(128, 238);
            this.ResultStr.Name = "ResultStr";
            this.ResultStr.ReadOnly = true;
            this.ResultStr.Size = new System.Drawing.Size(673, 23);
            this.ResultStr.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(815, 534);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 27);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(551, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Substring to be changed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Substring that changes";
            // 
            // ReplaceBut
            // 
            this.ReplaceBut.Location = new System.Drawing.Point(193, 507);
            this.ReplaceBut.Name = "ReplaceBut";
            this.ReplaceBut.Size = new System.Drawing.Size(141, 54);
            this.ReplaceBut.TabIndex = 8;
            this.ReplaceBut.Text = "Replace substring";
            this.ReplaceBut.UseVisualStyleBackColor = true;
            this.ReplaceBut.Click += new System.EventHandler(this.ReplaceBut_Click);
            // 
            // DeleteSubstr
            // 
            this.DeleteSubstr.Location = new System.Drawing.Point(358, 507);
            this.DeleteSubstr.Name = "DeleteSubstr";
            this.DeleteSubstr.Size = new System.Drawing.Size(128, 54);
            this.DeleteSubstr.TabIndex = 9;
            this.DeleteSubstr.Text = "Delete substring";
            this.DeleteSubstr.UseVisualStyleBackColor = true;
            this.DeleteSubstr.Click += new System.EventHandler(this.DeleteSubstr_Click);
            // 
            // SymbolByIndexBut
            // 
            this.SymbolByIndexBut.Location = new System.Drawing.Point(512, 507);
            this.SymbolByIndexBut.Name = "SymbolByIndexBut";
            this.SymbolByIndexBut.Size = new System.Drawing.Size(130, 54);
            this.SymbolByIndexBut.TabIndex = 10;
            this.SymbolByIndexBut.Text = "Take symbol by index";
            this.SymbolByIndexBut.UseVisualStyleBackColor = true;
            this.SymbolByIndexBut.Click += new System.EventHandler(this.SymbolByIndexBut_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 23);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Insert index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-55, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // ConsBut
            // 
            this.ConsBut.Location = new System.Drawing.Point(25, 420);
            this.ConsBut.Name = "ConsBut";
            this.ConsBut.Size = new System.Drawing.Size(146, 55);
            this.ConsBut.TabIndex = 15;
            this.ConsBut.Text = "Click for consonants and vowels";
            this.ConsBut.UseVisualStyleBackColor = true;
            this.ConsBut.Click += new System.EventHandler(this.ConsBut_Click);
            // 
            // VowBut
            // 
            this.VowBut.Location = new System.Drawing.Point(193, 420);
            this.VowBut.Name = "VowBut";
            this.VowBut.Size = new System.Drawing.Size(141, 55);
            this.VowBut.TabIndex = 16;
            this.VowBut.Text = "Click for word count";
            this.VowBut.UseVisualStyleBackColor = true;
            this.VowBut.Click += new System.EventHandler(this.VowBut_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(610, 404);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 29);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(693, 404);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 29);
            this.textBox5.TabIndex = 17;
            // 
            // ConsonantsBox
            // 
            this.ConsonantsBox.AutoSize = true;
            this.ConsonantsBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsonantsBox.Location = new System.Drawing.Point(544, 376);
            this.ConsonantsBox.Name = "ConsonantsBox";
            this.ConsonantsBox.Size = new System.Drawing.Size(111, 25);
            this.ConsonantsBox.TabIndex = 18;
            this.ConsonantsBox.Text = "Consonants";
            // 
            // VowelsBox
            // 
            this.VowelsBox.AutoSize = true;
            this.VowelsBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VowelsBox.Location = new System.Drawing.Point(693, 376);
            this.VowelsBox.Name = "VowelsBox";
            this.VowelsBox.Size = new System.Drawing.Size(71, 25);
            this.VowelsBox.TabIndex = 19;
            this.VowelsBox.Text = "Vowels";
            // 
            // SenBut
            // 
            this.SenBut.Location = new System.Drawing.Point(358, 420);
            this.SenBut.Name = "SenBut";
            this.SenBut.Size = new System.Drawing.Size(128, 54);
            this.SenBut.TabIndex = 20;
            this.SenBut.Text = "Click for sentence count";
            this.SenBut.UseVisualStyleBackColor = true;
            this.SenBut.Click += new System.EventHandler(this.SenBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(888, 591);
            this.Controls.Add(this.SenBut);
            this.Controls.Add(this.VowelsBox);
            this.Controls.Add(this.ConsonantsBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.VowBut);
            this.Controls.Add(this.ConsBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.SymbolByIndexBut);
            this.Controls.Add(this.DeleteSubstr);
            this.Controls.Add(this.ReplaceBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ResultStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputStr);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultStr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplaceBut;
        private System.Windows.Forms.Button DeleteSubstr;
        private System.Windows.Forms.Button SymbolByIndexBut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConsBut;
        private System.Windows.Forms.Button VowBut;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label ConsonantsBox;
        private System.Windows.Forms.Label VowelsBox;
        private System.Windows.Forms.Button SenBut;
    }
}

