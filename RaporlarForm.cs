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
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.IND,
                x.FIRMAADI,
                x.VERGINO,
                x.tbl_firmaTipi.FIRMATİPİ,
                x.tbl_sektor.SEKTORADI,
                x.tbl_hizmetturu.HIZMETTURU,
                x.TELEFON1,
                x.EMAIL,
                x.IL,
                x.tbl_Yetkili.AD,
                x.tbl_Yetkili.SOYAD,
                x.tbl_personel.PERSONELAD,
                x.tbl_personel.PERSONELSOYAD,

                x.tbl_status.STATUS,
                x.KAYITTARIHI,

            }).ToList();

        }
        public void Ara()
        {
            string ad = txtCariAra.Text;

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
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.FIRMAADI.Contains(ad)).ToList();
        }
        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            foreach (tbl_sektor sektor in db.tbl_sektor)
            {
                comboSektor.Items.Add(sektor.SEKTORADI);
            }
            foreach (tbl_firmaTipi firmaTipi in db.tbl_firmaTipi)
            {
                comboFirmaTip.Items.Add(firmaTipi.FIRMATİPİ);
            }
            foreach (tbl_status status in db.tbl_status)
            {
                comboDurum.Items.Add(status.STATUS);
            }

            Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ara();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_cari cari = new tbl_cari();
            int id = Convert.ToInt16(txtSil.Text);
            cari = db.tbl_cari.Find(id);

            tbl_baslangicBitisTarih baslangicBitisTarih = db.tbl_baslangicBitisTarih.Find(cari.BASBITTAR);

            if (cari != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Cari Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.tbl_cari.Remove(cari);
                    db.tbl_baslangicBitisTarih.Remove(baslangicBitisTarih);
                    db.SaveChanges();
                    RaporlarForm_Load(sender, e);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("İd Bulunamadı");
            }
        }

        private void txtCariAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ara();
            }
        }

        #region Filtreleme
        public void FiltreFirmaTip()
        {
            string ad = comboFirmaTip.Text;

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
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.FIRMATİPİ.Contains(ad)).ToList();
        }
        public void FiltreSektor()
        {
            string ad = comboSektor.Text;

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
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.SEKTORADI.Contains(ad)).ToList();
        }
        public void FiltreTipSektor()
        {
            string sektor = comboSektor.Text;
            string firmatip = comboFirmaTip.Text;

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
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.SEKTORADI.Contains(sektor)&&x.FIRMATİPİ.Contains(firmatip)).ToList();
        }
        private void comboFirmaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSektor.Text == "")
            {
                FiltreFirmaTip();
            }
            else
            {
                FiltreTipSektor();
            }
           
        }

        private void comboSektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFirmaTip.Text == "")
            {
                FiltreSektor();

            }
            else
            {

                FiltreTipSektor();
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ad = Convert.ToBoolean(comboDurum.Text);

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
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.STATUS == ad).ToList();
        }

        #endregion


    }
}



