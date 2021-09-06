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
    public partial class FrmSektor : Form
    {
        public FrmSektor()
        {
            InitializeComponent();
        }

        stajyerEntities3 db = new stajyerEntities3();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_sektor.Select(x => new { x.IND, x.SEKTORADI }).ToList();
        }
        private void FrmSektor_Load(object sender, EventArgs e)
        {


            Listele();
            foreach (tbl_sektor item in db.tbl_sektor)
            {
                comboBox1.Items.Add(item.SEKTORADI);

            }


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tbl_sektor sektor = new tbl_sektor();


            if (string.IsNullOrWhiteSpace(comboBox1.Text) && comboBox1.Text.Length >= 0)

            {
                MessageBox.Show("Sektör Adını Boş Geçmeyin");
                return;
            }

            foreach (tbl_sektor sektor1 in db.tbl_sektor)
            {
                string sektorAd = sektor1.SEKTORADI;

                if (sektorAd == comboBox1.Text)
                {
                    MessageBox.Show("Sektör Zaten Kayıtlı");
                    return;
                }


            }

            sektor.SEKTORADI = comboBox1.Text;
            db.tbl_sektor.Add(sektor);
            db.SaveChanges();
            MessageBox.Show("Sektör Eklenmiştir");
            Listele();



        }



        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {

                int a = int.Parse(textBox2.Text);
                tbl_sektor sektoradi = db.tbl_sektor.Where(w => w.IND == a).FirstOrDefault();
                db.tbl_sektor.Remove(sektoradi);

                DialogResult dialogResult = MessageBox.Show("Emin Misiniz?", "UYARI!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.SaveChanges();
                    FrmSektor_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }


               

            }
            catch
            {

                MessageBox.Show("Seçilen Sektör caride Kayıtlı!!");
            }

        }



        private void BtnGuncelle_Click(object sender, EventArgs e)
        {



            int a = int.Parse(textBox2.Text);

            tbl_sektor guncelle = db.tbl_sektor.Where(x => x.IND == a).FirstOrDefault();



            if (string.IsNullOrWhiteSpace(comboBox1.Text) && comboBox1.Text.Length >= 0)

            {
                MessageBox.Show("Sektör Adını Boş Geçmeyin");
                return;
            }

            guncelle.SEKTORADI = comboBox1.Text;


            db.SaveChanges();

            Listele();




        }

     

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox2.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            comboBox1.Text = (dataGridView1.CurrentRow.Cells[1].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[1].Value.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Clear();
            txtArama.Clear();
        }




        private void txtArama_KeyUp(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = db.tbl_sektor.Where(x => x.SEKTORADI.Contains(txtArama.Text)).ToList();
            }

        }
    }
}

