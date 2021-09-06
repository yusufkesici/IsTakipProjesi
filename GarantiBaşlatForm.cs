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
    public partial class GarantiBaşlatForm : Form
    {
        stajyerEntities3 db = new stajyerEntities3();
        GarantiDurumFrm Form;
       

        public GarantiBaşlatForm(GarantiDurumFrm form)
        {
            
            InitializeComponent();
            Form = form;
        }

       public string butonKontrol()
        {
            String a = "";
            return a;
        }

        private void GarantiBaşlatForm_Load(object sender, EventArgs e)
        {
            


            if (Form.btnGarantiBaslat.Text== "Garantiyi/Hizmeti Başlat")
            {
                btnGarantiYeniden.Visible = false;
                txtGarantiBaslat.Visible = true;
            }

            else if (Form.btnGarantiBaslat.Text == "Garantiyi/Hizmeti Yeniden Başlat")
            {
                btnGarantiYeniden.Visible = true;
                txtGarantiBaslat.Visible = false;
            }


            txtid.Text = Form.Getir2().ToString();
           
            tbl_cari carri = new tbl_cari();
            
            carri = db.tbl_cari.Find(Form.Getir2());
           
            txtFirmaAdı.Text = carri.FIRMAADI;


            txtBasbitTut.Text = Form.Getir4().ToString();
           

           
           
        }

        private void txtGarantiBaslat_Click(object sender, EventArgs e)
        {
            //eğer null gelirse veri tabanındaki basbit tablosu onu önce doldurup sonra cariye ekliyip çağırıyoruz.

            //butona basınca datagridden secilen rowun verileri gelicek burda
            int id = Convert.ToInt32(txtid.Text);

            tbl_baslangicBitisTarih tbl_BaslangicBitisTarih = new tbl_baslangicBitisTarih();
            tbl_BaslangicBitisTarih.BASLANGICTARİH= Convert.ToDateTime(txtBaslangıc.Text);
            tbl_BaslangicBitisTarih.BİTİSTARİH= Convert.ToDateTime(txtBitis.Text);
            db.tbl_baslangicBitisTarih.Add(tbl_BaslangicBitisTarih);
            db.SaveChanges();
            int idTarihtbl = tbl_BaslangicBitisTarih.IND;
            txtBasbitTut.Text = idTarihtbl.ToString();

            tbl_baslangicBitisTarih tarih = db.tbl_baslangicBitisTarih.Find(idTarihtbl);
            tbl_cari cari = db.tbl_cari.Find(id);
            cari.tbl_baslangicBitisTarih = tarih;

            cari.tbl_baslangicBitisTarih.BASLANGICTARİH = tarih.BASLANGICTARİH;
            cari.tbl_baslangicBitisTarih.BİTİSTARİH = tarih.BİTİSTARİH;
            db.SaveChanges();
            MessageBox.Show("Garanti Başlatıldı");

            ////////////////////////////////////////////////////
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int id = Convert.ToInt32(txtid.Text);
            int idTblTarih = Convert.ToInt32(txtBasbitTut.Text);

            tbl_baslangicBitisTarih tbl_BaslangicBitisTarih = db.tbl_baslangicBitisTarih.Find(idTblTarih);
            tbl_BaslangicBitisTarih.BASLANGICTARİH = Convert.ToDateTime(txtBaslangıc.Text);
            tbl_BaslangicBitisTarih.BİTİSTARİH = Convert.ToDateTime(txtBitis.Text);
            db.SaveChanges();


            tbl_baslangicBitisTarih tarih = db.tbl_baslangicBitisTarih.Find(idTblTarih);
            tbl_cari cari = db.tbl_cari.Find(id);
            cari.tbl_baslangicBitisTarih = tarih;

            cari.tbl_baslangicBitisTarih.BASLANGICTARİH = tarih.BASLANGICTARİH;
            cari.tbl_baslangicBitisTarih.BİTİSTARİH = tarih.BİTİSTARİH;
            db.SaveChanges();
            MessageBox.Show("Garanti Yeniden Başlatıldı"); 
        }
    }
}
