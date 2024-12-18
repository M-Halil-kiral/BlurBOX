namespace BlurBox.BlurFinans
{
    partial class BlurFinans
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
            this.cmbKrediTuru = new System.Windows.Forms.ComboBox();
            this.cmbVade = new System.Windows.Forms.ComboBox();
            this.txtKrediMiktari = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dataGridViewSonuclar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKrediTuru
            // 
            this.cmbKrediTuru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKrediTuru.FormattingEnabled = true;
            this.cmbKrediTuru.Location = new System.Drawing.Point(70, 147);
            this.cmbKrediTuru.Name = "cmbKrediTuru";
            this.cmbKrediTuru.Size = new System.Drawing.Size(154, 31);
            this.cmbKrediTuru.TabIndex = 0;
            this.cmbKrediTuru.SelectedIndexChanged += new System.EventHandler(this.cmbKrediTuru_SelectedIndexChanged_1);
            // 
            // cmbVade
            // 
            this.cmbVade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVade.FormattingEnabled = true;
            this.cmbVade.Location = new System.Drawing.Point(230, 146);
            this.cmbVade.Name = "cmbVade";
            this.cmbVade.Size = new System.Drawing.Size(154, 31);
            this.cmbVade.TabIndex = 1;
            this.cmbVade.SelectedIndexChanged += new System.EventHandler(this.cmbVade_SelectedIndexChanged);
            // 
            // txtKrediMiktari
            // 
            this.txtKrediMiktari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediMiktari.Location = new System.Drawing.Point(390, 146);
            this.txtKrediMiktari.Name = "txtKrediMiktari";
            this.txtKrediMiktari.Size = new System.Drawing.Size(154, 30);
            this.txtKrediMiktari.TabIndex = 2;
            this.txtKrediMiktari.TextChanged += new System.EventHandler(this.txtKrediMiktari_TextChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(578, 105);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(154, 73);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // dataGridViewSonuclar
            // 
            this.dataGridViewSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonuclar.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewSonuclar.Name = "dataGridViewSonuclar";
            this.dataGridViewSonuclar.RowHeadersWidth = 51;
            this.dataGridViewSonuclar.RowTemplate.Height = 24;
            this.dataGridViewSonuclar.Size = new System.Drawing.Size(776, 228);
            this.dataGridViewSonuclar.TabIndex = 4;
            this.dataGridViewSonuclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSonuclar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kredi Türünü Seçin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vade Seçin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(386, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kredi Miktarı Girin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BlurFinans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSonuclar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKrediMiktari);
            this.Controls.Add(this.cmbVade);
            this.Controls.Add(this.cmbKrediTuru);
            this.Name = "BlurFinans";
            this.Text = "BlurFinans";
            this.Load += new System.EventHandler(this.BlurFinans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKrediTuru;
        private System.Windows.Forms.ComboBox cmbVade;
        private System.Windows.Forms.TextBox txtKrediMiktari;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dataGridViewSonuclar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}