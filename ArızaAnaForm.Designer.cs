
namespace garantiTakip
{
    partial class ArızaAnaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnArizaKayit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArizaTanim = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.btnArizaKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(991, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnDetay
            // 
            this.btnDetay.Location = new System.Drawing.Point(138, 111);
            this.btnDetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(147, 33);
            this.btnDetay.TabIndex = 1;
            this.btnDetay.Text = "Detaylar";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnArizaKayit
            // 
            this.btnArizaKayit.Location = new System.Drawing.Point(290, 111);
            this.btnArizaKayit.Name = "btnArizaKayit";
            this.btnArizaKayit.Size = new System.Drawing.Size(147, 33);
            this.btnArizaKayit.TabIndex = 2;
            this.btnArizaKayit.Text = "Yeni Kayıt Oluştur";
            this.btnArizaKayit.UseVisualStyleBackColor = true;
            this.btnArizaKayit.Click += new System.EventHandler(this.btnArizaKayit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(627, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arıza Tanımı:";
            // 
            // txtArizaTanim
            // 
            this.txtArizaTanim.Location = new System.Drawing.Point(138, 53);
            this.txtArizaTanim.Name = "txtArizaTanim";
            this.txtArizaTanim.Size = new System.Drawing.Size(200, 28);
            this.txtArizaTanim.TabIndex = 7;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(138, 19);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(200, 28);
            this.txtMusteri.TabIndex = 8;
            // 
            // btnArizaKapat
            // 
            this.btnArizaKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnArizaKapat.Location = new System.Drawing.Point(366, 19);
            this.btnArizaKapat.Name = "btnArizaKapat";
            this.btnArizaKapat.Size = new System.Drawing.Size(136, 28);
            this.btnArizaKapat.TabIndex = 68;
            this.btnArizaKapat.Text = "Arızayı Kapat";
            this.btnArizaKapat.UseVisualStyleBackColor = false;
            this.btnArizaKapat.Click += new System.EventHandler(this.btnArizaKapat_Click);
            // 
            // ArızaAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(991, 566);
            this.Controls.Add(this.btnArizaKapat);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.txtArizaTanim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnArizaKayit);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ArızaAnaForm";
            this.Text = "ArızaAnaForm";
            this.Load += new System.EventHandler(this.ArızaAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnArizaKayit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArizaTanim;
        private System.Windows.Forms.TextBox txtMusteri;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnArizaKapat;
    }
}