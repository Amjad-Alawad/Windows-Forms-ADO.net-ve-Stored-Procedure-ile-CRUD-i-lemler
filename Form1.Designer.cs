using System;
using System.Collections.Generic;

namespace uyggulama
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.listTedarikci = new System.Windows.Forms.ComboBox();
            this.listKategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnArapr = new System.Windows.Forms.Button();
            this.btnGuncellepr = new System.Windows.Forms.Button();
            this.btnSilpr = new System.Windows.Forms.Button();
            this.btnEklepr = new System.Windows.Forms.Button();
            this.txtUrunSil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(583, 101);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 51);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.DecimalPlaces = 2;
            this.txtBirimFiyat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtBirimFiyat.Location = new System.Drawing.Point(168, 47);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(155, 22);
            this.txtBirimFiyat.TabIndex = 1;
            // 
            // listTedarikci
            // 
            this.listTedarikci.FormattingEnabled = true;
            this.listTedarikci.Location = new System.Drawing.Point(329, 47);
            this.listTedarikci.Name = "listTedarikci";
            this.listTedarikci.Size = new System.Drawing.Size(121, 24);
            this.listTedarikci.TabIndex = 3;
            // 
            // listKategori
            // 
            this.listKategori.FormattingEnabled = true;
            this.listKategori.Location = new System.Drawing.Point(456, 47);
            this.listKategori.Name = "listKategori";
            this.listKategori.Size = new System.Drawing.Size(121, 24);
            this.listKategori.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 337);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(30, 48);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(130, 22);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(583, 172);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 51);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "guncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(583, 321);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(132, 51);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Urun adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tedarikçi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kategori";
            // 
            // btnArapr
            // 
            this.btnArapr.Location = new System.Drawing.Point(721, 321);
            this.btnArapr.Name = "btnArapr";
            this.btnArapr.Size = new System.Drawing.Size(132, 51);
            this.btnArapr.TabIndex = 17;
            this.btnArapr.Text = "ara";
            this.btnArapr.UseVisualStyleBackColor = true;
            this.btnArapr.Click += new System.EventHandler(this.btnAra_Click);
            



            // 
            // btnGuncellepr
            // 
            this.btnGuncellepr.Location = new System.Drawing.Point(721, 244);
            this.btnGuncellepr.Name = "btnGuncellepr";
            this.btnGuncellepr.Size = new System.Drawing.Size(132, 51);
            this.btnGuncellepr.TabIndex = 16;
            this.btnGuncellepr.Text = "guncelle";
            this.btnGuncellepr.UseVisualStyleBackColor = true;
            this.btnGuncellepr.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSilpr
            // 
            this.btnSilpr.Location = new System.Drawing.Point(721, 172);
            this.btnSilpr.Name = "btnSilpr";
            this.btnSilpr.Size = new System.Drawing.Size(132, 51);
            this.btnSilpr.TabIndex = 15;
            this.btnSilpr.Text = "sil";
            this.btnSilpr.UseVisualStyleBackColor = true;
            this.btnSilpr.Click += new System.EventHandler(this.btnSilpr_Click);
            // 
            // btnEklepr
            // 
            this.btnEklepr.Location = new System.Drawing.Point(721, 101);
            this.btnEklepr.Name = "btnEklepr";
            this.btnEklepr.Size = new System.Drawing.Size(132, 51);
            this.btnEklepr.TabIndex = 14;
            this.btnEklepr.Text = "ekle";
            this.btnEklepr.UseVisualStyleBackColor = true;
            this.btnEklepr.Click += new System.EventHandler(this.btnEklepr_Click);
            // 
            // txtUrunSil
            // 
            this.txtUrunSil.Location = new System.Drawing.Point(627, 49);
            this.txtUrunSil.Name = "txtUrunSil";
            this.txtUrunSil.Size = new System.Drawing.Size(210, 22);
            this.txtUrunSil.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunSil);
            this.Controls.Add(this.btnArapr);
            this.Controls.Add(this.btnGuncellepr);
            this.Controls.Add(this.btnSilpr);
            this.Controls.Add(this.btnEklepr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listKategori);
            this.Controls.Add(this.listTedarikci);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<EventHandler>.Default.Equals(btnEklepr_Click, form.btnEklepr_Click);
        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown txtBirimFiyat;
        private System.Windows.Forms.ComboBox listTedarikci;
        private System.Windows.Forms.ComboBox listKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private EventHandler label3_Click;
        private EventHandler button4_Click;
        private System.Windows.Forms.Button btnArapr;
        private System.Windows.Forms.Button btnGuncellepr;
        private System.Windows.Forms.Button btnSilpr;
        private System.Windows.Forms.Button btnEklepr;
        private System.Windows.Forms.TextBox txtUrunSil;
        private System.Windows.Forms.Label label5;
        private EventHandler btnSilpr_Click1;

        
    }
}

