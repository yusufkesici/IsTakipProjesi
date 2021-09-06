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
    public partial class PersonelListe : Form
    {
        public PersonelListe()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void PersonelListe_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.tbl_personel.Select(x => new
            {
                x.IND,
                x.PERSONELAD,
                x.PERSONELSOYAD,
                x.PERSONELTC,
                x.PERSONELTEL,
                x.PERSONELMAİL,
                x.PERSONELADRES, 
      
            }).ToList();

            int toplam = 0;

            for (int i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                toplam = i;
            }
            label9.Text = "Toplam Personel Sayısı : " + toplam;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tbl_personel personel = new tbl_personel();

            if ((string.IsNullOrWhiteSpace(txtPersonelAd.Text) && txtPersonelAd.Text.Length >= 0)||(string.IsNullOrWhiteSpace(txtPersonelSoyad.Text) && txtPersonelSoyad.Text.Length >= 0))

            {
                MessageBox.Show("Personel Adını ve Soyadını Boş Geçmeyin");
               
                return;
            }

            personel.PERSONELAD = txtPersonelAd.Text;
            personel.PERSONELSOYAD = txtPersonelSoyad.Text;
            personel.PERSONELTC = mtxtPersonelTC.Text;
            personel.PERSONELTEL = mtxtPersonelTel.Text;
            personel.PERSONELMAİL = txtPersonelMail.Text;
            personel.PERSONELADRES = txtPersonelAdres.Text;

            int toplam = 0;
            string c, d;
            string sayı1 = mtxtPersonelTC.Text;
            string sayı2 = sayı1[sayı1.Length - 1].ToString();

            foreach (var i in sayı1)
            {
                c = i.ToString();

                toplam = toplam + int.Parse(c);
            }

            toplam = toplam - int.Parse(sayı2);

            d = toplam.ToString();

            d = d[d.Length - 1].ToString();

            if (d == sayı2)
            {
                
                db.tbl_personel.Add(personel);
                db.SaveChanges();
                MessageBox.Show("Eklenmiştir");
                PersonelListe_Load(sender, e);
            }
 
            else

               MessageBox.Show( "Girilen Değer Bir Tc Kimlik Numarası Olamaz.");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtPersonelIND.Text);
                var personelad = db.tbl_personel.Where(w => w.IND == a).FirstOrDefault();
                db.tbl_personel.Remove(personelad);

                DialogResult dialogResult = MessageBox.Show("Emin Misiniz?", "UYARI!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("Silindi");
                    PersonelListe_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

                 

            }
            catch
            {
                MessageBox.Show("Hata");

            }
      
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtPersonelIND.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtPersonelAd.Text = (dataGridView1.CurrentRow.Cells[1].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtPersonelSoyad.Text = (dataGridView1.CurrentRow.Cells[2].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[2].Value.ToString());
            mtxtPersonelTC.Text = (dataGridView1.CurrentRow.Cells[3].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            mtxtPersonelTel.Text = (dataGridView1.CurrentRow.Cells[4].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtPersonelMail.Text = (dataGridView1.CurrentRow.Cells[5].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[5].Value.ToString());
            txtPersonelAdres.Text = (dataGridView1.CurrentRow.Cells[6].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[6].Value.ToString());

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int ind = int.Parse(txtPersonelIND.Text);
            var x = db.tbl_personel.Find(ind);

            x.PERSONELAD = txtPersonelAd.Text;
            x.PERSONELSOYAD = txtPersonelSoyad.Text;
            x.PERSONELTEL = mtxtPersonelTel.Text;
            x.PERSONELMAİL = txtPersonelMail.Text;
            x.PERSONELADRES = txtPersonelAdres.Text;

            try
            {
                int toplam = 0;
                string c, d;
                string sayı1 = mtxtPersonelTC.Text;
                string sayı2 = sayı1[sayı1.Length - 1].ToString();

                foreach (var i in sayı1)
                {
                    c = i.ToString();

                    toplam = toplam + int.Parse(c);
                }

                toplam = toplam - int.Parse(sayı2);

                d = toplam.ToString();

                d = d[d.Length - 1].ToString();

                if (d == sayı2)
                {
                    MessageBox.Show("Güncelleme Yapıldı.");
                    int tc = int.Parse(txtPersonelIND.Text);
                    var b = db.tbl_personel.Find(tc);
                    b.PERSONELTC = mtxtPersonelTC.Text;
                    db.SaveChanges();

                }

                else
                {
                    MessageBox.Show("Girilen Değer Bir Tc Kimlik Numarası Olamaz.");
                }

                db.SaveChanges();
                PersonelListe_Load(sender, e);
            }
            catch (Exception)
            {

                x.PERSONELTC = "";
                db.SaveChanges();
                PersonelListe_Load(sender, e);

            } 


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtPersonelAdres.Clear();
            txtPersonelMail.Clear();
            txtPersonelIND.Clear();
            mtxtPersonelTC.Clear();
            mtxtPersonelTel.Clear();
        }



        //private void mtxtPersonelTel_Click(object sender, EventArgs e)
        //{
        //    mtxtPersonelTel.SelectionStart = mtxtPersonelTel.Text.TrimEnd().Length;
        //}
    }
}
