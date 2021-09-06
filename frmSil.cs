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
    public partial class frmSil : Form
    {
        public frmSil()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        private void frmSil_Load(object sender, EventArgs e)
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
                x.ADI,
                x.SOYAD,
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
                x.YETKİLİDGMTARİH,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).ToList();


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //try
            //{
            int a = int.Parse(textBox1.Text);
            if (textBox1.Text != null)
            {


                var sil = db.tbl_cari.Where(w => w.IND == a).FirstOrDefault();

                tbl_cari cari = db.tbl_cari.Find(sil.IND);

                tbl_baslangicBitisTarih baslangicBitisTarih = new tbl_baslangicBitisTarih();
                baslangicBitisTarih = db.tbl_baslangicBitisTarih.Find(cari.BASBITTAR);
                db.tbl_baslangicBitisTarih.Remove(baslangicBitisTarih);
                db.tbl_cari.Remove(sil);
                db.SaveChanges();
                frmSil_Load(sender, e);
            }

            //}
            //catch
            //{

            //    MessageBox.Show("Kayıt Bulunamadı");
            //}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYetkili.Text = (dataGridView1.CurrentRow.Cells[3].Value) == null ? "YOK" : (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtFirmaKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFirmaTip.Text = (dataGridView1.CurrentRow.Cells[8].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[8].Value.ToString());
            txtSektor.Text = (dataGridView1.CurrentRow.Cells[12].Value) == null ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[12].Value.ToString());





            bool deger = ((dataGridView1.CurrentRow.Cells[24].Value == null) ? true : Convert.ToBoolean((dataGridView1.CurrentRow.Cells[24].Value.ToString())));

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

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dataGridView1.DataSource = db.tbl_cari.Where(r => r.FIRMAADI.Contains(textBox3.Text) || r.ADI.Contains(textBox3.Text)).Select(x => new
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
                    x.ADI,
                    x.SOYAD,
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
                    x.YETKİLİDGMTARİH,
                    x.tbl_hizmetturu.HIZMETTURU,
                    x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                    x.tbl_baslangicBitisTarih.BİTİSTARİH
                }).ToList();
            }
        }
    }
}
