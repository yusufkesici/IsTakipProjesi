using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class frmHizmetTuru : Form
    {
        public frmHizmetTuru()
        {
            InitializeComponent();
        }
        
        stajyerEntities3 baglanti = new stajyerEntities3();

        private void frmHizmetTuru_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.tbl_hizmetturu.Select(x => new { x.IND, x.HIZMETTURU }).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Hizmet Türünü Boş Bırakmayınız");
                return;
            }
            foreach (var item in baglanti.tbl_hizmetturu)
            {
                if (textBox2.Text == item.HIZMETTURU)
                {
                    MessageBox.Show("Bu Kayıt Zaten Eklenmiş");
                    return;
                }
            }

            tbl_hizmetturu hizmet = new tbl_hizmetturu();


            hizmet.HIZMETTURU = textBox2.Text;

            baglanti.tbl_hizmetturu.Add(hizmet);


            baglanti.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
            frmHizmetTuru_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox3.Text);
                if (textBox3.Text != null)
                {


                    var sil = baglanti.tbl_hizmetturu.Where(w => w.IND == a).FirstOrDefault();
                    baglanti.tbl_hizmetturu.Remove(sil);
                    baglanti.SaveChanges();
                    frmHizmetTuru_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı");
                }
            }
            catch
            {

                MessageBox.Show("Kayıt Bulunamadı");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in baglanti.tbl_hizmetturu)
            {
                if (textBox2.Text == item.HIZMETTURU)
                {
                    MessageBox.Show("Bu Kayıt Zaten Eklenmiş");
                    return;
                }
            }
            if (textBox2.Text == "" || textBox2.Text == " " || textBox2.Text == "  " || textBox2.Text == "   " || textBox2.Text == "     "
                || textBox2.Text == "      " || textBox2.Text == "       ")
            {

                MessageBox.Show("Hizmet Türü Boş Bırakılamaz");
                return;
            }
           
            try
            {
                int b = int.Parse(textBox3.Text);
                if (textBox3.Text != null)
                {
                    if (textBox2.Text != null)
                    {
                        var guncelle = baglanti.tbl_hizmetturu.Where(w => w.IND == b).FirstOrDefault();

                        guncelle.HIZMETTURU = textBox2.Text;
                        baglanti.SaveChanges();
                        frmHizmetTuru_Load(sender, e);
                    }




                }
                else
                {
                    MessageBox.Show("Kayıt Bulununamadı");
                }
            }
            catch
            {

                MessageBox.Show("Kullanıcı Bulunamadı");
            }




        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                button1.Enabled = false;
            }
            else if (e.KeyCode != Keys.Back)
            {
                button1.Enabled = true;
            }
        }


        //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

    }
}
