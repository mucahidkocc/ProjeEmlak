namespace ProjeEmlak
{
    partial class formGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKayitol = new Button();
            btnGiris = new Button();
            tbSifre = new TextBox();
            tbKullaniciadi = new TextBox();
            labelSifre = new Label();
            LabelKullaniciadi = new Label();
            rb_isyeri = new RadioButton();
            rb_musteri = new RadioButton();
            SuspendLayout();
            // 
            // btnKayitol
            // 
            btnKayitol.Location = new Point(206, 171);
            btnKayitol.Name = "btnKayitol";
            btnKayitol.Size = new Size(88, 32);
            btnKayitol.TabIndex = 5;
            btnKayitol.Text = "Kayıt Ol";
            btnKayitol.UseVisualStyleBackColor = true;
            btnKayitol.Click += btnKayitol_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(104, 171);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 32);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // tbSifre
            // 
            tbSifre.Location = new Point(194, 119);
            tbSifre.Name = "tbSifre";
            tbSifre.PasswordChar = '*';
            tbSifre.Size = new Size(100, 23);
            tbSifre.TabIndex = 3;
            // 
            // tbKullaniciadi
            // 
            tbKullaniciadi.Location = new Point(194, 63);
            tbKullaniciadi.Name = "tbKullaniciadi";
            tbKullaniciadi.Size = new Size(100, 23);
            tbKullaniciadi.TabIndex = 2;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(108, 119);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(36, 15);
            labelSifre.TabIndex = 11;
            labelSifre.Text = "Şifre: ";
            // 
            // LabelKullaniciadi
            // 
            LabelKullaniciadi.AutoSize = true;
            LabelKullaniciadi.Location = new Point(104, 63);
            LabelKullaniciadi.Name = "LabelKullaniciadi";
            LabelKullaniciadi.Size = new Size(79, 15);
            LabelKullaniciadi.TabIndex = 12;
            LabelKullaniciadi.Text = "Kullanıcı Adı: ";
            // 
            // rb_isyeri
            // 
            rb_isyeri.AutoSize = true;
            rb_isyeri.Location = new Point(108, 27);
            rb_isyeri.Name = "rb_isyeri";
            rb_isyeri.Size = new Size(52, 19);
            rb_isyeri.TabIndex = 0;
            rb_isyeri.TabStop = true;
            rb_isyeri.Text = "İşyeri";
            rb_isyeri.UseVisualStyleBackColor = true;
            // 
            // rb_musteri
            // 
            rb_musteri.AutoSize = true;
            rb_musteri.Location = new Point(229, 27);
            rb_musteri.Name = "rb_musteri";
            rb_musteri.Size = new Size(65, 19);
            rb_musteri.TabIndex = 1;
            rb_musteri.TabStop = true;
            rb_musteri.Text = "Müşteri";
            rb_musteri.UseVisualStyleBackColor = true;
            // 
            // formGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 263);
            Controls.Add(rb_musteri);
            Controls.Add(rb_isyeri);
            Controls.Add(btnKayitol);
            Controls.Add(btnGiris);
            Controls.Add(tbSifre);
            Controls.Add(tbKullaniciadi);
            Controls.Add(labelSifre);
            Controls.Add(LabelKullaniciadi);
            Name = "formGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitol;
        private Button btnGiris;
        private TextBox tbSifre;
        private TextBox tbKullaniciadi;
        private Label labelSifre;
        private Label LabelKullaniciadi;
        private RadioButton rb_isyeri;
        private RadioButton rb_musteri;
    }
}
