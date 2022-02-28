using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_3.Classes;
using System.IO;
using System.Text.Json;

namespace Laba_3
{
    public partial class Lector : Form
    {
        public Lector()
        {
            InitializeComponent();
        }

        public void validDepartment()
        {
            bool flag = false;
            foreach (var item in DepartmentBox.Items)
            {
                if (item.ToString() == DepartmentBox.Text)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show(@"Select correct department", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void SubmitLectorBut_Click(object sender, EventArgs e)
        {
            if (Name.Text == string.Empty)
            {
                MessageBox.Show(@"Enter lector's name", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            validDepartment();
            ClassLector lector = new ClassLector(Name.Text, DepartmentBox.Text, LectionDate.Value);
            using (StreamWriter fs = new StreamWriter(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 3\Laba 3\jsonLector.json"))
            {
                fs.WriteLine( JsonSerializer.Serialize(lector));
            }
            this.Close();
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
