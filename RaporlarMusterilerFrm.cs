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
    public partial class RaporlarMusterilerFrm : Form
    {
        public RaporlarMusterilerFrm()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_Yetkili.Select(x => new
            {
                x.IND,
                x.AD,
                x.SOYAD,

                x.TELEFON,
                x.MAIL,
                x.DGMTARİH
            }).ToList();
        }
        public void Ara() {
            string adsoyad = textBox1.Text;
            dataGridView1.DataSource = db.tbl_Yetkili.Select(x => new
            {
                x.IND,
                x.AD,
                x.SOYAD,
                x.TELEFON,
                x.MAIL,
                x.DGMTARİH
            }).Where(x => (x.AD + " " + x.SOYAD).Contains(adsoyad)).ToList();
        }
        private void RaporlarMusterilerFrm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ara();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_Yetkili yetkili = new tbl_Yetkili();
            int id = Convert.ToInt16(txtSil.Text);
            yetkili = db.tbl_Yetkili.Find(id);

            if (yetkili != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Yetkili Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.tbl_Yetkili.Remove(yetkili);

                    //  tbl_cari tbl_Cari = db.tbl_cari.Where(x => x.YETKILI == yetkili.IND).FirstOrDefault();
                    try
                    {
                        db.SaveChanges();
                        RaporlarMusterilerFrm_Load(sender, e);
                    }
                    catch (Exception)
                    {

                        // MessageBox.Show("Seçilen Yetkilinin Caride Kaydı Mevcut !!", "Uyarı", MessageBoxButtons.OK);
                        DialogResult dialog2 = new DialogResult();
                        dialog2 = MessageBox.Show("Seçilen Yetkilinin Caride Kaydı Mevcut Carileri İle Beraber Silinsin Mi ?", "Uyarı", MessageBoxButtons.YesNo);
                        if (dialog2 == DialogResult.Yes)
                        {


                            foreach (tbl_cari tbl_Cari in db.tbl_cari)
                            {
                                if (tbl_Cari.YETKILI == yetkili.IND)
                                {
                                    db.tbl_cari.Remove(tbl_Cari);
                                }
                            }

                        }
                        else
                        {
                            return;
                        }



                        MessageBox.Show("Yetkili Cari Kayıtlari İle Beraber Silindi !");
                        db.SaveChanges();
                        Listele();
                    }

                }

                else
                {
                    return;
                }

            }

            else
            {
                MessageBox.Show("İd Bulunamadı");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ara();
            }
        }
    }
}

