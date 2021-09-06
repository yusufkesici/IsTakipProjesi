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
    public partial class ArızaEkle : Form
    {
        ArızaAnaForm Form;
        public ArızaEkle(ArızaAnaForm frm)
        {
            Form = frm;
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void ArızaEkle_Load(object sender, EventArgs e)
        {
            foreach (tbl_personel item in db.tbl_personel)
            {
                comboPersonel.Items.Add(item.PERSONELAD + " " + item.PERSONELSOYAD);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_Ariza ariza = new tbl_Ariza();



            ariza.MusteriAd = txtMusteriAd.Text;
            ariza.MusteriSoyad = txtMusteriSoyad.Text;
            ariza.MusteriTelefon = txtTel.Text;
            ariza.OnarimSüresi = txtOnarimSuresi.Text;
            ariza.MusteriAdres = txtAdres.Text;
            ariza.ArızaTanim = txtArizaTanim.Text;
            ariza.MusteriAldigiHizmet = comboAldigiHizmet.Text;

            tbl_personel personel = db.tbl_personel.Where(x => x.PERSONELAD + " " + x.PERSONELSOYAD == comboPersonel.Text).FirstOrDefault();
            if (personel == null)
            {
                MessageBox.Show("Lütfen Personel Atayınız");
                return;
            }
            ariza.PersonelID = personel.IND;


            ariza.ArizaTür = comboTür.Text;
            ariza.UrunTuru = comboUrunTür.Text;
            ariza.Durum = false;
            ariza.ArizaKayitTarih = Convert.ToDateTime(arizaKayıt.Text);
            db.tbl_Ariza.Add(ariza);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Eklendi");
            Form.Listele();
        }
    }
}
