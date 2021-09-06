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
    public partial class PersonelDurumForm : Form
    {
        GarantiDurumFrm Form;
        stajyerEntities3 db = new stajyerEntities3();
        public PersonelDurumForm(GarantiDurumFrm frm)
        {
            Form = frm;
            InitializeComponent();
        }
        
        private void PersonelDurumForm_Load(object sender, EventArgs e)
        {
            foreach (var personel in db.tbl_personel)
            {

                combopersoneller2.Items.Add(personel.PERSONELAD + " " + personel.PERSONELSOYAD);



            }
            int id = Form.Getir2();
            tbl_cari cari = db.tbl_cari.Find(id);
            txtFirmaad.Text = cari.FIRMAADI;
            txtHizmet.Text = (cari.tbl_hizmetturu == null) ? "" : cari.tbl_hizmetturu.HIZMETTURU;
            combopersoneller2.Text = cari.tbl_personel.PERSONELAD + " " + cari.tbl_personel.PERSONELSOYAD;

            dataGridView1.DataSource = db.tbl_cari.Where(x=>(x.tbl_personel.PERSONELAD + " " + x.tbl_personel.PERSONELSOYAD)==combopersoneller2.Text).Select(x => new { x.FIRMAADI, x.tbl_personel.PERSONELAD, x.tbl_personel.PERSONELSOYAD, x.tbl_yorum.YORUM }).ToList();

           


          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Form.Getir2();
            tbl_cari cari = db.tbl_cari.Find(id);

            int yorumid = cari.PersonelYorum.Value;

            tbl_yorum yorum = db.tbl_yorum.Find(yorumid);
            yorum.YORUM = txtYorum.Text;
            db.SaveChanges();
            PersonelDurumForm_Load(sender, e);
        }

        private void combopersoneller2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_cari.Where(x => (x.tbl_personel.PERSONELAD + " " + x.tbl_personel.PERSONELSOYAD) == combopersoneller2.Text).Select(x => new { x.FIRMAADI, x.tbl_personel.PERSONELAD, x.tbl_personel.PERSONELSOYAD, x.tbl_yorum.YORUM }).ToList();

        }
    }
}
