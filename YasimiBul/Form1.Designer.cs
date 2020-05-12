namespace YasimiBul
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
            this.components = new System.ComponentModel.Container();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYasimiBul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamGun = new System.Windows.Forms.TextBox();
            this.txtToplamSaat = new System.Windows.Forms.TextBox();
            this.txtToplamDakika = new System.Windows.Forms.TextBox();
            this.tmrYasam = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(15, 48);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtDogumTarihi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğum Tarihinizi Seçiniz";
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtYas.Location = new System.Drawing.Point(15, 247);
            this.txtYas.Multiline = true;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 2;
            this.txtYas.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yaşınız";
            // 
            // btnYasimiBul
            // 
            this.btnYasimiBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYasimiBul.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYasimiBul.ForeColor = System.Drawing.Color.Red;
            this.btnYasimiBul.Location = new System.Drawing.Point(134, 188);
            this.btnYasimiBul.Name = "btnYasimiBul";
            this.btnYasimiBul.Size = new System.Drawing.Size(100, 31);
            this.btnYasimiBul.TabIndex = 4;
            this.btnYasimiBul.Text = "Yaşımı Bul";
            this.btnYasimiBul.UseVisualStyleBackColor = false;
            this.btnYasimiBul.Click += new System.EventHandler(this.btnYasimiBul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Gün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam Dakika";
            // 
            // txtToplamGun
            // 
            this.txtToplamGun.Location = new System.Drawing.Point(115, 88);
            this.txtToplamGun.Name = "txtToplamGun";
            this.txtToplamGun.Size = new System.Drawing.Size(138, 20);
            this.txtToplamGun.TabIndex = 8;
            // 
            // txtToplamSaat
            // 
            this.txtToplamSaat.Location = new System.Drawing.Point(115, 127);
            this.txtToplamSaat.Name = "txtToplamSaat";
            this.txtToplamSaat.Size = new System.Drawing.Size(138, 20);
            this.txtToplamSaat.TabIndex = 9;
            // 
            // txtToplamDakika
            // 
            this.txtToplamDakika.Location = new System.Drawing.Point(115, 162);
            this.txtToplamDakika.Name = "txtToplamDakika";
            this.txtToplamDakika.Size = new System.Drawing.Size(138, 20);
            this.txtToplamDakika.TabIndex = 10;
            // 
            // tmrYasam
            // 
            this.tmrYasam.Interval = 1000;
            this.tmrYasam.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 279);
            this.Controls.Add(this.txtToplamDakika);
            this.Controls.Add(this.txtToplamSaat);
            this.Controls.Add(this.txtToplamGun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYasimiBul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDogumTarihi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYasimiBul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToplamGun;
        private System.Windows.Forms.TextBox txtToplamSaat;
        private System.Windows.Forms.TextBox txtToplamDakika;
        private System.Windows.Forms.Timer tmrYasam;
    }
}

