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
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }

        stajyerEntities3 db = new stajyerEntities3();

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.IND,
                x.FIRMAKODU,
                x.FIRMAADI,
                x.YETKILI,
                x.VERGIDAIRESI,
                x.VERGINO,
                x.KAYITTARIHI,
                x.ISKONTO,
                x.tbl_firmaTipi.FIRMATİPİ,
                x.tbl_Yetkili.AD,
                x.tbl_Yetkili.SOYAD,
                x.UNVAN,
                x.tbl_sektor.SEKTORADI,
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
                x.tbl_status.STATUS,
                x.tbl_Yetkili.DGMTARİH,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH,
                x.tbl_Yetkili.MAIL,
                x.tbl_Yetkili.TELEFON,



            }).ToList();
        }

        private void frmGuncelle_Load(object sender, EventArgs e)
        {

            Listele();

            foreach (var item in db.tbl_sektor)
            {
                comboSektor.Items.Add(item.SEKTORADI);
            }

            foreach (var firma in db.tbl_firmaTipi)
            {
                comboFirmatipi.Items.Add(firma.FIRMATİPİ);
            }

            foreach (var hizmet in db.tbl_hizmetturu)
            {
                comboHizmetturu.Items.Add(hizmet.HIZMETTURU);
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtFirmaKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFirmaAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYetkili.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboFirmatipi.Text = (dataGridView1.CurrentRow.Cells[8].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[8].Value.ToString());
            comboSektor.Text = (dataGridView1.CurrentRow.Cells[12].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[12].Value.ToString());
            txtSehir.Text = (dataGridView1.CurrentRow.Cells[22].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[22].Value.ToString());
            txtTel.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtTel2.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtUrl.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            comboHizmetturu.Text = (dataGridView1.CurrentRow.Cells[26].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[26].Value.ToString());
            txtAdresSevk.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtAdresFatura.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtIskonto.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtVergiDaire.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtVergiNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboParabirimi.Text = (dataGridView1.CurrentRow.Cells[20].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[20].Value.ToString());
            txtBaslangıcTarih.Value = (dataGridView1.CurrentRow.Cells[27].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells["BASLANGICTARİH"].Value);
            txtBitisTarih.Value = (dataGridView1.CurrentRow.Cells[28].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[28].Value);
            txtYetkiliAd.Text = (dataGridView1.CurrentRow.Cells[9].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtYetkiliMail.Text = (dataGridView1.CurrentRow.Cells[29].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[29].Value.ToString());
            txtYetkiliTel2.Text = (dataGridView1.CurrentRow.Cells[30].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[30].Value.ToString());
            txtyetkiliSoyadi.Text = (dataGridView1.CurrentRow.Cells[10].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[10].Value.ToString());
            txtYetkiliDgmTarih.Value = (dataGridView1.CurrentRow.Cells[25].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[25].Value);
            lblind.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtKayitTarih.Value = (dataGridView1.CurrentRow.Cells[6].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
            bool deger = ((dataGridView1.CurrentRow.Cells[24].Value == null) ? true : Convert.ToBoolean((dataGridView1.CurrentRow.Cells[24].Value.ToString())));
            textUnvan.Text = (dataGridView1.CurrentRow.Cells[11].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[11].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[24].Value != null)
            {

                if (deger)
                {
                    RbAktif.Checked = true;

                }
                else
                {
                    RbPasif.Checked = true;
                }
            }
            else
            {

                RbAktif.Checked = false;
                RbPasif.Checked = false;
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            //try
            //{
            int b = int.Parse(lblind.Text);
            if (lblind.Text != null)
            {

                tbl_cari guncelle = db.tbl_cari.Where(w => w.IND == b).FirstOrDefault();
                tbl_sektor sektor = db.tbl_sektor.Where(x => x.SEKTORADI == comboSektor.Text).FirstOrDefault();
                tbl_firmaTipi firma = db.tbl_firmaTipi.Where(x => x.FIRMATİPİ == comboFirmatipi.Text).FirstOrDefault();
                tbl_hizmetturu hizmet = db.tbl_hizmetturu.Where(x => x.HIZMETTURU == comboHizmetturu.Text).FirstOrDefault();
                tbl_status status = db.tbl_status.Where(x => x.STATUS == RbAktif.Checked == true || x.STATUS == RbPasif.Checked == false).FirstOrDefault();

                //tbl_sektor sek1 = new tbl_sektor();
                //sek1.IND = int.Parse(lblind.Text);

                //tbl_firmaTipi firma1 = new tbl_firmaTipi();
                //firma1.IND = 

                if (sektor == null)
                {
                    MessageBox.Show("SektörAdı Boş bırakılamaz");
                    return;
                }
                else
                {
                    guncelle.SEKTOR = sektor.IND;
                }

                if (firma == null)
                {
                    MessageBox.Show("FirmaTipi Boş Bırakılamaz");
                    return;
                }
                else
                {
                    guncelle.FIRMATIPI = firma.IND;
                }
                if (hizmet == null)
                {
                    MessageBox.Show("HizmetTürü Boş Bırakılamaz");
                    return;
                }
                else
                {
                    guncelle.HIZMETTURU = hizmet.IND;
                }
                if (status == null)
                {
                    MessageBox.Show("Status Boş Bırakılamaz");
                    return;
                }
                else
                {
                    guncelle.STATUS = status.IND;
                }





                guncelle.FIRMAKODU = txtFirmaKod.Text;
                guncelle.FIRMAADI = txtFirmaAd.Text;

                guncelle.SEHIR = txtSehir.Text;
                guncelle.TELEFON1 = txtTel.Text;
                guncelle.TELEFON2 = txtTel2.Text;
                guncelle.EMAIL = txtMail.Text;

                guncelle.ADRESSEVK = txtAdresSevk.Text;
                guncelle.ADRESFATURA = txtAdresFatura.Text;
                guncelle.ISKONTO = decimal.Parse(txtIskonto.Text);
                guncelle.VERGIDAIRESI = txtVergiDaire.Text;
                guncelle.VERGINO = txtVergiNo.Text;

                guncelle.UNVAN = textUnvan.Text;

                if (comboParabirimi.Text == null)
                {
                    MessageBox.Show("Para Birimi Seçmediniz");
                    return;
                }
                else
                {
                    guncelle.PARABIRIMI = comboParabirimi.Text;
                }

                guncelle.tbl_baslangicBitisTarih.BASLANGICTARİH = txtBaslangıcTarih.Value;


                guncelle.tbl_baslangicBitisTarih.BİTİSTARİH = txtBitisTarih.Value;


                guncelle.tbl_Yetkili.AD = txtYetkiliAd.Text;
                guncelle.tbl_Yetkili.SOYAD = txtyetkiliSoyadi.Text;
                guncelle.tbl_Yetkili.TELEFON = txtYetkiliTel2.Text;
                guncelle.tbl_Yetkili.MAIL = txtYetkiliMail.Text;
                guncelle.KAYITTARIHI = DateTime.Parse(txtKayitTarih.Text);

                guncelle.tbl_Yetkili.DGMTARİH = txtYetkiliDgmTarih.Value;


                if (comboSektor.Text == null || comboFirmatipi.Text == null || comboParabirimi.Text == null || comboHizmetturu == null)
                {
                    MessageBox.Show("Test");
                }

                db.Entry(guncelle).State = System.Data.Entity.EntityState.Modified; // Güncelleme Veritabanına belirtildi

                int sonuc = db.SaveChanges();



                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                }
                else
                {

                    MessageBox.Show("Güncelleme Başarısız");
                }
            }


            //}


            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
            Listele();

        }



        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = db.tbl_cari.Where(r => r.FIRMAADI.Contains(textBox1.Text) || r.tbl_firmaTipi.FIRMATİPİ.Contains(textBox1.Text) || r.IL.Contains(textBox1.Text)).Select(x => new
                {
                    x.IND,
                    x.FIRMAKODU,
                    x.FIRMAADI,
                    x.YETKILI,
                    x.VERGIDAIRESI,
                    x.VERGINO,
                    x.KAYITTARIHI,
                    x.ISKONTO,
                    x.tbl_firmaTipi.FIRMATİPİ,
                    x.tbl_Yetkili.AD,
                    x.tbl_Yetkili.SOYAD,
                    x.UNVAN,
                    x.tbl_sektor.SEKTORADI,
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
                    x.tbl_status.STATUS,
                    x.tbl_Yetkili.DGMTARİH,
                    x.tbl_hizmetturu.HIZMETTURU,
                    x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                    x.tbl_baslangicBitisTarih.BİTİSTARİH,
                    x.tbl_Yetkili.MAIL,
                    x.tbl_Yetkili.TELEFON,



                }).ToList();

            }

        }

        [System.ComponentModel.Browsable(false)]

        public bool Modified { get; set; }
       
   

        private void txtFirmaKod_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Değişiklik yapıldı");
            dataGridView1.Enabled = false;
        }

        
  

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

       


        //if (originalText != textBox1.Text)
        //    // Set the Modified property to true to reflect the change.
        //    textBox1.Modified = true;
        //else
        //    // Contents of textBox1 have not changed, reset the Modified property.
        //    textBox1.Modified = false;





        // Temizleme
        //txtFirmaKod.Clear();
        //txtFirmaAd.Clear();
        //txtYetkili.Clear();
        //comboFirmatipi.Text = "";
        //comboSektor.Text = "";
        //RbAktif.Checked = false;
        //RbPasif.Checked = false;
        //txtSehir.Clear();
        //txtTel.Clear();
        //txtTel2.Clear();
        //txtMail.Clear();
        //txtUrl.Clear();
        //comboHizmetturu.Text = "";
        //txtAdresSevk.Clear();
        //txtAdresFatura.Clear();
        //txtIskonto.Clear();
        //txtVergiDaire.Clear();
        //txtVergiNo.Clear();
        //comboParabirimi.Text = "";
        //txtBaslangıcTarih.Text = DateTime.Now.Date.ToString();
        //txtBitisTarih.Text = DateTime.Now.Date.ToString();
        //txtYetkiliAd.Clear();
        //txtyetkiliSoyadi.Clear();
        //txtYetkiliTel.Clear();
        //txtYetkiliMail.Clear();
        //txtYetkiliDgmTarih.Text = DateTime.Now.Date.ToString();

        //catch
        //{

        //    MessageBox.Show("Kullanıcı Bulunamadı");
        //}
    }
}
/*
txtFirmaKod.Text = (dataGridView1.CurrentRow.Cells[1].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[1].Value.ToString());
txtFirmaAd.Text = (dataGridView1.CurrentRow.Cells[2].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[2].Value.ToString());
txtYetkili.Text = (dataGridView1.CurrentRow.Cells[3].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[3].Value.ToString());
comboFirmatipi.Text = (dataGridView1.CurrentRow.Cells[8].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[8].Value.ToString());
comboSektor.Text = (dataGridView1.CurrentRow.Cells[12].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[12].Value.ToString());
txtSehir.Text = (dataGridView1.CurrentRow.Cells[22].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[22].Value.ToString());
txtTel.Text = (dataGridView1.CurrentRow.Cells[16].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[16].Value.ToString());
txtTel2.Text = (dataGridView1.CurrentRow.Cells[17].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[17].Value.ToString());
txtMail.Text = (dataGridView1.CurrentRow.Cells[14].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[14].Value.ToString());
txtUrl.Text = (dataGridView1.CurrentRow.Cells[15].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[15].Value.ToString());
comboHizmetturu.Text = (dataGridView1.CurrentRow.Cells[26].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[26].Value.ToString());
txtAdresSevk.Text = (dataGridView1.CurrentRow.Cells[19].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[19].Value.ToString());
txtAdresFatura.Text = (dataGridView1.CurrentRow.Cells[18].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[18].Value.ToString());
txtIskonto.Text = (dataGridView1.CurrentRow.Cells[7].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[7].Value.ToString());
txtVergiDaire.Text = (dataGridView1.CurrentRow.Cells[4].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[4].Value.ToString());
txtVergiNo.Text = (dataGridView1.CurrentRow.Cells[5].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[5].Value.ToString());
comboParabirimi.Text = (dataGridView1.CurrentRow.Cells[20].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[20].Value.ToString());
txtBaslangıcTarih.Value = (dataGridView1.CurrentRow.Cells[27].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[27].Value);
txtBitisTarih.Value = (dataGridView1.CurrentRow.Cells[28].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[28].Value);
txtYetkiliAd.Text = (dataGridView1.CurrentRow.Cells[9].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[9].Value.ToString());
txtYetkiliMail.Text = (dataGridView1.CurrentRow.Cells[29].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[29].Value.ToString());
txtYetkiliTel.Text = (dataGridView1.CurrentRow.Cells[30].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[30].Value.ToString());
txtyetkiliSoyadi.Text = (dataGridView1.CurrentRow.Cells[10].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[10].Value.ToString());
txtYetkiliDgmTarih.Value = (dataGridView1.CurrentRow.Cells[25].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[25].Value);
lblind.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());
txtKayitTarih.Value = (dataGridView1.CurrentRow.Cells[6].Value == null) ? DateTime.Now.Date : Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
bool deger = ((dataGridView1.CurrentRow.Cells[24].Value == null) ? true : Convert.ToBoolean((dataGridView1.CurrentRow.Cells[24].Value.ToString())));
textUnvan.Text = (dataGridView1.CurrentRow.Cells[11].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[11].Value.ToString());
*/