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
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        bool kontrol;
        bool hkontrol;
        bool mckontrol;
        bool ckontrol;

        stajyerEntities3 baglanti = new stajyerEntities3();

        private void frmListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.tbl_cari.Select(x => new {x.IND,x.FIRMAKODU,x.FIRMAADI,x.YETKILI,x.VERGIDAIRESI,x.VERGINO,x.KAYITTARIHI,x.ISKONTO,
                x.FIRMATIPI,x.ADI,x.SOYAD,x.UNVAN,x.SEKTOR,x.MARKA,x.EMAIL,x.URL,x.TELEFON1,x.TELEFON2,x.ADRESFATURA,x.ADRESSEVK,x.PARABIRIMI,x.IL,x.SEHIR,x.PERSONELNO,x.STATUS,x.YETKİLİDGMTARİH,
            x.HIZMETTURU,x.BASBITTAR}).ToList();
            ckontrol = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = baglanti.tbl_Yetkili.Select(x => new { x.IND,x.FIRMANO,x.AD,x.SOYAD,x.TELEFON,x.MAIL,x.DGMTARİH}).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = baglanti.tbl_hizmetturu.Select(x => new { x.IND, x.FIRMANO, x.HIZMETTURU }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = baglanti.tbl_cari.Select(x => new {x.FIRMAADI,x.tbl_personel.PERSONELAD,x.tbl_personel.PERSONELSOYAD,x.tbl_yorum.YORUM }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.DataSource = baglanti.tbl_cari.Select(x => new {
                x.IND,
                x.FIRMAKODU,
                x.FIRMAADI,
                x.YETKILI,
                x.VERGIDAIRESI,
                x.VERGINO,
                x.KAYITTARIHI,
                x.ISKONTO,
                x.FIRMATIPI,
                x.ADI,
                x.SOYAD,
                x.UNVAN,
                x.SEKTOR,
                x.MARKA,
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.SEHIR,
                x.PERSONELNO,
                x.STATUS,
                x.YETKİLİDGMTARİH,
                x.HIZMETTURU,
                x.BASBITTAR
            }).ToList();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (kontrol == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                   

                    dataGridView1.DataSource = baglanti.tbl_Yetkili.Where(r => r.AD.Contains(textBox1.Text) || r.SOYAD.Contains(textBox1.Text)).Select(x => new { x.IND, x.FIRMANO, x.AD, x.SOYAD, x.TELEFON, x.MAIL, x.DGMTARİH }).ToList();
                }


            }

            if (hkontrol == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                   

                    dataGridView1.DataSource = baglanti.tbl_hizmetturu.Where(r => r.HIZMETTURU.Contains(textBox1.Text)).Select(x => new { x.IND, x.FIRMANO, x.HIZMETTURU }).ToList();
                }
            }

            if (mckontrol == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataGridView1.DataSource = baglanti.tbl_cari.Where(r => r.tbl_personel.PERSONELAD.Contains(textBox1.Text)).Select(x => new { x.FIRMAADI, x.tbl_personel.PERSONELAD, x.tbl_personel.PERSONELSOYAD, x.tbl_yorum.YORUM }).ToList();
                }
            }

            if (ckontrol == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataGridView1.DataSource = baglanti.tbl_cari.Where(r => r.ADI.Contains(textBox1.Text) || r.SOYAD.Contains(textBox1.Text) || r.TELEFON1.Contains(textBox1.Text)).Select(x => new
                    {
                        x.IND,
                        x.FIRMAKODU,
                        x.FIRMAADI,
                        x.YETKILI,
                        x.VERGIDAIRESI,
                        x.VERGINO,
                        x.KAYITTARIHI,
                        x.ISKONTO,
                        x.FIRMATIPI,
                        x.ADI,
                        x.SOYAD,
                        x.UNVAN,
                        x.SEKTOR,
                        x.MARKA,
                        x.EMAIL,
                        x.URL,
                        x.TELEFON1,
                        x.TELEFON2,
                        x.ADRESFATURA,
                        x.ADRESSEVK,
                        x.PARABIRIMI,
                        x.IL,
                        x.SEHIR,
                        x.PERSONELNO,
                        x.STATUS,
                        x.YETKİLİDGMTARİH,
                        x.HIZMETTURU,
                        x.BASBITTAR
                    }).ToList();
                }

            }
                
            
               
           
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            kontrol = true;
            hkontrol = false;
            mckontrol = false;
            ckontrol = false;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            hkontrol = true;
            mckontrol = false;
            ckontrol = false;
            kontrol = false;
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            mckontrol = true;
            ckontrol = false;
            kontrol = false;
            hkontrol = false;
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            ckontrol = true;
            hkontrol = false;
            kontrol = false;
            mckontrol = false;
        }
    }
}
