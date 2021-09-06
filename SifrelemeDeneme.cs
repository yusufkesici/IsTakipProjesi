using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace garantiTakip
{
    public partial class SifrelemeDeneme : Form
    {
        public SifrelemeDeneme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text= Sifreleme.SifreleAES(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = Sifreleme.SifreyiCozAES(textBox4.Text);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    txtMd5.Text = Sifreleme.SifreleAES(txtSifre.Text);

        //}
    }
}
