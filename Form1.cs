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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SeeFishButton_Click_1(object sender, EventArgs e)
        {
            string Fish;
            if (CrappieSelect.Checked == true)
            {
                Fish = "Crappie";
            }
            else if (PerchSelect.Checked == true)
            {
                Fish = "Perch";
            }
            else if (WalleyeSelect.Checked == true)
            {
                Fish = "Walleye";
            }
            else
            {
                Fish = "";
            }

            if (Fish == "")
            {
                MessageBox.Show("Please select a fish.", "Attention !");
            }
            else
            {
                FormSeeFish frmFish = new FormSeeFish(Fish);
                DialogResult result = frmFish.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // get the public member variable value
                    MessageBox.Show(frmFish.Decision, "Decision Result");
                }
                else
                {
                    MessageBox.Show("No decision was made.");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void FishSelectBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
