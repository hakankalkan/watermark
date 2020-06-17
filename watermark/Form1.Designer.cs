namespace watermark
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resimSec = new System.Windows.Forms.Button();
            this.metinSec = new System.Windows.Forms.Button();
            this.uygula = new System.Windows.Forms.Button();
            this.sifreliResimSec = new System.Windows.Forms.Button();
            this.sifreCoz = new System.Windows.Forms.Button();
            this.sifrelenecekMetin = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(407, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // resimSec
            // 
            this.resimSec.Location = new System.Drawing.Point(21, 319);
            this.resimSec.Name = "resimSec";
            this.resimSec.Size = new System.Drawing.Size(75, 23);
            this.resimSec.TabIndex = 2;
            this.resimSec.Text = "Resim Seç";
            this.resimSec.UseVisualStyleBackColor = true;
            this.resimSec.Click += new System.EventHandler(this.resimSec_Click);
            // 
            // metinSec
            // 
            this.metinSec.Location = new System.Drawing.Point(141, 319);
            this.metinSec.Name = "metinSec";
            this.metinSec.Size = new System.Drawing.Size(75, 23);
            this.metinSec.TabIndex = 3;
            this.metinSec.Text = "Metin seç";
            this.metinSec.UseVisualStyleBackColor = true;
            this.metinSec.Click += new System.EventHandler(this.metinSec_Click);
            // 
            // uygula
            // 
            this.uygula.Location = new System.Drawing.Point(255, 319);
            this.uygula.Name = "uygula";
            this.uygula.Size = new System.Drawing.Size(75, 23);
            this.uygula.TabIndex = 4;
            this.uygula.Text = "Uygula";
            this.uygula.UseVisualStyleBackColor = true;
            this.uygula.Click += new System.EventHandler(this.uygula_Click);
            // 
            // sifreliResimSec
            // 
            this.sifreliResimSec.Location = new System.Drawing.Point(407, 321);
            this.sifreliResimSec.Name = "sifreliResimSec";
            this.sifreliResimSec.Size = new System.Drawing.Size(96, 23);
            this.sifreliResimSec.TabIndex = 5;
            this.sifreliResimSec.Text = "Şifreli Resim Seç";
            this.sifreliResimSec.UseVisualStyleBackColor = true;
            this.sifreliResimSec.Click += new System.EventHandler(this.sifreliResimSec_Click);
            // 
            // sifreCoz
            // 
            this.sifreCoz.Location = new System.Drawing.Point(641, 321);
            this.sifreCoz.Name = "sifreCoz";
            this.sifreCoz.Size = new System.Drawing.Size(75, 23);
            this.sifreCoz.TabIndex = 8;
            this.sifreCoz.Text = "Şifre Çöz";
            this.sifreCoz.UseVisualStyleBackColor = true;
            this.sifreCoz.Click += new System.EventHandler(this.sifreCoz_Click);
            // 
            // sifrelenecekMetin
            // 
            this.sifrelenecekMetin.Location = new System.Drawing.Point(21, 350);
            this.sifrelenecekMetin.Name = "sifrelenecekMetin";
            this.sifrelenecekMetin.Size = new System.Drawing.Size(747, 331);
            this.sifrelenecekMetin.TabIndex = 9;
            this.sifrelenecekMetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 693);
            this.Controls.Add(this.sifrelenecekMetin);
            this.Controls.Add(this.sifreCoz);
            this.Controls.Add(this.sifreliResimSec);
            this.Controls.Add(this.uygula);
            this.Controls.Add(this.metinSec);
            this.Controls.Add(this.resimSec);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button resimSec;
        private System.Windows.Forms.Button metinSec;
        private System.Windows.Forms.Button uygula;
        private System.Windows.Forms.Button sifreliResimSec;
        private System.Windows.Forms.Button sifreCoz;
        private System.Windows.Forms.RichTextBox sifrelenecekMetin;
    }
}

