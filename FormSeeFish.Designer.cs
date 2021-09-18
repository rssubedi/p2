
namespace P2
{
    partial class FormSeeFish
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ThrowbackButton = new System.Windows.Forms.Button();
            this.KeepitButton = new System.Windows.Forms.Button();
            this.LoadPictures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(134, 376);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 44);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // ThrowbackButton
            // 
            this.ThrowbackButton.Location = new System.Drawing.Point(295, 376);
            this.ThrowbackButton.Name = "ThrowbackButton";
            this.ThrowbackButton.Size = new System.Drawing.Size(145, 44);
            this.ThrowbackButton.TabIndex = 2;
            this.ThrowbackButton.Text = "Throw It Back";
            this.ThrowbackButton.UseVisualStyleBackColor = true;
            this.ThrowbackButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeepitButton
            // 
            this.KeepitButton.Location = new System.Drawing.Point(465, 376);
            this.KeepitButton.Name = "KeepitButton";
            this.KeepitButton.Size = new System.Drawing.Size(145, 44);
            this.KeepitButton.TabIndex = 3;
            this.KeepitButton.Text = "Keep It";
            this.KeepitButton.UseVisualStyleBackColor = true;
            this.KeepitButton.Click += new System.EventHandler(this.KeepitButton_Click_1);
            // 
            // LoadPictures
            // 
            this.LoadPictures.Location = new System.Drawing.Point(109, 56);
            this.LoadPictures.Name = "LoadPictures";
            this.LoadPictures.Size = new System.Drawing.Size(541, 302);
            this.LoadPictures.TabIndex = 3;
            this.LoadPictures.TabStop = false;
            this.LoadPictures.Click += new System.EventHandler(this.FishPictureBox_Click);
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeepitButton);
            this.Controls.Add(this.ThrowbackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoadPictures);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSeeFish";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.LoadPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadPictures;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ThrowbackButton;
        private System.Windows.Forms.Button KeepitButton;
    }
}