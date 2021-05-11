
namespace Interface_OCR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_open_img = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_resultat = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open_img
            // 
            this.btn_open_img.Location = new System.Drawing.Point(12, 12);
            this.btn_open_img.Name = "btn_open_img";
            this.btn_open_img.Size = new System.Drawing.Size(111, 23);
            this.btn_open_img.TabIndex = 0;
            this.btn_open_img.Text = "Ouvrir";
            this.btn_open_img.UseVisualStyleBackColor = true;
            this.btn_open_img.Click += new System.EventHandler(this.btn_open_img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_resultat
            // 
            this.lbl_resultat.AutoSize = true;
            this.lbl_resultat.Location = new System.Drawing.Point(225, 16);
            this.lbl_resultat.Name = "lbl_resultat";
            this.lbl_resultat.Size = new System.Drawing.Size(24, 15);
            this.lbl_resultat.TabIndex = 2;
            this.lbl_resultat.Text = "oui";
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.lbl_resultat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_open_img);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_img;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_resultat;
        private System.Windows.Forms.OpenFileDialog openfile;
    }
}

