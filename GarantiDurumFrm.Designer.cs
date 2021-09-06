
namespace garantiTakip
{
    partial class GarantiDurumFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBas = new System.Windows.Forms.DateTimePicker();
            this.txtBit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBasGrantiKontrol = new System.Windows.Forms.Label();
            this.btnGarantiBaslat = new System.Windows.Forms.Button();
            this.txtFark = new System.Windows.Forms.Label();
            this.txtbugun = new System.Windows.Forms.DateTimePicker();
            this.txtKontrol = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.Label();
            this.txtBasbitTutucu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboHizmetler = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboGarantiFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Garanti Durum Kontrol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Garanti Başlangıç Tarihi:";
            // 
            // txtBas
            // 
            this.txtBas.Enabled = false;
            this.txtBas.Location = new System.Drawing.Point(193, 117);
            this.txtBas.Name = "txtBas";
            this.txtBas.Size = new System.Drawing.Size(241, 28);
            this.txtBas.TabIndex = 4;
            // 
            // txtBit
            // 
            this.txtBit.Enabled = false;
            this.txtBit.Location = new System.Drawing.Point(193, 151);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(241, 28);
            this.txtBit.TabIndex = 6;
            this.txtBit.ValueChanged += new System.EventHandler(this.txtBit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Garanti Bitiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firma Adı:";
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Enabled = false;
            this.txtFirmaAd.Location = new System.Drawing.Point(193, 49);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(241, 28);
            this.txtFirmaAd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aldığı Hizmet:";
            // 
            // txtBasGrantiKontrol
            // 
            this.txtBasGrantiKontrol.AutoSize = true;
            this.txtBasGrantiKontrol.Location = new System.Drawing.Point(1071, 103);
            this.txtBasGrantiKontrol.Name = "txtBasGrantiKontrol";
            this.txtBasGrantiKontrol.Size = new System.Drawing.Size(148, 21);
            this.txtBasGrantiKontrol.TabIndex = 12;
            this.txtBasGrantiKontrol.Text = "Garantisi Başlamadı";
            this.txtBasGrantiKontrol.Visible = false;
            // 
            // btnGarantiBaslat
            // 
            this.btnGarantiBaslat.Location = new System.Drawing.Point(440, 117);
            this.btnGarantiBaslat.Name = "btnGarantiBaslat";
            this.btnGarantiBaslat.Size = new System.Drawing.Size(279, 36);
            this.btnGarantiBaslat.TabIndex = 13;
            this.btnGarantiBaslat.Text = "garanti başlatma";
            this.btnGarantiBaslat.UseVisualStyleBackColor = true;
            this.btnGarantiBaslat.Click += new System.EventHandler(this.btnGarantiBaslat_Click);
            // 
            // txtFark
            // 
            this.txtFark.AutoSize = true;
            this.txtFark.Location = new System.Drawing.Point(225, 187);
            this.txtFark.Name = "txtFark";
            this.txtFark.Size = new System.Drawing.Size(52, 21);
            this.txtFark.TabIndex = 14;
            this.txtFark.Text = "label6";
            // 
            // txtbugun
            // 
            this.txtbugun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbugun.Location = new System.Drawing.Point(997, 13);
            this.txtbugun.Name = "txtbugun";
            this.txtbugun.Size = new System.Drawing.Size(200, 28);
            this.txtbugun.TabIndex = 15;
            // 
            // txtKontrol
            // 
            this.txtKontrol.AutoSize = true;
            this.txtKontrol.Location = new System.Drawing.Point(1109, 69);
            this.txtKontrol.Name = "txtKontrol";
            this.txtKontrol.Size = new System.Drawing.Size(110, 21);
            this.txtKontrol.TabIndex = 16;
            this.txtKontrol.Text = "formIdKontrol";
            this.txtKontrol.Visible = false;
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.AutoSize = true;
            this.txtGunSayisi.Location = new System.Drawing.Point(1141, 136);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(78, 21);
            this.txtGunSayisi.TabIndex = 17;
            this.txtGunSayisi.Text = "gün sayisi";
            this.txtGunSayisi.Visible = false;
            // 
            // txtBasbitTutucu
            // 
            this.txtBasbitTutucu.AutoSize = true;
            this.txtBasbitTutucu.Location = new System.Drawing.Point(1097, 171);
            this.txtBasbitTutucu.Name = "txtBasbitTutucu";
            this.txtBasbitTutucu.Size = new System.Drawing.Size(122, 21);
            this.txtBasbitTutucu.TabIndex = 18;
            this.txtBasbitTutucu.Text = "txtBasbitTutucu";
            this.txtBasbitTutucu.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = " Seçilen Firmaya Personel Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboHizmetler
            // 
            this.comboHizmetler.Enabled = false;
            this.comboHizmetler.FormattingEnabled = true;
            this.comboHizmetler.Location = new System.Drawing.Point(193, 82);
            this.comboHizmetler.Name = "comboHizmetler";
            this.comboHizmetler.Size = new System.Drawing.Size(241, 29);
            this.comboHizmetler.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "İlgili Personelin Yorumları";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 28);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // comboGarantiFilter
            // 
            this.comboGarantiFilter.FormattingEnabled = true;
            this.comboGarantiFilter.Items.AddRange(new object[] {
            "Tüm",
            "Garantisi Bitmek Üzere Olan",
            "Garantisi Olmayan"});
            this.comboGarantiFilter.Location = new System.Drawing.Point(734, 120);
            this.comboGarantiFilter.Name = "comboGarantiFilter";
            this.comboGarantiFilter.Size = new System.Drawing.Size(278, 29);
            this.comboGarantiFilter.TabIndex = 24;
            this.comboGarantiFilter.Text = "    Seçiniz";
            this.comboGarantiFilter.SelectedIndexChanged += new System.EventHandler(this.comboGarantiFilter_SelectedIndexChanged);
            // 
            // GarantiDurumFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 568);
            this.Controls.Add(this.comboGarantiFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboHizmetler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBasbitTutucu);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.txtKontrol);
            this.Controls.Add(this.txtbugun);
            this.Controls.Add(this.txtFark);
            this.Controls.Add(this.btnGarantiBaslat);
            this.Controls.Add(this.txtBasGrantiKontrol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GarantiDurumFrm";
            this.Text = "GarantiDurumFrm";
            this.Load += new System.EventHandler(this.GarantiDurumFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtBas;
        private System.Windows.Forms.DateTimePicker txtBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtBasGrantiKontrol;
        private System.Windows.Forms.Label txtFark;
        private System.Windows.Forms.DateTimePicker txtbugun;
        private System.Windows.Forms.Label txtKontrol;
        private System.Windows.Forms.Label txtGunSayisi;
        private System.Windows.Forms.Label txtBasbitTutucu;
        public System.Windows.Forms.Button btnGarantiBaslat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboHizmetler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboGarantiFilter;
    }
}