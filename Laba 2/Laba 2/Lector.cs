using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_2.Classes;
using System.IO;
using System.Text.Json;

namespace Laba_2
{
    public partial class Lector : Form
    {
        public Lector()
        {
            InitializeComponent();
        }

        private void SubmitLectorBut_Click(object sender, EventArgs e)
        {
            ClassLector lector = new ClassLector(Name.Text, DepartmentBox.Text, LectionDate.Value);
            using (StreamWriter fs = new StreamWriter(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 2\Laba 2\jsonLector.json"))
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
