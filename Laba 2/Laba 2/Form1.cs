using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
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
    }
}
