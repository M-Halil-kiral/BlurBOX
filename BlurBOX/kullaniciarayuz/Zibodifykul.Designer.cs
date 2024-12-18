namespace BlurBOX.kullaniciarayuz
{
    partial class Zibodifykul
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zibodifykul));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muzikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blurBOXDataSet = new BlurBOX.blurBOXDataSet();
            this.muzikTableAdapter = new BlurBOX.blurBOXDataSetTableAdapters.MuzikTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurBOXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baslikDataGridViewTextBoxColumn,
            this.sanatciDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.muzikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(616, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(274, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // baslikDataGridViewTextBoxColumn
            // 
            this.baslikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baslikDataGridViewTextBoxColumn.DataPropertyName = "baslik";
            this.baslikDataGridViewTextBoxColumn.HeaderText = "Şarkı İsmi";
            this.baslikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslikDataGridViewTextBoxColumn.Name = "baslikDataGridViewTextBoxColumn";
            // 
            // sanatciDataGridViewTextBoxColumn
            // 
            this.sanatciDataGridViewTextBoxColumn.DataPropertyName = "sanatci";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanatciDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sanatciDataGridViewTextBoxColumn.HeaderText = "Sanatçı";
            this.sanatciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanatciDataGridViewTextBoxColumn.Name = "sanatciDataGridViewTextBoxColumn";
            this.sanatciDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dosya_yolu";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // muzikBindingSource
            // 
            this.muzikBindingSource.DataMember = "Muzik";
            this.muzikBindingSource.DataSource = this.blurBOXDataSet;
            // 
            // blurBOXDataSet
            // 
            this.blurBOXDataSet.DataSetName = "blurBOXDataSet";
            this.blurBOXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muzikTableAdapter
            // 
            this.muzikTableAdapter.ClearBeforeFill = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-2, 399);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(892, 69);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(74, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Ne Çalmak İstiyorsun ?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(556, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = " 🔎";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(-2, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 60);
            this.button6.TabIndex = 13;
            this.button6.Text = "⌂";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(-2, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 60);
            this.button5.TabIndex = 12;
            this.button5.Text = "⬅";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Zibodifykul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Zibodifykul";
            this.Text = "Zibodifykul";
            this.Load += new System.EventHandler(this.Zibodifykul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurBOXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private blurBOXDataSet blurBOXDataSet;
        private System.Windows.Forms.BindingSource muzikBindingSource;
        private blurBOXDataSetTableAdapters.MuzikTableAdapter muzikTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}