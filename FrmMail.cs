using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        // taner811907 computer190781
        // qwerty1907 acar1907881


        bool mailkontrol = false;
        bool garantimailkontrol = false;
        public void MailGonder(string mesaj, string from)
        {

            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("computer190781@gmail.com", "taner811907");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(mesaj);
            mesajım.From = new MailAddress(from);
            mesajım.Subject = "Kodla Teknoloji";
            mesajım.Body = "Doğum Gününüz Kutlu Olsun";
            istemci.Send(mesajım);

        }

        public void GarantiMailGonder(string mesaj, string from)
        {

            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("computer190781@gmail.com", "taner811907");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(mesaj);
            mesajım.From = new MailAddress(from);
            mesajım.Subject = "Kodla Teknoloji";
            mesajım.Body = "Garantinizin Bitimine 10 Gün Kalmıştır";
            istemci.Send(mesajım);

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMail_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("computer190781@gmail.com");

            //foreach (var item in db.tbl_Yetkili)
            //{                             
            //    comboBox1.Items.Add(item.MAIL);
            //}

            foreach (var item in db.tbl_Yetkili)
            {
                DateTime gun = Convert.ToDateTime(item.DGMTARİH);
                int guun = gun.Day;
                int ay = gun.Month;

                if (guun.ToString() == DateTime.Now.Date.Day.ToString() && ay.ToString() == DateTime.Now.Date.Month.ToString())
                {
                    comboBox2.Items.Add(item.AD);
                    comboBox5.Items.Add(item.DGMTARİH);
                    comboBox1.Items.Add(item.MAIL);

                    //  MailGonder(comboBox1.Items[0].ToString(), comboBox1.Items[0].ToString());
                    // MailGonder(comboBox1.Items[3].ToString(), comboBox1.Items[3].ToString());


                    //MailGonder(); // doğum günü Maili

                }
            }



            int bugun = Convert.ToInt32(DateTime.Now.Date.Day);
            int bugunay = Convert.ToInt32(DateTime.Now.Date.Month);

            foreach (var item in db.tbl_cari)
            {
                DateTime gun = Convert.ToDateTime(item.tbl_baslangicBitisTarih.BİTİSTARİH);
                int guun = gun.Day;
                int ay = gun.Month;
                int islem = guun - bugun;

                if (bugunay == ay && islem == 10)
                {
                    comboBox3.Items.Add(item.tbl_Yetkili.AD + " : " + item.tbl_baslangicBitisTarih.BİTİSTARİH);

                    comboBox4.Items.Add(item.tbl_Yetkili.MAIL);

                }

                //comboBox4.Items.Add(db.tbl_cari.Select(x => x.tbl_Yetkili.MAIL).ToString());
                // GarantiMailGonder(); // Garanti Bitimine 10 gün kala Maili


                // comboBox3.Items.Add(item.BİTİSTARİH);
            }


            //    Doğum günü Mail


            List<tbl_cari> cari = db.tbl_cari.Where(x => x.MailGonderildimi == false).ToList();

            foreach (var item in cari)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (item.tbl_Yetkili.MAIL == comboBox1.Items[i].ToString())
                    {
                        if (item.MailGonderildimi != true)
                        {
                            listBox1.Items.Add(comboBox1.Items[i]);
                            MailGonder(comboBox1.Items[i].ToString(), comboBox1.Items[i].ToString());
                            item.MailGonderildimi = true;
                            mailkontrol = true;
                           
                        }
                        else
                        {
                            MessageBox.Show("Mailler Zaten gönderildi");
                            mailkontrol = false;
                            
                        }
                    }
                }

            }
            db.SaveChanges();


            if (mailkontrol == true)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    MessageBox.Show("Doğum günü Maili Gönderilenler " + comboBox1.Items[i].ToString());

                }
              
            }
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Gönderilecek Doğum Günü Maili Yok");
               
            }
           else if(mailkontrol == false)
            {
                MessageBox.Show("Doğum Günü Mailleri Daha Önce Gönderilmiş");

            }
           





            //    Garanti Mail

            List<tbl_cari> maill = db.tbl_cari.Where(x => x.GarantiMail == false).ToList();

            foreach (var item in maill)
            {
                for (int i = 0; i < comboBox4.Items.Count; i++)
                {
                    if (item.tbl_Yetkili.MAIL == comboBox4.Items[i].ToString())
                    {
                        if (item.GarantiMail != true)
                        {
                            listBox2.Items.Add(comboBox4.Items[i]);
                            GarantiMailGonder(comboBox4.Items[i].ToString(),comboBox4.Items[i].ToString());
                            
                            item.GarantiMail = true;
                            garantimailkontrol = true;
                        }
                        else
                        {
                            MessageBox.Show("Garanti Mailleri Gönderilmiş");

                            garantimailkontrol = false;
                        }

                    }

                   

                }
                db.SaveChanges();              
            }
            if (garantimailkontrol == true)
            {
                for (int i = 0; i < comboBox4.Items.Count; i++)
                {
                    MessageBox.Show("Garanti Maili Gönderilenler" + comboBox4.Items[i].ToString());
                }

               
            }

            if (comboBox4.Items.Count == 0)
            {
                MessageBox.Show("Gönderilecek Garanti Maili Yok");
                return;
            }
            if (garantimailkontrol == false)
            {
                MessageBox.Show("Garanti Mailleri Zaten Gönderilmiş");
                
            }




        }
    }
}
