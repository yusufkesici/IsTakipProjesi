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
    public partial class ArızaAnaForm : Form
    {
        public ArızaAnaForm()
        {
            InitializeComponent();
        }

        stajyerEntities3 db = new stajyerEntities3();

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_Ariza.Select(x => new { x.IND, Müşteri = (x.MusteriAd + " " + x.MusteriSoyad), Personel = (x.tbl_personel.PERSONELAD + " " + x.tbl_personel.PERSONELSOYAD), x.ArizaKayitTarih, ArızaTürü = x.ArizaTür, x.ArızaTanim, Durum = x.Durum.Value }).ToList();
            dataGridView1.Columns["IND"].Visible = false;
        }
        private void ArızaAnaForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnArizaKayit_Click(object sender, EventArgs e)
        {
            ArızaEkle frm = new ArızaEkle(this);
            frm.Show();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            ArizaDetayForm frm = new ArizaDetayForm(this);
            frm.Show();
        }
      public  int id;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string musteri = row.Cells[1].Value.ToString();
                 id = Convert.ToInt32(row.Cells[0].Value);
                tbl_Ariza ariza = db.tbl_Ariza.Find(id);

                txtMusteri.Text = musteri;
                txtArizaTanim.Text = ariza.ArızaTanim;
                if (ariza.Durum == true)
                {
                    btnArizaKapat.Visible = false;
                }
                else
                {
                    btnArizaKapat.Visible = true;
                }
            }
            
        }

        private void btnArizaKapat_Click(object sender, EventArgs e)
        {

            tbl_Ariza ariza = db.tbl_Ariza.Find(id);
            ariza.Durum = true;
            


            DialogResult dialogResult = MessageBox.Show("Arıza Kaydı Kapatılacak Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                db.SaveChanges();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


         
            Listele();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = db.tbl_Ariza.Select(x => new { x.IND, Müşteri = (x.MusteriAd + " " + x.MusteriSoyad), Personel = (x.tbl_personel.PERSONELAD + " " + x.tbl_personel.PERSONELSOYAD), x.ArizaKayitTarih, ArızaTürü = x.ArizaTür, x.ArızaTanim, Durum = x.Durum.Value })
                    .Where(x => x.Müşteri.Contains( textBox1.Text)||x.Personel.Contains(textBox1.Text)).ToList();
            }
        }

       
    }
}
