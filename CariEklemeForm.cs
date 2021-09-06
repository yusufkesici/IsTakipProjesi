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
    public partial class CariEklemeForm : Form
    {

        /// <summary>
        /// Bu formda cari ekleme işlemleri yapıldı cari eklerken aynı zamanda carideki ilişkili tablolara kendi verileri aktarıldı 
        /// o tablolardan da cari tablosuna aktarıldı
        /// </summary>
        public CariEklemeForm()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void txtEkle_Click(object sender, EventArgs e)
        {
            //////////////////////// TBL CARİ
            tbl_cari cari = new tbl_cari();
            //////////////////////// tbl status 
            tbl_status statuss = new tbl_status();
            statuss = db.tbl_status.Where(x => x.STATUS == true).FirstOrDefault();
            tbl_status statuss2 = new tbl_status();
            statuss2 = db.tbl_status.Where(x => x.STATUS == false).FirstOrDefault();
            ////////////////////////tbl firmatipi
            tbl_firmaTipi firmarTipi = new tbl_firmaTipi();
            firmarTipi = db.tbl_firmaTipi.Where(x => x.FIRMATİPİ == comboFirmaTip.Text).FirstOrDefault();
            ///////////////////////tbl sektor
            tbl_sektor sektör = new tbl_sektor();
            sektör = db.tbl_sektor.Where(x => x.SEKTORADI == comboSektor.Text).FirstOrDefault();
            //////////////////////tbl hizmetTürü
            tbl_hizmetturu hizmetturu = new tbl_hizmetturu();
            hizmetturu = db.tbl_hizmetturu.Where(x => x.HIZMETTURU == comboHizmetturu.Text).FirstOrDefault();

            tbl_personel personel = new tbl_personel();
            personel = db.tbl_personel.Where(x => x.PERSONELAD == txtPerAd.Text && x.PERSONELSOYAD == txtPersoyad.Text).FirstOrDefault();
            if (personel == null)
            {
                MessageBox.Show("Personel Bulunamadı");
                return;
            }

            //YETKİLİ BOŞ GELİRSE DEFAULT DEĞER ATADIK

            tbl_yorum yorum = new tbl_yorum();
            db.tbl_yorum.Add(yorum);

            //bu kısımda yetkilinin bilgilerini aldık eğer girilen bilgilerdeki ad,soyad,telno,veri tabanında bir kişiye sahipse sistem
            //bize mesaj gösterir yetkilinin sisteme kayıtlı olduğuna dair.

            tbl_Yetkili yetkili1 = new tbl_Yetkili();
            if (txtYetkiliAd.Text!=""&&txtYetkiliSoyad.Text!=""&&txtYetkiliTel.Text!= "(   )    -")
            {               
                yetkili1.AD = txtYetkiliAd.Text.ToUpper();
                yetkili1.SOYAD = txtYetkiliSoyad.Text.ToUpper();
                yetkili1.TELEFON = txtYetkiliTel.Text;
                yetkili1.MAIL = txtMail.Text;
                yetkili1.DGMTARİH = ((txtYetkiliDgmTarih.Text) == "") ? DateTime.Now : Convert.ToDateTime(txtYetkiliDgmTarih.Text);
            }
            else
            {
                MessageBox.Show("Yetkili Bilgileri Boş Bırakılamaz!!");
                return;
            }    
  

            //  CARİ EKLERKEN BURADA YETKİLİ İÇİN GİRİLEN VERİLER YETKİLİ TABLOSUNDA VAR MI KONTROLU YAPILIYOR YOKSA 0 OLARAK
            //DEĞER VERDİĞİMİZ ID HALA 0 SA ADD YAPIYOR TBL YE VARSA O HANGİ YETKLİYSE İND SİNİ İD YE ATIYORUZ AŞAĞIDADA O YETKİLİYİ
            //OLUŞTURULAN CARİYE EKLİYORUZ
            int id = 0;
            foreach (tbl_Yetkili tbl_Yetkili in db.tbl_Yetkili)
            {
                
                if (tbl_Yetkili.TELEFON == yetkili1.TELEFON&&tbl_Yetkili.AD==yetkili1.AD&&tbl_Yetkili.SOYAD==yetkili1.SOYAD)
                {
                    MessageBox.Show("Yetkili Zaten Sistemde Kayıtlı");
                   id = tbl_Yetkili.IND;
                   
                }       
            }
            if (id==0){
                db.tbl_Yetkili.Add(yetkili1);
                db.SaveChanges();
            }

            tbl_baslangicBitisTarih baslangicBitisTarih = new tbl_baslangicBitisTarih();

            baslangicBitisTarih.BASLANGICTARİH= (txtBaslangıcTarih.Text == "") ? DateTime.Now:Convert.ToDateTime(txtBaslangıcTarih.Text);
            baslangicBitisTarih.BİTİSTARİH = (txtBitisTarih.Text == "") ? DateTime.Now : Convert.ToDateTime(txtBitisTarih.Text);
          

            db.tbl_baslangicBitisTarih.Add(baslangicBitisTarih);
            db.SaveChanges();

            cari.FIRMAADI = txtFirmaAdi.Text;
            cari.FIRMAKODU = txtFirmaKodu.Text;
            cari.tbl_firmaTipi = firmarTipi;
            cari.tbl_sektor = sektör;
            cari.IL = txtSehir.Text;
            cari.TELEFON1 = txtTel.Text;
            cari.TELEFON2 = txtTel2.Text;
            cari.EMAIL = txtMail.Text;
            cari.URL = txtUrl.Text;
            cari.tbl_hizmetturu = hizmetturu;
            cari.ADRESFATURA = txtAdresFatura.Text;
            cari.ADRESSEVK = txtAdresSevk.Text;
            cari.ISKONTO = ( (txtIskonto.Text=="")?0:(Convert.ToInt32( txtIskonto.Text)));
            cari.VERGIDAIRESI = txtVergiDaire.Text;
            cari.VERGINO = txtVergiNo.Text;
            cari.PARABIRIMI = comboPara.Text;
            cari.KAYITTARIHI = DateTime.Now;
            cari.BASBITTAR = baslangicBitisTarih.IND;
            cari.UNVAN = txtUnvan.Text;
            cari.PERSONELNO = personel.IND;
            cari.PersonelYorum = yorum.IND;
            
            if (radioAktif.Checked==true) cari.tbl_status=statuss ;
            if (radioPasif.Checked==true) cari.tbl_status=statuss2 ;

            //OLUŞTURDUĞUMUZ YETKİLİYİ CARİYE EKLİYORUZ CARİ DE İND İSTİYOR O YÜZDEN YETKİLİNİN IND Sİ VERİYORUZ

            cari.YETKILI = yetkili1.IND;

            if (id != 0)
            {
                cari.YETKILI = id;
            }


            db.tbl_cari.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Cari Ekleme Başarılı");
        }

        private void CariEklemeForm_Load(object sender, EventArgs e)
        {
            foreach (tbl_firmaTipi firmaTipi in db.tbl_firmaTipi)
            {
                comboFirmaTip.Items.Add(firmaTipi.FIRMATİPİ);
            }
            foreach (tbl_hizmetturu hizmetturu in db.tbl_hizmetturu)
            {
                comboHizmetturu.Items.Add(hizmetturu.HIZMETTURU);
            }
            foreach (tbl_sektor sektor in db.tbl_sektor)
            {
                comboSektor.Items.Add(sektor.SEKTORADI);
            }
            foreach (tbl_personel personel in db.tbl_personel)
            {
                comboPersonel.Items.Add(personel.PERSONELAD+" "+personel.PERSONELSOYAD);
            }
        }

        private void txtYetkiliTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_personel personel = db.tbl_personel.Where(x => x.PERSONELAD + " " + x.PERSONELSOYAD == comboPersonel.Text).FirstOrDefault();

            txtPerAd.Text = personel.PERSONELAD;
            txtPersoyad.Text = personel.PERSONELSOYAD;
            txtPerEmail.Text = personel.PERSONELMAİL;
            txtPerTc.Text = personel.PERSONELTC;
            txtPerTel.Text = personel.PERSONELTEL;
            txtPerAdres.Text = personel.PERSONELADRES;
        }



        //private void txtYetkiliTel_Click(object sender, EventArgs e)
        //{
        //    txtYetkiliTel.SelectionStart = txtYetkiliTel.Text.TrimEnd().Length;
        //}
    }
}
