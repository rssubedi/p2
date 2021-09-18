using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class SeeFish : Form
    {
        public SeeFish(string selectedFish)
        {

            InitializeComponent();

            if (selectedFish == "Crappie")
            {
                pictureBox1.Image = Properties.Resources.Crappie;
            }
            else if (selectedFish == "Perch")
            {
                pictureBox1.Image = Properties.Resources.Perch;
            }
            else if (selectedFish == "Walleye")
            {
                pictureBox1.Image = Properties.Resources.Walleye;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThrowItBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}