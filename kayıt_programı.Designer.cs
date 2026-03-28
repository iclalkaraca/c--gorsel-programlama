namespace deneme_proje1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.Label();
            this.dogumTarihi = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSinema = new System.Windows.Forms.CheckBox();
            this.cbMuzik = new System.Windows.Forms.CheckBox();
            this.cbSpor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(28, 32);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(45, 16);
            this.ad.TabIndex = 0;
            this.ad.Text = "adınız:";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(28, 65);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(67, 16);
            this.soyad.TabIndex = 1;
            this.soyad.Text = "soyadınız:";
            // 
            // yas
            // 
            this.yas.AutoSize = true;
            this.yas.Location = new System.Drawing.Point(28, 95);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(51, 16);
            this.yas.TabIndex = 2;
            this.yas.Text = "yaşınız:";
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.AutoSize = true;
            this.dogumTarihi.Location = new System.Drawing.Point(28, 134);
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.Size = new System.Drawing.Size(83, 16);
            this.dogumTarihi.TabIndex = 3;
            this.dogumTarihi.Text = "doğum tarihi:";
            // 
            // sehir
            // 
            this.sehir.AutoSize = true;
            this.sehir.Location = new System.Drawing.Point(28, 174);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(36, 16);
            this.sehir.TabIndex = 4;
            this.sehir.Text = "şehir";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(114, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(114, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // dpDogumTarihi
            // 
            this.dpDogumTarihi.Location = new System.Drawing.Point(117, 134);
            this.dpDogumTarihi.Name = "dpDogumTarihi";
            this.dpDogumTarihi.Size = new System.Drawing.Size(197, 22);
            this.dpDogumTarihi.TabIndex = 7;
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(114, 95);
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(120, 22);
            this.nudYas.TabIndex = 8;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "istanbul",
            "izmir",
            "antalya",
            "muğla"});
            this.cmbSehir.Location = new System.Drawing.Point(113, 174);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 24);
            this.cmbSehir.TabIndex = 9;
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 16;
            this.lstKisiler.Location = new System.Drawing.Point(376, 65);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(332, 452);
            this.lstKisiler.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Location = new System.Drawing.Point(31, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(7, 39);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(62, 20);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSpor);
            this.groupBox2.Controls.Add(this.cbMuzik);
            this.groupBox2.Controls.Add(this.cbSinema);
            this.groupBox2.Location = new System.Drawing.Point(31, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ilgi alanları";
            // 
            // cbSinema
            // 
            this.cbSinema.AutoSize = true;
            this.cbSinema.Location = new System.Drawing.Point(6, 39);
            this.cbSinema.Name = "cbSinema";
            this.cbSinema.Size = new System.Drawing.Size(73, 20);
            this.cbSinema.TabIndex = 0;
            this.cbSinema.Text = "sinema";
            this.cbSinema.UseVisualStyleBackColor = true;
            // 
            // cbMuzik
            // 
            this.cbMuzik.AutoSize = true;
            this.cbMuzik.Location = new System.Drawing.Point(7, 65);
            this.cbMuzik.Name = "cbMuzik";
            this.cbMuzik.Size = new System.Drawing.Size(63, 20);
            this.cbMuzik.TabIndex = 1;
            this.cbMuzik.Text = "müzik";
            this.cbMuzik.UseVisualStyleBackColor = true;
            // 
            // cbSpor
            // 
            this.cbSpor.AutoSize = true;
            this.cbSpor.Location = new System.Drawing.Point(7, 91);
            this.cbSpor.Name = "cbSpor";
            this.cbSpor.Size = new System.Drawing.Size(56, 20);
            this.cbSpor.TabIndex = 2;
            this.cbSpor.Text = "spor";
            this.cbSpor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "kayıtlı kişiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.nudYas);
            this.Controls.Add(this.dpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.sehir);
            this.Controls.Add(this.dogumTarihi);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Name = "Form1";
            this.Text = "kayıt formu";
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label yas;
        private System.Windows.Forms.Label dogumTarihi;
        private System.Windows.Forms.Label sehir;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dpDogumTarihi;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSpor;
        private System.Windows.Forms.CheckBox cbMuzik;
        private System.Windows.Forms.CheckBox cbSinema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

