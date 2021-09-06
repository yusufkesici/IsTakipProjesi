
namespace garantiTakip
{
    partial class PersonelDurumForm
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
            this.txtFirmaad = new System.Windows.Forms.TextBox();
            this.txtYorum = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHizmet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combopersoneller2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 304);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtFirmaad
            // 
            this.txtFirmaad.Enabled = false;
            this.txtFirmaad.Location = new System.Drawing.Point(172, 89);
            this.txtFirmaad.Name = "txtFirmaad";
            this.txtFirmaad.Size = new System.Drawing.Size(190, 28);
            this.txtFirmaad.TabIndex = 5;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(172, 179);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(190, 104);
            this.txtYorum.TabIndex = 6;
            this.txtYorum.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "İlgili Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Personel Yorumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Verilen Hizmet:";
            // 
            // txtHizmet
            // 
            this.txtHizmet.Enabled = false;
            this.txtHizmet.Location = new System.Drawing.Point(172, 134);
            this.txtHizmet.Name = "txtHizmet";
            this.txtHizmet.Size = new System.Drawing.Size(190, 28);
            this.txtHizmet.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel:";
            // 
            // combopersoneller2
            // 
            this.combopersoneller2.Enabled = false;
            this.combopersoneller2.FormattingEnabled = true;
            this.combopersoneller2.Location = new System.Drawing.Point(172, 42);
            this.combopersoneller2.Name = "combopersoneller2";
            this.combopersoneller2.Size = new System.Drawing.Size(190, 29);
            this.combopersoneller2.TabIndex = 13;
            this.combopersoneller2.SelectedIndexChanged += new System.EventHandler(this.combopersoneller2_SelectedIndexChanged);
            // 
            // PersonelDurumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 408);
            this.Controls.Add(this.combopersoneller2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHizmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.txtFirmaad);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonelDurumForm";
            this.Text = "PersonelDurumForm";
            this.Load += new System.EventHandler(this.PersonelDurumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFirmaad;
        private System.Windows.Forms.RichTextBox txtYorum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHizmet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combopersoneller2;
    }
}