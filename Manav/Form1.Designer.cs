namespace Manav
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmDomatesKilo = new System.Windows.Forms.NumericUpDown();
            this.nmDomatesFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmPatlicanToplamKilo = new System.Windows.Forms.NumericUpDown();
            this.nmBiberToplamKilo = new System.Windows.Forms.NumericUpDown();
            this.nmDomatesToplamKilo = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmToplamFiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmBiberFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmBiberKilo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nmPatlicanFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmPatlicanKilo = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.yeniMusteri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanToplamKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberToplamKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesToplamKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanKilo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domates";
            // 
            // nmDomatesKilo
            // 
            this.nmDomatesKilo.Location = new System.Drawing.Point(168, 35);
            this.nmDomatesKilo.Name = "nmDomatesKilo";
            this.nmDomatesKilo.Size = new System.Drawing.Size(120, 20);
            this.nmDomatesKilo.TabIndex = 1;
            // 
            // nmDomatesFiyat
            // 
            this.nmDomatesFiyat.Location = new System.Drawing.Point(317, 36);
            this.nmDomatesFiyat.Name = "nmDomatesFiyat";
            this.nmDomatesFiyat.ReadOnly = true;
            this.nmDomatesFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmDomatesFiyat.TabIndex = 2;
            this.nmDomatesFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(165, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(317, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kg Fiyat";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(515, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yeniMusteri);
            this.groupBox1.Controls.Add(this.nmPatlicanToplamKilo);
            this.groupBox1.Controls.Add(this.nmBiberToplamKilo);
            this.groupBox1.Controls.Add(this.nmDomatesToplamKilo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmToplamFiyat);
            this.groupBox1.Location = new System.Drawing.Point(16, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Fiyat";
            // 
            // nmPatlicanToplamKilo
            // 
            this.nmPatlicanToplamKilo.Location = new System.Drawing.Point(399, 80);
            this.nmPatlicanToplamKilo.Name = "nmPatlicanToplamKilo";
            this.nmPatlicanToplamKilo.Size = new System.Drawing.Size(120, 20);
            this.nmPatlicanToplamKilo.TabIndex = 7;
            // 
            // nmBiberToplamKilo
            // 
            this.nmBiberToplamKilo.Location = new System.Drawing.Point(399, 48);
            this.nmBiberToplamKilo.Name = "nmBiberToplamKilo";
            this.nmBiberToplamKilo.Size = new System.Drawing.Size(120, 20);
            this.nmBiberToplamKilo.TabIndex = 6;
            // 
            // nmDomatesToplamKilo
            // 
            this.nmDomatesToplamKilo.Location = new System.Drawing.Point(399, 16);
            this.nmDomatesToplamKilo.Name = "nmDomatesToplamKilo";
            this.nmDomatesToplamKilo.Size = new System.Drawing.Size(120, 20);
            this.nmDomatesToplamKilo.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(300, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Patlıcan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(300, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Biber";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(300, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Domates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(249, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "₺";
            // 
            // nmToplamFiyat
            // 
            this.nmToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmToplamFiyat.Location = new System.Drawing.Point(6, 19);
            this.nmToplamFiyat.Name = "nmToplamFiyat";
            this.nmToplamFiyat.Size = new System.Drawing.Size(237, 30);
            this.nmToplamFiyat.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(443, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(443, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "₺";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(515, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sepete Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(317, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kg Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(165, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kilo";
            // 
            // nmBiberFiyat
            // 
            this.nmBiberFiyat.Location = new System.Drawing.Point(317, 103);
            this.nmBiberFiyat.Name = "nmBiberFiyat";
            this.nmBiberFiyat.ReadOnly = true;
            this.nmBiberFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmBiberFiyat.TabIndex = 10;
            this.nmBiberFiyat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nmBiberKilo
            // 
            this.nmBiberKilo.Location = new System.Drawing.Point(168, 102);
            this.nmBiberKilo.Name = "nmBiberKilo";
            this.nmBiberKilo.Size = new System.Drawing.Size(120, 20);
            this.nmBiberKilo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Biber";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(443, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "₺";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(515, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 20);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sepete Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(317, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Kg Fiyat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(165, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kilo";
            // 
            // nmPatlicanFiyat
            // 
            this.nmPatlicanFiyat.Location = new System.Drawing.Point(317, 173);
            this.nmPatlicanFiyat.Name = "nmPatlicanFiyat";
            this.nmPatlicanFiyat.ReadOnly = true;
            this.nmPatlicanFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmPatlicanFiyat.TabIndex = 17;
            this.nmPatlicanFiyat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nmPatlicanKilo
            // 
            this.nmPatlicanKilo.Location = new System.Drawing.Point(168, 172);
            this.nmPatlicanKilo.Name = "nmPatlicanKilo";
            this.nmPatlicanKilo.Size = new System.Drawing.Size(120, 20);
            this.nmPatlicanKilo.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Patlıcan";
            // 
            // yeniMusteri
            // 
            this.yeniMusteri.BackColor = System.Drawing.Color.Lime;
            this.yeniMusteri.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniMusteri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.yeniMusteri.Location = new System.Drawing.Point(59, 58);
            this.yeniMusteri.Name = "yeniMusteri";
            this.yeniMusteri.Size = new System.Drawing.Size(104, 42);
            this.yeniMusteri.TabIndex = 8;
            this.yeniMusteri.Text = "Yeni Müşteri";
            this.yeniMusteri.UseVisualStyleBackColor = false;
            this.yeniMusteri.Click += new System.EventHandler(this.yeniMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 340);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nmPatlicanFiyat);
            this.Controls.Add(this.nmPatlicanKilo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmBiberFiyat);
            this.Controls.Add(this.nmBiberKilo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmDomatesFiyat);
            this.Controls.Add(this.nmDomatesKilo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Manav Sipariş";
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanToplamKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberToplamKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesToplamKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatlicanKilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmDomatesKilo;
        private System.Windows.Forms.NumericUpDown nmDomatesFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmToplamFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmBiberFiyat;
        private System.Windows.Forms.NumericUpDown nmBiberKilo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmPatlicanFiyat;
        private System.Windows.Forms.NumericUpDown nmPatlicanKilo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmPatlicanToplamKilo;
        private System.Windows.Forms.NumericUpDown nmBiberToplamKilo;
        private System.Windows.Forms.NumericUpDown nmDomatesToplamKilo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button yeniMusteri;
    }
}

