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
    public partial class AnasayfaFrm : Form
    {
        stajyerEntities3 db = new stajyerEntities3();

        public AnasayfaFrm()
        {
            InitializeComponent();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FrmAra frm = new FrmAra(this);
            frm.Show();
        }

        private void AnasayfaFrm_Load(object sender, EventArgs e)
        {

        }
        //public void GetirId(tbl_cari cari, int firmano)
        //{
        //    if (cari != null && firmano.ToString() != "")
        //    {

        //        cari = db.tbl_cari.Where(x => x.IND == firmano).FirstOrDefault();


        //        txtYetkili.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD)) + " " + ((cari.tbl_Yetkili == null) ? "" : (cari.tbl_Yetkili.SOYAD));


        //        txtFirmaAd.Text = cari.FIRMAADI;
        //        txtFirmaKod.Text = cari.FIRMAKODU;
        //        txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
        //        txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
        //        {
        //            RbAktif.Checked = true;
        //        }
        //        else
        //        {
        //            RbAktif.Checked = false;
        //        }
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
        //        {
        //            RbPasif.Checked = true;
        //        }
        //        else
        //        {
        //            RbPasif.Checked = false;
        //        }


        //        txtSehir.Text = cari.SEHIR;
        //        txtTel.Text = cari.TELEFON1;
        //        txtTel2.Text = cari.TELEFON2;
        //        txtMail.Text = cari.EMAIL;
        //        txtUrl.Text = cari.URL;
        //        txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
        //        txtAdresFatura.Text = cari.ADRESFATURA;
        //        txtAdresSevk.Text = cari.ADRESSEVK;
        //        txtIskonto.Text = cari.ISKONTO.ToString();
        //        txtVergiDaire.Text = cari.VERGIDAIRESI;
        //        txtVergiNo.Text = cari.VERGINO;
        //        txtParaBirim.Text = cari.PARABIRIMI;
        //        txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
        //        txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
        //        txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
        //        txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.SOYAD));
        //        txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
        //        txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
        //        txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
        //        txtKayitTarih.Text = cari.KAYITTARIHI.ToString();
        //        txtPerAd.Text = cari.tbl_personel.PERSONELAD;
        //        txtPersoyad.Text = cari.tbl_personel.PERSONELSOYAD;
        //        txtPerTc.Text = cari.tbl_personel.PERSONELTC;
        //        txtPerTel.Text = cari.tbl_personel.PERSONELTEL;
        //        txtPerEmail.Text = cari.tbl_personel.PERSONELMAİL;
        //        txtPerAdres.Text = cari.tbl_personel.PERSONELADRES;



        //    }

        //    else
        //    {
        //        MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        //public void GetirFirmaAdi(tbl_cari cari, string firmaAdi)
        //{
        //    if (cari != null && firmaAdi != "")
        //    {

        //        cari = db.tbl_cari.Where(x => x.FIRMAADI == firmaAdi).FirstOrDefault();


        //        txtYetkili.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD)) + " " + ((cari.tbl_Yetkili == null) ? "" : (cari.tbl_Yetkili.SOYAD));


        //        txtFirmaAd.Text = cari.FIRMAADI;
        //        txtFirmaKod.Text = cari.FIRMAKODU;
        //        txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
        //        txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
        //        {
        //            RbAktif.Checked = true;
        //        }
        //        else
        //        {
        //            RbAktif.Checked = false;
        //        }
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
        //        {
        //            RbPasif.Checked = true;
        //        }
        //        else
        //        {
        //            RbPasif.Checked = false;
        //        }


        //        txtSehir.Text = cari.SEHIR;
        //        txtTel.Text = cari.TELEFON1;
        //        txtTel2.Text = cari.TELEFON2;
        //        txtMail.Text = cari.EMAIL;
        //        txtUrl.Text = cari.URL;
        //        txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
        //        txtAdresFatura.Text = cari.ADRESFATURA;
        //        txtAdresSevk.Text = cari.ADRESSEVK;
        //        txtIskonto.Text = cari.ISKONTO.ToString();
        //        txtVergiDaire.Text = cari.VERGIDAIRESI;
        //        txtVergiNo.Text = cari.VERGINO;
        //        txtParaBirim.Text = cari.PARABIRIMI;
        //        txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
        //        txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
        //        txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
        //        txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
        //        txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
        //        txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
        //        txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
        //        txtKayitTarih.Text = cari.KAYITTARIHI.ToString();



        //    }

        //    else
        //    {
        //        MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}
        //public void GetirlYetkiliAdSoyad(tbl_cari cari, string YetkiliAdSoyad)
        //{
        //    if (cari != null && YetkiliAdSoyad != "")
        //    {

        //        cari = db.tbl_cari.Where(x => (x.tbl_Yetkili.AD + " " + x.tbl_Yetkili.SOYAD) == YetkiliAdSoyad).FirstOrDefault();


        //        txtYetkili.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD)) + " " + ((cari.tbl_Yetkili == null) ? "" : (cari.tbl_Yetkili.SOYAD));


        //        txtFirmaAd.Text = cari.FIRMAADI;
        //        txtFirmaKod.Text = cari.FIRMAKODU;
        //        txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
        //        txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
        //        {
        //            RbAktif.Checked = true;
        //        }
        //        else
        //        {
        //            RbAktif.Checked = false;
        //        }
        //        if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
        //        {
        //            RbPasif.Checked = true;
        //        }
        //        else
        //        {
        //            RbPasif.Checked = false;
        //        }


        //        txtSehir.Text = cari.SEHIR;
        //        txtTel.Text = cari.TELEFON1;
        //        txtTel2.Text = cari.TELEFON2;
        //        txtMail.Text = cari.EMAIL;
        //        txtUrl.Text = cari.URL;
        //        txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
        //        txtAdresFatura.Text = cari.ADRESFATURA;
        //        txtAdresSevk.Text = cari.ADRESSEVK;
        //        txtIskonto.Text = cari.ISKONTO.ToString();
        //        txtVergiDaire.Text = cari.VERGIDAIRESI;
        //        txtVergiNo.Text = cari.VERGINO;
        //        txtParaBirim.Text = cari.PARABIRIMI;
        //        txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
        //        txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
        //        txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
        //        txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
        //        txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
        //        txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
        //        txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
        //        txtKayitTarih.Text = cari.KAYITTARIHI.ToString();



        //    }

        //    else
        //    {
        //        MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}



        public void GetirCariAra(tbl_cari cari, int firmano = 0, string YetkiliAdSoyad = "bilinmiyor", string firmaAdi = "bilinmiyor")
        {
            if (cari != null)
            {
                
                if (firmano != 0)
                {
                    int id = Convert.ToInt32(firmano);
                    cari = db.tbl_cari.Where(x => x.IND == id).FirstOrDefault();
                }
                else if (YetkiliAdSoyad != "bilinmiyor")
                {
                    cari = db.tbl_cari.Where(x => x.tbl_Yetkili.AD + " " + x.tbl_Yetkili.SOYAD == YetkiliAdSoyad || x.FIRMAADI == YetkiliAdSoyad).FirstOrDefault();
                }
                //else if (firmaAdi != "bilinmiyor")
                //{
                //    cari = db.tbl_cari.Where(x => x.FIRMAADI == firmaAdi).FirstOrDefault();
                //}



                txtFirmaAd.Text = cari.FIRMAADI;
                txtFirmaKod.Text = cari.FIRMAKODU;
                txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
                txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
                {
                    RbAktif.Checked = true;
                }
                else
                {
                    RbAktif.Checked = false;
                }
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
                {
                    RbPasif.Checked = true;
                }
                else
                {
                    RbPasif.Checked = false;
                }

                CariINDD.Text = cari.IND.ToString();
                txtSehir.Text = cari.SEHIR;
                txtTel.Text = cari.TELEFON1;
                txtTel2.Text = cari.TELEFON2;
                txtMail.Text = cari.EMAIL;
                txtUrl.Text = cari.URL;
                txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
                txtAdresFatura.Text = cari.ADRESFATURA;
                txtAdresSevk.Text = cari.ADRESSEVK;
                txtIskonto.Text = cari.ISKONTO.ToString();
                txtVergiDaire.Text = cari.VERGIDAIRESI;
                txtVergiNo.Text = cari.VERGINO;
                txtParaBirim.Text = cari.PARABIRIMI;
                txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.SOYAD));
                txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
                txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
                txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
                txtKayitTarih.Text = cari.KAYITTARIHI.ToString();
                txtPerAd.Text = cari.tbl_personel.PERSONELAD;
                txtPersoyad.Text = cari.tbl_personel.PERSONELSOYAD;
                txtPerTc.Text = cari.tbl_personel.PERSONELTC;
                txtPerTel.Text = cari.tbl_personel.PERSONELTEL;
                txtPerEmail.Text = cari.tbl_personel.PERSONELMAİL;
                txtPerAdres.Text = cari.tbl_personel.PERSONELADRES;
                txtArızaTuru.Text = cari.tbl_Ariza.ArizaTür;
                txtAldıgı.Text = cari.tbl_Ariza.MusteriAldigiHizmet;
                txtOnarimSuresi.Text = cari.tbl_Ariza.OnarimSüresi;
                txtArizaTanim.Text = cari.tbl_Ariza.ArızaTanim;
                txtGidilenServis.Text = db.tbl_Ariza.Where(x => x.CariID == cari.IND).Count().ToString();
                txtUrunTuru.Text = cari.tbl_Ariza.UrunTuru;
                //tbl_Ariza ariza = db.tbl_Ariza.Where(x => x.CariID == cari.IND).FirstOrDefault();
                //arizaKayıt.Text = ariza.ArizaKayitTarih.ToString();

            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TümArızaKayıtları frm = new TümArızaKayıtları(this);
            frm.Show();
        }
    }
}
