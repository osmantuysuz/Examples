namespace isealim
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cbEgitim = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkArapca = new System.Windows.Forms.CheckBox();
            this.chkFransizca = new System.Windows.Forms.CheckBox();
            this.chkRusca = new System.Windows.Forms.CheckBox();
            this.chkIngilizce = new System.Windows.Forms.CheckBox();
            this.chkAlmanca = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkWebTasarim = new System.Windows.Forms.CheckBox();
            this.chkSistem = new System.Windows.Forms.CheckBox();
            this.chkYazilim = new System.Windows.Forms.CheckBox();
            this.chkVeriTabani = new System.Windows.Forms.CheckBox();
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKiz = new System.Windows.Forms.RadioButton();
            this.gbAskerlik = new System.Windows.Forms.GroupBox();
            this.rbTecilli = new System.Windows.Forms.RadioButton();
            this.rbYapilmadi = new System.Windows.Forms.RadioButton();
            this.rbYapildi = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCinsiyet.SuspendLayout();
            this.gbAskerlik.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(167, 121);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(175, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(167, 147);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(175, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "T.C.";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(167, 173);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(175, 20);
            this.txtTc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(167, 225);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(175, 93);
            this.txtAdres.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eğitim Seviyesi";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(167, 199);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 20);
            this.txtTelefon.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Eklemek İstedikleriniz";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(167, 379);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(175, 93);
            this.txtAciklama.TabIndex = 15;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(167, 327);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(175, 20);
            this.dtpTarih.TabIndex = 16;
            // 
            // cbEgitim
            // 
            this.cbEgitim.FormattingEnabled = true;
            this.cbEgitim.Items.AddRange(new object[] {
            "Doktora",
            "Lisans",
            "Önlisans",
            "Lise",
            "Ortaokul",
            "İlkokul"});
            this.cbEgitim.Location = new System.Drawing.Point(167, 353);
            this.cbEgitim.Name = "cbEgitim";
            this.cbEgitim.Size = new System.Drawing.Size(175, 21);
            this.cbEgitim.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.chkArapca);
            this.groupBox1.Controls.Add(this.chkFransizca);
            this.groupBox1.Controls.Add(this.chkRusca);
            this.groupBox1.Controls.Add(this.chkIngilizce);
            this.groupBox1.Controls.Add(this.chkAlmanca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(401, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 120);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yabancı Dil";
            // 
            // chkArapca
            // 
            this.chkArapca.AutoSize = true;
            this.chkArapca.Location = new System.Drawing.Point(129, 59);
            this.chkArapca.Name = "chkArapca";
            this.chkArapca.Size = new System.Drawing.Size(72, 21);
            this.chkArapca.TabIndex = 0;
            this.chkArapca.Text = "Arapça";
            this.chkArapca.UseVisualStyleBackColor = true;
            // 
            // chkFransizca
            // 
            this.chkFransizca.AutoSize = true;
            this.chkFransizca.Location = new System.Drawing.Point(129, 29);
            this.chkFransizca.Name = "chkFransizca";
            this.chkFransizca.Size = new System.Drawing.Size(88, 21);
            this.chkFransizca.TabIndex = 0;
            this.chkFransizca.Text = "Fransızca";
            this.chkFransizca.UseVisualStyleBackColor = true;
            // 
            // chkRusca
            // 
            this.chkRusca.AutoSize = true;
            this.chkRusca.Location = new System.Drawing.Point(6, 84);
            this.chkRusca.Name = "chkRusca";
            this.chkRusca.Size = new System.Drawing.Size(67, 21);
            this.chkRusca.TabIndex = 0;
            this.chkRusca.Text = "Rusça";
            this.chkRusca.UseVisualStyleBackColor = true;
            // 
            // chkIngilizce
            // 
            this.chkIngilizce.AutoSize = true;
            this.chkIngilizce.Location = new System.Drawing.Point(6, 59);
            this.chkIngilizce.Name = "chkIngilizce";
            this.chkIngilizce.Size = new System.Drawing.Size(77, 21);
            this.chkIngilizce.TabIndex = 0;
            this.chkIngilizce.Text = "İngilizce";
            this.chkIngilizce.UseVisualStyleBackColor = true;
            // 
            // chkAlmanca
            // 
            this.chkAlmanca.AutoSize = true;
            this.chkAlmanca.Location = new System.Drawing.Point(6, 29);
            this.chkAlmanca.Name = "chkAlmanca";
            this.chkAlmanca.Size = new System.Drawing.Size(81, 21);
            this.chkAlmanca.TabIndex = 0;
            this.chkAlmanca.Text = "Almanca";
            this.chkAlmanca.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.chkWebTasarim);
            this.groupBox2.Controls.Add(this.chkSistem);
            this.groupBox2.Controls.Add(this.chkYazilim);
            this.groupBox2.Controls.Add(this.chkVeriTabani);
            this.groupBox2.Controls.Add(this.chkOffice);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(401, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 110);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgisayar Bilgisi";
            // 
            // chkWebTasarim
            // 
            this.chkWebTasarim.AutoSize = true;
            this.chkWebTasarim.Location = new System.Drawing.Point(129, 50);
            this.chkWebTasarim.Name = "chkWebTasarim";
            this.chkWebTasarim.Size = new System.Drawing.Size(111, 21);
            this.chkWebTasarim.TabIndex = 0;
            this.chkWebTasarim.Text = "Web Tasarım";
            this.chkWebTasarim.UseVisualStyleBackColor = true;
            // 
            // chkSistem
            // 
            this.chkSistem.AutoSize = true;
            this.chkSistem.Location = new System.Drawing.Point(129, 19);
            this.chkSistem.Name = "chkSistem";
            this.chkSistem.Size = new System.Drawing.Size(69, 21);
            this.chkSistem.TabIndex = 0;
            this.chkSistem.Text = "Sistem";
            this.chkSistem.UseVisualStyleBackColor = true;
            // 
            // chkYazilim
            // 
            this.chkYazilim.AutoSize = true;
            this.chkYazilim.Location = new System.Drawing.Point(6, 19);
            this.chkYazilim.Name = "chkYazilim";
            this.chkYazilim.Size = new System.Drawing.Size(71, 21);
            this.chkYazilim.TabIndex = 0;
            this.chkYazilim.Text = "Yazılım";
            this.chkYazilim.UseVisualStyleBackColor = true;
            // 
            // chkVeriTabani
            // 
            this.chkVeriTabani.AutoSize = true;
            this.chkVeriTabani.Location = new System.Drawing.Point(6, 75);
            this.chkVeriTabani.Name = "chkVeriTabani";
            this.chkVeriTabani.Size = new System.Drawing.Size(100, 21);
            this.chkVeriTabani.TabIndex = 0;
            this.chkVeriTabani.Text = "Veri Tabanı";
            this.chkVeriTabani.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Location = new System.Drawing.Point(6, 49);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(88, 21);
            this.chkOffice.TabIndex = 0;
            this.chkOffice.Text = "MS Office";
            this.chkOffice.UseVisualStyleBackColor = true;
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.BackColor = System.Drawing.Color.SkyBlue;
            this.gbCinsiyet.Controls.Add(this.rbErkek);
            this.gbCinsiyet.Controls.Add(this.rbKiz);
            this.gbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbCinsiyet.Location = new System.Drawing.Point(656, 124);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Size = new System.Drawing.Size(126, 117);
            this.gbCinsiyet.TabIndex = 18;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 56);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(62, 21);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            this.rbErkek.CheckedChanged += new System.EventHandler(this.rbErkek_CheckedChanged);
            // 
            // rbKiz
            // 
            this.rbKiz.AutoSize = true;
            this.rbKiz.Location = new System.Drawing.Point(6, 26);
            this.rbKiz.Name = "rbKiz";
            this.rbKiz.Size = new System.Drawing.Size(45, 21);
            this.rbKiz.TabIndex = 0;
            this.rbKiz.TabStop = true;
            this.rbKiz.Text = "Kız";
            this.rbKiz.UseVisualStyleBackColor = true;
            this.rbKiz.CheckedChanged += new System.EventHandler(this.rbKiz_CheckedChanged);
            // 
            // gbAskerlik
            // 
            this.gbAskerlik.BackColor = System.Drawing.Color.SkyBlue;
            this.gbAskerlik.Controls.Add(this.rbTecilli);
            this.gbAskerlik.Controls.Add(this.rbYapilmadi);
            this.gbAskerlik.Controls.Add(this.rbYapildi);
            this.gbAskerlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAskerlik.Location = new System.Drawing.Point(656, 282);
            this.gbAskerlik.Name = "gbAskerlik";
            this.gbAskerlik.Size = new System.Drawing.Size(126, 110);
            this.gbAskerlik.TabIndex = 18;
            this.gbAskerlik.TabStop = false;
            this.gbAskerlik.Text = "Askerlik Durumu";
            // 
            // rbTecilli
            // 
            this.rbTecilli.AutoSize = true;
            this.rbTecilli.Location = new System.Drawing.Point(6, 75);
            this.rbTecilli.Name = "rbTecilli";
            this.rbTecilli.Size = new System.Drawing.Size(62, 21);
            this.rbTecilli.TabIndex = 0;
            this.rbTecilli.TabStop = true;
            this.rbTecilli.Text = "Tecilli";
            this.rbTecilli.UseVisualStyleBackColor = true;
            // 
            // rbYapilmadi
            // 
            this.rbYapilmadi.AutoSize = true;
            this.rbYapilmadi.Location = new System.Drawing.Point(6, 45);
            this.rbYapilmadi.Name = "rbYapilmadi";
            this.rbYapilmadi.Size = new System.Drawing.Size(87, 21);
            this.rbYapilmadi.TabIndex = 0;
            this.rbYapilmadi.TabStop = true;
            this.rbYapilmadi.Text = "Yapılmadı";
            this.rbYapilmadi.UseVisualStyleBackColor = true;
            // 
            // rbYapildi
            // 
            this.rbYapildi.AutoSize = true;
            this.rbYapildi.Location = new System.Drawing.Point(6, 19);
            this.rbYapildi.Name = "rbYapildi";
            this.rbYapildi.Size = new System.Drawing.Size(68, 21);
            this.rbYapildi.TabIndex = 0;
            this.rbYapildi.TabStop = true;
            this.rbYapildi.Text = "Yapıldı";
            this.rbYapildi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(536, 440);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 32);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(209, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 39);
            this.label9.TabIndex = 20;
            this.label9.Text = "İşe Giriş Başvuru Formu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAskerlik);
            this.Controls.Add(this.gbCinsiyet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEgitim);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            this.gbAskerlik.ResumeLayout(false);
            this.gbAskerlik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cbEgitim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkArapca;
        private System.Windows.Forms.CheckBox chkFransizca;
        private System.Windows.Forms.CheckBox chkRusca;
        private System.Windows.Forms.CheckBox chkIngilizce;
        private System.Windows.Forms.CheckBox chkAlmanca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkWebTasarim;
        private System.Windows.Forms.CheckBox chkSistem;
        private System.Windows.Forms.CheckBox chkYazilim;
        private System.Windows.Forms.CheckBox chkVeriTabani;
        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKiz;
        private System.Windows.Forms.GroupBox gbAskerlik;
        private System.Windows.Forms.RadioButton rbTecilli;
        private System.Windows.Forms.RadioButton rbYapilmadi;
        private System.Windows.Forms.RadioButton rbYapildi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
    }
}

