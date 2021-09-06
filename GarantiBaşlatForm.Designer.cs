
namespace garantiTakip
{
    partial class GarantiBaşlatForm
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
            this.txtBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirmaAdı = new System.Windows.Forms.TextBox();
            this.txtGarantiBaslat = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.Label();
            this.btnGarantiYeniden = new System.Windows.Forms.Button();
            this.txtBasbitTut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBaslangıc
            // 
            this.txtBaslangıc.Location = new System.Drawing.Point(338, 81);
            this.txtBaslangıc.Name = "txtBaslangıc";
            this.txtBaslangıc.Size = new System.Drawing.Size(275, 32);
            this.txtBaslangıc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(338, 117);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(275, 32);
            this.txtBitis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Garantisi Başlatılacak Firma Adı:";
            // 
            // txtFirmaAdı
            // 
            this.txtFirmaAdı.Enabled = false;
            this.txtFirmaAdı.Location = new System.Drawing.Point(338, 29);
            this.txtFirmaAdı.Name = "txtFirmaAdı";
            this.txtFirmaAdı.Size = new System.Drawing.Size(275, 32);
            this.txtFirmaAdı.TabIndex = 5;
            // 
            // txtGarantiBaslat
            // 
            this.txtGarantiBaslat.Location = new System.Drawing.Point(359, 229);
            this.txtGarantiBaslat.Name = "txtGarantiBaslat";
            this.txtGarantiBaslat.Size = new System.Drawing.Size(237, 58);
            this.txtGarantiBaslat.TabIndex = 6;
            this.txtGarantiBaslat.Text = "Garantiyi/Hizmeti Başlat";
            this.txtGarantiBaslat.UseVisualStyleBackColor = true;
            this.txtGarantiBaslat.Click += new System.EventHandler(this.txtGarantiBaslat_Click);
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(12, 229);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(61, 24);
            this.txtid.TabIndex = 7;
            this.txtid.Text = "label4";
            this.txtid.Visible = false;
            // 
            // btnGarantiYeniden
            // 
            this.btnGarantiYeniden.Location = new System.Drawing.Point(359, 166);
            this.btnGarantiYeniden.Name = "btnGarantiYeniden";
            this.btnGarantiYeniden.Size = new System.Drawing.Size(237, 57);
            this.btnGarantiYeniden.TabIndex = 8;
            this.btnGarantiYeniden.Text = "Garantiyi/Hizmeti Yeniden Başlat";
            this.btnGarantiYeniden.UseVisualStyleBackColor = true;
            this.btnGarantiYeniden.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBasbitTut
            // 
            this.txtBasbitTut.AutoSize = true;
            this.txtBasbitTut.Location = new System.Drawing.Point(12, 263);
            this.txtBasbitTut.Name = "txtBasbitTut";
            this.txtBasbitTut.Size = new System.Drawing.Size(144, 24);
            this.txtBasbitTut.TabIndex = 9;
            this.txtBasbitTut.Text = "Güncelleme için";
            this.txtBasbitTut.Visible = false;
            // 
            // GarantiBaşlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 301);
            this.Controls.Add(this.txtBasbitTut);
            this.Controls.Add(this.btnGarantiYeniden);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtGarantiBaslat);
            this.Controls.Add(this.txtFirmaAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaslangıc);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GarantiBaşlatForm";
            this.Text = "GarantiBaşlatForm";
            this.Load += new System.EventHandler(this.GarantiBaşlatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtBaslangıc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaAdı;
        private System.Windows.Forms.Button txtGarantiBaslat;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Button btnGarantiYeniden;
        private System.Windows.Forms.Label txtBasbitTut;
    }
}