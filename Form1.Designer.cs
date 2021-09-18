
namespace P2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FishSelectBox = new System.Windows.Forms.GroupBox();
            this.WalleyeSelect = new System.Windows.Forms.RadioButton();
            this.PerchSelect = new System.Windows.Forms.RadioButton();
            this.CrappieSelect = new System.Windows.Forms.RadioButton();
            this.SeeFishButton = new System.Windows.Forms.Button();
            this.FishSelectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FishSelectBox
            // 
            this.FishSelectBox.Controls.Add(this.WalleyeSelect);
            this.FishSelectBox.Controls.Add(this.PerchSelect);
            this.FishSelectBox.Controls.Add(this.CrappieSelect);
            this.FishSelectBox.Location = new System.Drawing.Point(52, 42);
            this.FishSelectBox.Name = "FishSelectBox";
            this.FishSelectBox.Size = new System.Drawing.Size(410, 239);
            this.FishSelectBox.TabIndex = 0;
            this.FishSelectBox.TabStop = false;
            this.FishSelectBox.Text = "Choose a fish to see";
            this.FishSelectBox.Enter += new System.EventHandler(this.FishSelectBox_Enter);
            // 
            // WalleyeSelect
            // 
            this.WalleyeSelect.AutoSize = true;
            this.WalleyeSelect.Location = new System.Drawing.Point(102, 128);
            this.WalleyeSelect.Name = "WalleyeSelect";
            this.WalleyeSelect.Size = new System.Drawing.Size(63, 17);
            this.WalleyeSelect.TabIndex = 2;
            this.WalleyeSelect.TabStop = true;
            this.WalleyeSelect.Text = "Walleye";
            this.WalleyeSelect.UseVisualStyleBackColor = true;
            // 
            // PerchSelect
            // 
            this.PerchSelect.AutoSize = true;
            this.PerchSelect.Location = new System.Drawing.Point(102, 94);
            this.PerchSelect.Name = "PerchSelect";
            this.PerchSelect.Size = new System.Drawing.Size(53, 17);
            this.PerchSelect.TabIndex = 1;
            this.PerchSelect.TabStop = true;
            this.PerchSelect.Text = "Perch";
            this.PerchSelect.UseVisualStyleBackColor = true;
            // 
            // CrappieSelect
            // 
            this.CrappieSelect.AutoSize = true;
            this.CrappieSelect.Location = new System.Drawing.Point(102, 58);
            this.CrappieSelect.Name = "CrappieSelect";
            this.CrappieSelect.Size = new System.Drawing.Size(61, 17);
            this.CrappieSelect.TabIndex = 0;
            this.CrappieSelect.TabStop = true;
            this.CrappieSelect.Text = "Crappie";
            this.CrappieSelect.UseVisualStyleBackColor = true;
            // 
            // SeeFishButton
            // 
            this.SeeFishButton.Location = new System.Drawing.Point(346, 299);
            this.SeeFishButton.Name = "SeeFishButton";
            this.SeeFishButton.Size = new System.Drawing.Size(116, 37);
            this.SeeFishButton.TabIndex = 3;
            this.SeeFishButton.Text = "See Fish";
            this.SeeFishButton.UseVisualStyleBackColor = true;
            this.SeeFishButton.Click += new System.EventHandler(this.SeeFishButton_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(525, 401);
            this.Controls.Add(this.SeeFishButton);
            this.Controls.Add(this.FishSelectBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FishSelectBox.ResumeLayout(false);
            this.FishSelectBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.GroupBox FishSelectBox;
        private System.Windows.Forms.RadioButton WalleyeSelect;
        private System.Windows.Forms.RadioButton PerchSelect;
        private System.Windows.Forms.RadioButton CrappieSelect;
        private System.Windows.Forms.Button SeeFishButton;
    }
}

