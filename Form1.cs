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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tbl_user user = new tbl_user();
           
           
           
            user = db.tbl_user.Where(x => x.KULLANICIADI == txtKullaniciAdi.Text).FirstOrDefault();
           

            if (user != null &&Sifreleme.SifreyiCozAES(user.PASSWORD)==txtSifre.Text)
            {
                MDIParent2 frm = new MDIParent2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Parola!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtKullaniciAdi.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreGüncelle frm = new FrmSifreGüncelle();
            frm.Show();
        }
    }
}
