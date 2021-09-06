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
    public partial class GarantiDurumFrm : Form
    {

        public GarantiDurumFrm()
        {

            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        public void DatagridList()
        {
            var datacari = db.tbl_cari.Select(a => new { a.IND, a.FIRMAADI, a.tbl_hizmetturu.HIZMETTURU, a.tbl_baslangicBitisTarih.BASLANGICTARİH, a.tbl_baslangicBitisTarih.BİTİSTARİH }).ToList();

            dataGridView1.DataSource = datacari;

        }
        private void GarantiDurumFrm_Load(object sender, EventArgs e)
        {
            btnGarantiBaslat.Visible = false;
            DatagridList();

            foreach (var hizmetturu in db.tbl_hizmetturu)
            {
                comboHizmetler.Items.Add(hizmetturu.HIZMETTURU);
            }
        }


        private void btnGarantiBaslat_Click(object sender, EventArgs e)
        {


            GarantiBaşlatForm frm = new GarantiBaşlatForm(this);

            frm.Show();


        }


        public string GarantiYenidenBaslat()
        {

            return btnGarantiBaslat.Text;
        }
        public List<string> Getir3()
        {// garantisi bitmek üzere olanların listesi döndürüyor bu metot mdı load olunca metotu çağırdım orda çalışıyor
            List<String> rapor = new List<string>();
            foreach (var cari in db.tbl_cari)
            {
                string baslangıc = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                string bitis = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                string cariiii = cari.FIRMAADI;
                if (baslangıc != "" && bitis != "")
                {

                    TimeSpan fark, basladimi;
                    DateTime bugunTarih = DateTime.Now.Date;
                    DateTime kücükTarih = DateTime.Now.Date;
                    DateTime büyükTarih = Convert.ToDateTime(bitis);
                    fark = (büyükTarih - kücükTarih);
                    String sonuc = fark.TotalDays.ToString();
                    basladimi = (bugunTarih - Convert.ToDateTime(baslangıc));
                    int buFark = Convert.ToInt32(sonuc);
                    if (basladimi.TotalDays >= 0)
                    {
                        if (buFark < 10 && buFark > 0)
                        {


                            rapor.Add(cariiii + " Adlı Firmanın Garanti/Hizmet Bitimine Kalan Gün " + sonuc);

                            //MessageBox.Show(cariiii +" Adlı Firmanın Garanti/Hizmet Bitimine Kalan Gün "+ sonuc,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }


                }

            }
            return rapor;
        }
        public List<tbl_cari> GetirGBÜO()
        {// garantisi bitmek üzere olanların listesi döndürüyor bu metot mdı load olunca metotu çağırdım orda çalışıyor
            List<tbl_cari> rapor = new List<tbl_cari>();
            
            foreach (tbl_cari cari in db.tbl_cari)
            {
                string baslangıc = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                string bitis = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                string cariiii = cari.FIRMAADI;
                if (baslangıc != "" && bitis != "")
                {

                    TimeSpan fark, basladimi;
                    DateTime bugunTarih = DateTime.Now.Date;
                    DateTime kücükTarih = DateTime.Now.Date;
                    DateTime büyükTarih = Convert.ToDateTime(bitis);
                    fark = (büyükTarih - kücükTarih);
                    String sonuc = fark.TotalDays.ToString();
                    basladimi = (bugunTarih - Convert.ToDateTime(baslangıc));
                    int buFark = Convert.ToInt32(sonuc);
                    if (basladimi.TotalDays >= 0)
                    {
                        if (buFark < 10 && buFark > 0)
                        {
                            rapor.Add(cari);

                            // rapor.Add(cariiii + " Adlı Firmanın Garanti/Hizmet Bitimine Kalan Gün " + sonuc);

                            //MessageBox.Show(cariiii +" Adlı Firmanın Garanti/Hizmet Bitimine Kalan Gün "+ sonuc,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        
                    }


                }

            }
            return rapor;
        }
        public List<tbl_cari> GetirGrntBiten()
        {// garantisi bitmek üzere olanların listesi döndürüyor bu metot mdı load olunca metotu çağırdım orda çalışıyor
            List<tbl_cari> rapor = new List<tbl_cari>();
            List<tbl_cari> rapor2 = new List<tbl_cari>();
            foreach (tbl_cari cari in db.tbl_cari)
            {
                string baslangıc = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                string bitis = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                string cariiii = cari.FIRMAADI;
                if (baslangıc != "" && bitis != "")
                {

                    TimeSpan fark, basladimi,bittimi;
                    DateTime bugunTarih = DateTime.Now.Date;
                    DateTime kücükTarih = DateTime.Now.Date;
                    DateTime büyükTarih = Convert.ToDateTime(bitis);
                    fark = (büyükTarih - kücükTarih);
                    String sonuc = fark.TotalDays.ToString();
                    basladimi = (bugunTarih - Convert.ToDateTime(baslangıc));
                    bittimi = (bugunTarih - büyükTarih);
                    int buFark = Convert.ToInt32(sonuc);
                    
                       if(bittimi.TotalDays > 0)
                        {
                            rapor2.Add(cari);
                        }
                    


                }

            }
            return rapor2;
        }
        private void txtBit_ValueChanged(object sender, EventArgs e)
        { //bitisTarihi change olunca baslangıç ile arasındaki farkı burda buluyorum

            TimeSpan fark;
            DateTime kücükTarih = Convert.ToDateTime(txtBas.Text);
            DateTime büyükTarih = Convert.ToDateTime(txtBit.Text);
            fark = (büyükTarih - kücükTarih);
            txtFark.Text = fark.TotalDays.ToString();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int icari = Convert.ToInt32(row.Cells[0].Value);

                tbl_cari tblcari = db.tbl_cari.Find(icari);
                int basbitTutucu = (tblcari.tbl_baslangicBitisTarih == null) ? 0 : (tblcari.tbl_baslangicBitisTarih.IND);



                //TBL CARİDE BASBİT NULL DEĞER GELİRSE DİYE ÖNLEM ALDIK ALMASAKDA OLUR ÇÜNKÜ CARİ EKLERKEN  NULL BIRAKIR İSE BUGÜNÜN TARİHİNİ VERİYORUM TBL_BASLANGIÇBİTİS E
                //ORDAN CARİYE ÇEKİYORUM

                DateTime bastar = (tblcari.tbl_baslangicBitisTarih == null) ? DateTime.Now : (tblcari.tbl_baslangicBitisTarih.BASLANGICTARİH ?? DateTime.Now.Date);
                DateTime bittar = (tblcari.tbl_baslangicBitisTarih == null) ? DateTime.Now : (tblcari.tbl_baslangicBitisTarih.BİTİSTARİH ?? DateTime.Now.Date);
                DateTime vartar = new DateTime(1900, 1, 1);
                if (bastar < vartar)
                {
                    MessageBox.Show("Tarih Yok");
                    return;
                }
                if (bittar < vartar)
                {
                    MessageBox.Show("Tarih Yok");
                    return;
                }


                txtFirmaAd.Text = tblcari.FIRMAADI;
                comboHizmetler.Text = (tblcari.tbl_hizmetturu == null) ? "" : tblcari.tbl_hizmetturu.HIZMETTURU;
                txtKontrol.Text = tblcari.IND.ToString();
                txtBasbitTutucu.Text = basbitTutucu.ToString();


                //aktarılan bitiş tarihi verilerin garanti durumunu form üzerinden gösterilmesi
                if (bittar != null)
                {
                    btnGarantiBaslat.Visible = false;
                    txtBit.Visible = true;

                    txtBit.Text = bittar.ToString();
                }
                else
                {
                    btnGarantiBaslat.Visible = false;
                    txtBit.Visible = false;

                }
                //aktarılan Başlangıç tarihi verilerin garanti durumunu form üzerinden gösterilmesi
                if (bastar != null)
                {
                    btnGarantiBaslat.Visible = false;
                    txtBasGrantiKontrol.Visible = false;
                    txtBas.Visible = true;
                    txtBas.Text = bastar.ToString();
                }
                else
                {
                    txtFark.Visible = false;
                    txtBasGrantiKontrol.Visible = true;

                    txtBas.Visible = false;
                }
                //garantisi başlamamışsa garanti başlat butonu görünür olur diğer if bloklarında ise bu botunu görünür yaptım
                if (txtBasGrantiKontrol.Visible == true)
                {
                    btnGarantiBaslat.Visible = true;

                }



                TimeSpan fark, bittimi, basladimi;
                DateTime kücükTarih = DateTime.Now.Date;
                DateTime büyükTarih = bittar;
                DateTime bugunTarih = txtbugun.Value;
                fark = (büyükTarih - kücükTarih);
                bittimi = (bugunTarih - büyükTarih);
                basladimi = (bastar - bugunTarih);
                if (fark.TotalDays > 0)
                {

                    txtFark.Visible = true;
                    txtFark.Text = "Garanti/Hizmet Bitimine Kalan Gün Sayısı: " + fark.TotalDays.ToString();
                    txtGunSayisi.Text = fark.TotalDays.ToString();
                }
                if (basladimi.TotalDays > 0)
                {

                    txtFark.Visible = true;
                    txtFark.Text = "Garanti/Hizmet Başlamasina " + basladimi.Days.ToString() + "  Gün  /" + basladimi.Hours.ToString() + "   Saat  ";
                }

                if (bittimi.TotalDays > 0)
                {

                    txtFark.Text = "Garantisi/Hizmeti Bitmiştir";
                    txtGunSayisi.Text = "";
                    btnGarantiBaslat.Text = "Garantiyi/Hizmeti Yeniden Başlat";
                    btnGarantiBaslat.Visible = true;
                }
                if (bastar == bittar)
                {
                    txtGunSayisi.Text = "";
                    btnGarantiBaslat.Text = "Garantiyi/Hizmeti Başlat";
                    txtFark.Text = "Garanti/Hizmeti Başlamadı";
                    btnGarantiBaslat.Visible = true;

                }
            }
        }


        public int Getir2() //carinin id sini getiriyor seçilenin
        {
            int id;
            id = Convert.ToInt32(txtKontrol.Text);
            return id;
        }

        public int Getir4()// baslangıc bitiş tarihlerini güncellemek için basbit id sini getiriyor
        {
            int id;
            id = Convert.ToInt32(txtBasbitTutucu.Text);
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelGönderForm frm = new PersonelGönderForm(this);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelDurumForm frm = new PersonelDurumForm(this);
            frm.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                var datacari = db.tbl_cari.Where(x => x.FIRMAADI.Contains(textBox1.Text) || x.tbl_hizmetturu.HIZMETTURU.Contains(textBox1.Text)).Select(a => new { a.IND, a.FIRMAADI, a.tbl_hizmetturu.HIZMETTURU, a.tbl_baslangicBitisTarih.BASLANGICTARİH, a.tbl_baslangicBitisTarih.BİTİSTARİH }).ToList();

                dataGridView1.DataSource = datacari;
                comboGarantiFilter.Text = "Tüm";
            }
        }

       

        private void comboGarantiFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGarantiFilter.Text == "Garantisi Bitmek Üzere Olan")
            {
                dataGridView1.DataSource = GetirGBÜO().Select(x => new { x.IND, x.FIRMAADI, x.tbl_hizmetturu.HIZMETTURU, x.tbl_baslangicBitisTarih.BASLANGICTARİH, x.tbl_baslangicBitisTarih.BİTİSTARİH }).ToList();

            }
            if(comboGarantiFilter.Text == "Tüm")
            {
                DatagridList();
            }
            if(comboGarantiFilter.Text== "Garantisi Olmayan")
            {
                dataGridView1.DataSource = GetirGrntBiten().Select(x => new { x.IND, x.FIRMAADI, x.tbl_hizmetturu.HIZMETTURU, x.tbl_baslangicBitisTarih.BASLANGICTARİH, x.tbl_baslangicBitisTarih.BİTİSTARİH }).ToList();
            }
        }

     
    }
}