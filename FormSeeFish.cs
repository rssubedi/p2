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
    public partial class FormSeeFish : Form
    {

        public string Decision;
        public string FishName;

        public FormSeeFish(string Fish)
        {
            InitializeComponent();
            FishName = Fish;

        }

        private void FishPictureBox_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (FishName == "Crappie")
            {
                LoadPictures.Image = Properties.Resources.Crappie;
            }
            else if (FishName == "Walleye")
            {
                LoadPictures.Image = Properties.Resources.Walleye;
            }
            else
            {
                LoadPictures.Image = Properties.Resources.Perch;
            }

        }



        private void KeepitButton_Click_1(object sender, EventArgs e)
        {
            Decision = "Decision is to keep it.";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decision = "Decision is to throw it back.";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Decision = "Decision canceled.";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
 

    }
}
