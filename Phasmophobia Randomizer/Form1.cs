using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phasmophobia_Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Randomizer r = new Randomizer();
            r.Show();
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information i = new Information();
            i.Show();
        }
    }
}
