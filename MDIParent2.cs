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
    public partial class MDIParent2 : Form
    {
        
        private int childFormNumber = 0;

        public MDIParent2()
        {
            InitializeComponent();
        }

        private void costumizedesign()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void hidesubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private Form aktifForm = null;
        private void openChildForm(Form chieldform)
        {
            if (aktifForm != null) { aktifForm.Close(); }
            aktifForm = chieldform;
            chieldform.TopLevel = false;
            chieldform.FormBorderStyle = FormBorderStyle.None;
            chieldform.Dock = DockStyle.Fill;
            chieldformpanel.Controls.Add(chieldform);
            chieldformpanel.Tag = chieldform;
            chieldform.BringToFront();
            chieldform.Show();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Your code
            openChildForm(new CariEklemeForm());
            label1.Text = "Cari Ekleme Formu";

            hidesubMenu();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGuncelle());
            // Your code
            label1.Text = "Cari Güncelleme Formu";
            hidesubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSil());
            label1.Text = "Cari Silme Formu";
            // Your code
            hidesubMenu();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            showSubmenu(panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubmenu(panel3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            showSubmenu(panel4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new AnasayfaFrm());
            

            hidesubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGuncelle());
            hidesubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Your code
            hidesubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new RaporlarForm());
            // Your code
            label1.Text = "Cari Raporu";
            hidesubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new RaporlarMusterilerFrm());
            label1.Text = "Müşteri Raporu";
            // Your code
            hidesubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHizmetTuru());
            label1.Text = "Hizmet Türleri";
            hidesubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSektor());
            label1.Text = "Sektörler";
            hidesubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new PersonelListe());
            label1.Text = "Personel Listesi";
            hidesubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubmenu(panel6);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new frmListele());
            label1.Text = "Cari Listeleme";
            hidesubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMail());
            label1.Text = "Mail Formu";
            hidesubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            openChildForm(new GarantiDurumFrm()); 
            hidesubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            openChildForm(new GarantiDurumFrm());
            label1.Text = "Garanti Durum";

            hidesubMenu();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            label1.Text = "Anasayfa";
            GarantiDurumFrm form2 = new GarantiDurumFrm();

            if (form2.Getir3().Count != 0)
            {
                GarantiRaporForm form = new GarantiRaporForm(this);
                form.TopMost = true;
                form.Show();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true )
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            
        }

        public void button22_Click(object sender, EventArgs e)
        {
            openChildForm(new ArızaAnaForm());
            label1.Text = "Arıza";

            hidesubMenu();
        }

       
    }
}
