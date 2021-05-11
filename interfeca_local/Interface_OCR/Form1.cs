using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_img_Click(object sender, EventArgs e)
        {
            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openfile.FileName);
            }
        }
    }
}
