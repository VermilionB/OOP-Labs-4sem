using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Laba_2.Classes;
using System.Text.Json;
using System.IO;

namespace Laba_2
{
    public partial class Form1 : Form
    {

        public void validSpeciality()
        {
            bool flag = false;
            foreach (var item in DisciplineList.Items)
            {
                if (item.ToString() == DisciplineList.Text)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show(@"Select correct speciality", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        public void validControl()
        {
            bool flag = false;
            foreach (var item in ExamSelect.Items)
            {
                if (item.ToString() == ExamSelect.Text)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show(@"Select correct control", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }
        public string switchCourse()
        {
            if (Course1.Checked)
            {
                return Course1.Text;
            }
            else if (Course2.Checked)
            {
                return Course2.Text;
            }
            else if (Course3.Checked)
            {
                return Course3.Text;
            }
            else if (Course4.Checked)
            {
                return Course4.Text;
            }
            else return null;
        }
        public Form1()
        {
            InitializeComponent();
            AmountOfLabs.Scroll += AmountOfLabs_Scroll;
        }

        private void AmountOfLabs_Scroll(object sender, EventArgs e)
        {
            AmountOfLabsValue.Text = AmountOfLabs.Value.ToString();
        }

        private void LectorButton_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector();
            lector.Show();
        }

        private void Course4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DisciplineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ClassLector lector = new ClassLector();
            ClassDiscipline discipline = new ClassDiscipline();
           
            using (StreamReader fs = new StreamReader(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 2\Laba 2\jsonLector.json"))
            {
                lector = JsonSerializer.Deserialize<ClassLector>(fs.ReadToEnd());
            }

            TableLector.Rows.Add(lector.Name, lector.Department, lector.Date);

            using (StreamReader fs = new StreamReader(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 2\Laba 2\jsonDiscipline.json"))
            {
                discipline = JsonSerializer.Deserialize<ClassDiscipline>(fs.ReadToEnd());
            }
            var semesters = discipline.Semester.ToArray();
            if (semesters.Length > 1)
            {
                TableDiscipline.Rows.Add(discipline.DisciplineName, $"{semesters[0]}, {semesters[1]}", discipline.Specilization,
                    discipline.Course, discipline.Lections, discipline.Labs, discipline.Control);
            }
            else TableDiscipline.Rows.Add(discipline.DisciplineName, $"{semesters[0]}", discipline.Specilization,
                    discipline.Course, discipline.Lections, discipline.Labs, discipline.Control);

        }

        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if (DisciplineName.Text == string.Empty)
            {
                MessageBox.Show(@"Enter discipline name", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (SemesterListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show(@"Select semester", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            validSpeciality();

            if (!Course1.Checked && !Course2.Checked && !Course3.Checked && !Course4.Checked)
            {
                MessageBox.Show(@"Select course", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //if (AmountOfLections.Value < AmountOfLections.Minimum || AmountOfLections.Value > AmountOfLections.Maximum)
            //{
            //    MessageBox.Show(@"Incorrect amount of lections", @"Error", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}

            validControl();


            List<string> semesterList = new List<string>();
            foreach(string item in SemesterListBox.CheckedItems)
            {
                semesterList.Add(item);
            }
            ClassDiscipline discipline = new ClassDiscipline(DisciplineName.Text, semesterList, DisciplineList.Text,
                switchCourse(), AmountOfLections.Value.ToString(), AmountOfLabs.Value, ExamSelect.Text);

            using (StreamWriter fs = new StreamWriter(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 2\Laba 2\jsonDiscipline.json"))
            {
                fs.WriteLine(JsonSerializer.Serialize(discipline));
            }

        }
    }
}
