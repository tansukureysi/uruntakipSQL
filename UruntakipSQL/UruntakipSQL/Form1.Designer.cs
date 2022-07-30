namespace UruntakipSQL
{
    partial class Form1
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
            this.urun_groupbox = new System.Windows.Forms.GroupBox();
            this.sube = new System.Windows.Forms.ComboBox();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtmaliyet = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txturun = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.islem_groupBox = new System.Windows.Forms.GroupBox();
            this.temizle_button = new System.Windows.Forms.Button();
            this.gunvelle_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.listeleme_button = new System.Windows.Forms.Button();
            this.kayıt_groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uruntakipDataSet = new UruntakipSQL.UruntakipDataSet();
            this.urunTableAdapter = new UruntakipSQL.UruntakipDataSetTableAdapters.urunTableAdapter();
            this.button_ekle = new System.Windows.Forms.Button();
            this.urun_groupbox.SuspendLayout();
            this.islem_groupBox.SuspendLayout();
            this.kayıt_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uruntakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // urun_groupbox
            // 
            this.urun_groupbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.urun_groupbox.Controls.Add(this.sube);
            this.urun_groupbox.Controls.Add(this.sehir);
            this.urun_groupbox.Controls.Add(this.label7);
            this.urun_groupbox.Controls.Add(this.label6);
            this.urun_groupbox.Controls.Add(this.label5);
            this.urun_groupbox.Controls.Add(this.label4);
            this.urun_groupbox.Controls.Add(this.label3);
            this.urun_groupbox.Controls.Add(this.label2);
            this.urun_groupbox.Controls.Add(this.label1);
            this.urun_groupbox.Controls.Add(this.txtstok);
            this.urun_groupbox.Controls.Add(this.txtmaliyet);
            this.urun_groupbox.Controls.Add(this.txtkategori);
            this.urun_groupbox.Controls.Add(this.txturun);
            this.urun_groupbox.Controls.Add(this.txtid);
            this.urun_groupbox.Location = new System.Drawing.Point(12, 12);
            this.urun_groupbox.Name = "urun_groupbox";
            this.urun_groupbox.Size = new System.Drawing.Size(250, 360);
            this.urun_groupbox.TabIndex = 0;
            this.urun_groupbox.TabStop = false;
            this.urun_groupbox.Text = "ÜRÜN GİRİŞİ";
            // 
            // sube
            // 
            this.sube.FormattingEnabled = true;
            this.sube.Items.AddRange(new object[] {
            "Beylikdüzü",
            "Buca",
            "Beşiktaş ",
            "Şirinyer",
            "Şirinevler"});
            this.sube.Location = new System.Drawing.Point(116, 167);
            this.sube.Name = "sube";
            this.sube.Size = new System.Drawing.Size(109, 21);
            this.sube.TabIndex = 15;
            // 
            // sehir
            // 
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            "İstanbul",
            "İzmir"});
            this.sehir.Location = new System.Drawing.Point(116, 217);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(109, 21);
            this.sehir.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "STOK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "MALİYET:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "ŞEHİR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "ŞUBE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "KATEGORİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÜRÜN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(116, 312);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(109, 20);
            this.txtstok.TabIndex = 6;
            // 
            // txtmaliyet
            // 
            this.txtmaliyet.Location = new System.Drawing.Point(116, 271);
            this.txtmaliyet.Name = "txtmaliyet";
            this.txtmaliyet.Size = new System.Drawing.Size(109, 20);
            this.txtmaliyet.TabIndex = 5;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(116, 119);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(109, 20);
            this.txtkategori.TabIndex = 2;
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(116, 74);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(109, 20);
            this.txturun.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(116, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(109, 20);
            this.txtid.TabIndex = 0;
            // 
            // islem_groupBox
            // 
            this.islem_groupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.islem_groupBox.Controls.Add(this.button_ekle);
            this.islem_groupBox.Controls.Add(this.temizle_button);
            this.islem_groupBox.Controls.Add(this.gunvelle_button);
            this.islem_groupBox.Controls.Add(this.sil_button);
            this.islem_groupBox.Controls.Add(this.listeleme_button);
            this.islem_groupBox.Location = new System.Drawing.Point(338, 12);
            this.islem_groupBox.Name = "islem_groupBox";
            this.islem_groupBox.Size = new System.Drawing.Size(224, 360);
            this.islem_groupBox.TabIndex = 1;
            this.islem_groupBox.TabStop = false;
            this.islem_groupBox.Text = "İŞLEMLER";
            // 
            // temizle_button
            // 
            this.temizle_button.BackColor = System.Drawing.Color.White;
            this.temizle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.temizle_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle_button.Location = new System.Drawing.Point(58, 312);
            this.temizle_button.Name = "temizle_button";
            this.temizle_button.Size = new System.Drawing.Size(121, 22);
            this.temizle_button.TabIndex = 4;
            this.temizle_button.Text = "TEMİZLE";
            this.temizle_button.UseVisualStyleBackColor = false;
            this.temizle_button.Click += new System.EventHandler(this.temizle_button_Click);
            // 
            // gunvelle_button
            // 
            this.gunvelle_button.BackColor = System.Drawing.Color.White;
            this.gunvelle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunvelle_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunvelle_button.Location = new System.Drawing.Point(58, 243);
            this.gunvelle_button.Name = "gunvelle_button";
            this.gunvelle_button.Size = new System.Drawing.Size(121, 22);
            this.gunvelle_button.TabIndex = 3;
            this.gunvelle_button.Text = "GÜNCELLE";
            this.gunvelle_button.UseVisualStyleBackColor = false;
            this.gunvelle_button.Click += new System.EventHandler(this.gunvelle_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.BackColor = System.Drawing.Color.White;
            this.sil_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sil_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_button.Location = new System.Drawing.Point(58, 170);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(121, 22);
            this.sil_button.TabIndex = 2;
            this.sil_button.Text = "SİL";
            this.sil_button.UseVisualStyleBackColor = false;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // listeleme_button
            // 
            this.listeleme_button.BackColor = System.Drawing.Color.White;
            this.listeleme_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listeleme_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleme_button.Location = new System.Drawing.Point(58, 33);
            this.listeleme_button.Name = "listeleme_button";
            this.listeleme_button.Size = new System.Drawing.Size(121, 22);
            this.listeleme_button.TabIndex = 0;
            this.listeleme_button.Text = "LİSTELE";
            this.listeleme_button.UseVisualStyleBackColor = false;
            this.listeleme_button.Click += new System.EventHandler(this.listeleme_button_Click);
            // 
            // kayıt_groupBox
            // 
            this.kayıt_groupBox.Controls.Add(this.dataGridView1);
            this.kayıt_groupBox.Location = new System.Drawing.Point(27, 396);
            this.kayıt_groupBox.Name = "kayıt_groupBox";
            this.kayıt_groupBox.Size = new System.Drawing.Size(720, 189);
            this.kayıt_groupBox.TabIndex = 2;
            this.kayıt_groupBox.TabStop = false;
            this.kayıt_groupBox.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.urunDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.subeDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.maliyetDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // urunDataGridViewTextBoxColumn
            // 
            this.urunDataGridViewTextBoxColumn.DataPropertyName = "Urun";
            this.urunDataGridViewTextBoxColumn.HeaderText = "Urun";
            this.urunDataGridViewTextBoxColumn.Name = "urunDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // subeDataGridViewTextBoxColumn
            // 
            this.subeDataGridViewTextBoxColumn.DataPropertyName = "Sube";
            this.subeDataGridViewTextBoxColumn.HeaderText = "Sube";
            this.subeDataGridViewTextBoxColumn.Name = "subeDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // maliyetDataGridViewTextBoxColumn
            // 
            this.maliyetDataGridViewTextBoxColumn.DataPropertyName = "Maliyet";
            this.maliyetDataGridViewTextBoxColumn.HeaderText = "Maliyet";
            this.maliyetDataGridViewTextBoxColumn.Name = "maliyetDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.uruntakipDataSet;
            // 
            // uruntakipDataSet
            // 
            this.uruntakipDataSet.DataSetName = "UruntakipDataSet";
            this.uruntakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.Color.White;
            this.button_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ekle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.Location = new System.Drawing.Point(58, 97);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(121, 22);
            this.button_ekle.TabIndex = 5;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 593);
            this.Controls.Add(this.kayıt_groupBox);
            this.Controls.Add(this.islem_groupBox);
            this.Controls.Add(this.urun_groupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.urun_groupbox.ResumeLayout(false);
            this.urun_groupbox.PerformLayout();
            this.islem_groupBox.ResumeLayout(false);
            this.kayıt_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uruntakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox urun_groupbox;
        private System.Windows.Forms.ComboBox sube;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtmaliyet;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txturun;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox islem_groupBox;
        private System.Windows.Forms.Button temizle_button;
        private System.Windows.Forms.Button gunvelle_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button listeleme_button;
        private System.Windows.Forms.GroupBox kayıt_groupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UruntakipDataSet uruntakipDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private UruntakipDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maliyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_ekle;
    }
}

