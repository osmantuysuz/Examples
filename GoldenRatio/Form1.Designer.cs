namespace GoldenRatio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKucukAci = new System.Windows.Forms.TextBox();
            this.txtBuyukAci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.btnUcgen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kısa Kenar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKisaKenar);
            this.groupBox1.Controls.Add(this.txtUzunKenar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altın Dikdörtgen";
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(154, 45);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(100, 23);
            this.txtKisaKenar.TabIndex = 1;
            this.txtKisaKenar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKisaKenar_KeyPress);
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(154, 93);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(100, 23);
            this.txtUzunKenar.TabIndex = 2;
            this.txtUzunKenar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUzunKenar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzun Kenar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKucukAci);
            this.groupBox2.Controls.Add(this.txtBuyukAci);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 159);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altın Üçgen";
            // 
            // txtKucukAci
            // 
            this.txtKucukAci.Location = new System.Drawing.Point(154, 96);
            this.txtKucukAci.Name = "txtKucukAci";
            this.txtKucukAci.Size = new System.Drawing.Size(100, 23);
            this.txtKucukAci.TabIndex = 4;
            this.txtKucukAci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKucukAci_KeyPress);
            // 
            // txtBuyukAci
            // 
            this.txtBuyukAci.Location = new System.Drawing.Point(154, 48);
            this.txtBuyukAci.Name = "txtBuyukAci";
            this.txtBuyukAci.Size = new System.Drawing.Size(100, 23);
            this.txtBuyukAci.TabIndex = 3;
            this.txtBuyukAci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyukAci_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Büyük Açılar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Küçük Açı:";
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDikdortgen.Location = new System.Drawing.Point(122, 177);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(89, 23);
            this.btnDikdortgen.TabIndex = 5;
            this.btnDikdortgen.Text = "Hesapla";
            this.btnDikdortgen.UseVisualStyleBackColor = true;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // btnUcgen
            // 
            this.btnUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcgen.Location = new System.Drawing.Point(505, 177);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(89, 23);
            this.btnUcgen.TabIndex = 6;
            this.btnUcgen.Text = "Hesapla";
            this.btnUcgen.UseVisualStyleBackColor = true;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Altın Dikdörgen; kısa kenarın uzun kenara oranı ile hesaplanır";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kısa kenarın, uzun kenara oranı 1:1,618 olmalıdır.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(394, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Altın Üçgen; eşkenar üçgen olmak zorundadır.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(394, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Altın Üçgen, iç açıları 2:2:1 ile orantılı tek üçgendir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 274);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUcgen);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Altın Oran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKucukAci;
        private System.Windows.Forms.TextBox txtBuyukAci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDikdortgen;
        private System.Windows.Forms.Button btnUcgen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

