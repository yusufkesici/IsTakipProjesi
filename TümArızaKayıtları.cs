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
    public partial class TümArızaKayıtları : Form
    {
        AnasayfaFrm Form;
        public TümArızaKayıtları(AnasayfaFrm frm)
        {
            Form = frm;
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void TümArızaKayıtları_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource=db.tbl_Ariza.Where()
            if (Form.CariINDD.Text == "CariIND")
            {
                dataGridView1.DataSource = db.tbl_Ariza.ToList();
                dataGridView1.Columns["EnSonGidilenServisTarih"].Visible = false;
                dataGridView1.Columns["MusteriYorumu"].Visible = false;
                dataGridView1.Columns["PersonelYorumu"].Visible = false;
                dataGridView1.Columns["MusteriAktifMi"].Visible = false;
                dataGridView1.Columns["MusteriAldigiHizmet"].Visible = false;
                dataGridView1.Columns["MusteriAdres"].Visible = false;
                dataGridView1.Columns["IstenilenServisTarihi"].Visible = false;
                dataGridView1.Columns["MusteriTuru"].Visible = false;
                dataGridView1.Columns["tbl_cari"].Visible = false;
                dataGridView1.Columns["MusteriKayitTarih"].Visible = false;
                return;
            }
            
           int cariID= Convert.ToInt32( Form.CariINDD.Text);
            tbl_cari cari = db.tbl_cari.Find(cariID);
            List<tbl_Ariza> ariza = db.tbl_Ariza.Where(x => x.CariID == cariID).ToList();
          
            foreach (tbl_Ariza arizaa in ariza)
            {
                if (arizaa.MusteriAd!= cari.tbl_Yetkili.AD && arizaa.MusteriSoyad != cari.tbl_Yetkili.SOYAD)
                {
                    arizaa.MusteriAd = cari.tbl_Yetkili.AD;
                    arizaa.MusteriSoyad = cari.tbl_Yetkili.SOYAD;
                    arizaa.MusteriTelefon = cari.tbl_Yetkili.TELEFON;
                    arizaa.MusteriKayitTarih = cari.KAYITTARIHI;

                    db.SaveChanges();
                }
               
                
            }

            
            dataGridView1.DataSource = db.tbl_Ariza.Where(x => x.CariID == cariID).ToList();

            dataGridView1.Columns["EnSonGidilenServisTarih"].Visible = false;
            dataGridView1.Columns["MusteriYorumu"].Visible = false;
            dataGridView1.Columns["PersonelYorumu"].Visible = false;
            dataGridView1.Columns["MusteriAktifMi"].Visible = false;
            dataGridView1.Columns["MusteriAldigiHizmet"].Visible = false;
            dataGridView1.Columns["MusteriAdres"].Visible = false;
            dataGridView1.Columns["IstenilenServisTarihi"].Visible = false;
            dataGridView1.Columns["MusteriTuru"].Visible = false;
        }
        
    }
}
