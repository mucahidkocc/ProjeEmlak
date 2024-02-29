namespace ProjeEmlak
{
    partial class form_kayitMusteri
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
            label1 = new Label();
            lbl_kullaniciAdi = new Label();
            lbl_sifre = new Label();
            lbl_isim = new Label();
            lbl_soyad = new Label();
            lbl_telNo = new Label();
            lbl_mail = new Label();
            lbl_adres = new Label();
            tb_kullaniciAdi = new TextBox();
            tb_sifre = new TextBox();
            tb_ad = new TextBox();
            tb_soyad = new TextBox();
            tb_telNo = new TextBox();
            tb_mail = new TextBox();
            tb_adres = new TextBox();
            btn_kaydetmusteri = new Button();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Lütfen bilgilerinizi giriniz";
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Location = new Point(52, 57);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(79, 15);
            lbl_kullaniciAdi.TabIndex = 0;
            lbl_kullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(52, 82);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(36, 15);
            lbl_sifre.TabIndex = 0;
            lbl_sifre.Text = "Şifre: ";
            // 
            // lbl_isim
            // 
            lbl_isim.AutoSize = true;
            lbl_isim.Location = new Point(52, 110);
            lbl_isim.Name = "lbl_isim";
            lbl_isim.Size = new Size(28, 15);
            lbl_isim.TabIndex = 0;
            lbl_isim.Text = "Ad: ";
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(52, 137);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(45, 15);
            lbl_soyad.TabIndex = 0;
            lbl_soyad.Text = "Soyad: ";
            // 
            // lbl_telNo
            // 
            lbl_telNo.AutoSize = true;
            lbl_telNo.Location = new Point(52, 163);
            lbl_telNo.Name = "lbl_telNo";
            lbl_telNo.Size = new Size(49, 15);
            lbl_telNo.TabIndex = 0;
            lbl_telNo.Text = "Tel. No: ";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.Location = new Point(52, 190);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(36, 15);
            lbl_mail.TabIndex = 0;
            lbl_mail.Text = "Mail: ";
            // 
            // lbl_adres
            // 
            lbl_adres.AutoSize = true;
            lbl_adres.Location = new Point(52, 216);
            lbl_adres.Name = "lbl_adres";
            lbl_adres.Size = new Size(43, 15);
            lbl_adres.TabIndex = 0;
            lbl_adres.Text = "Adres: ";
            // 
            // tb_kullaniciAdi
            // 
            tb_kullaniciAdi.Location = new Point(147, 49);
            tb_kullaniciAdi.Name = "tb_kullaniciAdi";
            tb_kullaniciAdi.Size = new Size(100, 23);
            tb_kullaniciAdi.TabIndex = 0;
            // 
            // tb_sifre
            // 
            tb_sifre.Location = new Point(147, 74);
            tb_sifre.Name = "tb_sifre";
            tb_sifre.PasswordChar = '*';
            tb_sifre.Size = new Size(100, 23);
            tb_sifre.TabIndex = 1;
            // 
            // tb_ad
            // 
            tb_ad.Location = new Point(147, 102);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(100, 23);
            tb_ad.TabIndex = 2;
            // 
            // tb_soyad
            // 
            tb_soyad.Location = new Point(147, 129);
            tb_soyad.Name = "tb_soyad";
            tb_soyad.Size = new Size(100, 23);
            tb_soyad.TabIndex = 3;
            // 
            // tb_telNo
            // 
            tb_telNo.Location = new Point(147, 155);
            tb_telNo.Name = "tb_telNo";
            tb_telNo.Size = new Size(100, 23);
            tb_telNo.TabIndex = 4;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(147, 182);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(100, 23);
            tb_mail.TabIndex = 5;
            // 
            // tb_adres
            // 
            tb_adres.Location = new Point(147, 208);
            tb_adres.Name = "tb_adres";
            tb_adres.Size = new Size(100, 23);
            tb_adres.TabIndex = 6;
            // 
            // btn_kaydetmusteri
            // 
            btn_kaydetmusteri.Location = new Point(52, 263);
            btn_kaydetmusteri.Name = "btn_kaydetmusteri";
            btn_kaydetmusteri.Size = new Size(75, 23);
            btn_kaydetmusteri.TabIndex = 7;
            btn_kaydetmusteri.Text = "Kaydet";
            btn_kaydetmusteri.UseVisualStyleBackColor = true;
            btn_kaydetmusteri.Click += btn_kaydetmusteri_Click;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(172, 263);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(75, 23);
            btn_giris.TabIndex = 7;
            btn_giris.Text = "Giriş Sayfası";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // form_kayitMusteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 333);
            Controls.Add(btn_giris);
            Controls.Add(btn_kaydetmusteri);
            Controls.Add(tb_adres);
            Controls.Add(tb_mail);
            Controls.Add(tb_telNo);
            Controls.Add(tb_soyad);
            Controls.Add(tb_ad);
            Controls.Add(tb_sifre);
            Controls.Add(tb_kullaniciAdi);
            Controls.Add(lbl_adres);
            Controls.Add(lbl_mail);
            Controls.Add(lbl_telNo);
            Controls.Add(lbl_soyad);
            Controls.Add(lbl_isim);
            Controls.Add(lbl_sifre);
            Controls.Add(lbl_kullaniciAdi);
            Controls.Add(label1);
            Name = "form_kayitMusteri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_kullaniciAdi;
        private Label lbl_sifre;
        private Label lbl_isim;
        private Label lbl_soyad;
        private Label lbl_telNo;
        private Label lbl_mail;
        private Label lbl_adres;
        private TextBox tb_kullaniciAdi;
        private TextBox tb_sifre;
        private TextBox tb_ad;
        private TextBox tb_soyad;
        private TextBox tb_telNo;
        private TextBox tb_mail;
        private TextBox tb_adres;
        private Button btn_kaydetmusteri;
        private Button btn_giris;
    }
}