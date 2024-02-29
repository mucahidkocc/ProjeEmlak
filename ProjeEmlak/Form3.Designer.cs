namespace ProjeEmlak
{
    partial class form_kayitisyeri
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
            lbl_kullaniciAdi = new Label();
            lbl_sifre = new Label();
            lbl_isletmeAdi = new Label();
            lbl_yetkili = new Label();
            lbl_telNo = new Label();
            lbl_mail = new Label();
            lbl_adres = new Label();
            tb_kullaniciadi = new TextBox();
            tb_sifre = new TextBox();
            tb_isletmeAdi = new TextBox();
            tb_yetkili = new TextBox();
            tb_adres = new TextBox();
            tb_telNo = new TextBox();
            tb_mail = new TextBox();
            label8 = new Label();
            btn_isyeriKaydet = new Button();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Location = new Point(53, 96);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(79, 15);
            lbl_kullaniciAdi.TabIndex = 0;
            lbl_kullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(53, 124);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(36, 15);
            lbl_sifre.TabIndex = 0;
            lbl_sifre.Text = "Şifre: ";
            // 
            // lbl_isletmeAdi
            // 
            lbl_isletmeAdi.AutoSize = true;
            lbl_isletmeAdi.Location = new Point(53, 153);
            lbl_isletmeAdi.Name = "lbl_isletmeAdi";
            lbl_isletmeAdi.Size = new Size(72, 15);
            lbl_isletmeAdi.TabIndex = 0;
            lbl_isletmeAdi.Text = "İşletme Adı: ";
            // 
            // lbl_yetkili
            // 
            lbl_yetkili.AutoSize = true;
            lbl_yetkili.Location = new Point(53, 184);
            lbl_yetkili.Name = "lbl_yetkili";
            lbl_yetkili.Size = new Size(65, 15);
            lbl_yetkili.TabIndex = 0;
            lbl_yetkili.Text = "Yetkili Kişi: ";
            // 
            // lbl_telNo
            // 
            lbl_telNo.AutoSize = true;
            lbl_telNo.Location = new Point(53, 213);
            lbl_telNo.Name = "lbl_telNo";
            lbl_telNo.Size = new Size(49, 15);
            lbl_telNo.TabIndex = 0;
            lbl_telNo.Text = "Tel. No: ";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.Location = new Point(53, 242);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(36, 15);
            lbl_mail.TabIndex = 0;
            lbl_mail.Text = "Mail: ";
            // 
            // lbl_adres
            // 
            lbl_adres.AutoSize = true;
            lbl_adres.Location = new Point(53, 270);
            lbl_adres.Name = "lbl_adres";
            lbl_adres.Size = new Size(43, 15);
            lbl_adres.TabIndex = 0;
            lbl_adres.Text = "Adres: ";
            // 
            // tb_kullaniciadi
            // 
            tb_kullaniciadi.Location = new Point(138, 88);
            tb_kullaniciadi.Name = "tb_kullaniciadi";
            tb_kullaniciadi.Size = new Size(100, 23);
            tb_kullaniciadi.TabIndex = 0;
            // 
            // tb_sifre
            // 
            tb_sifre.Location = new Point(138, 116);
            tb_sifre.Name = "tb_sifre";
            tb_sifre.PasswordChar = '*';
            tb_sifre.Size = new Size(100, 23);
            tb_sifre.TabIndex = 1;
            // 
            // tb_isletmeAdi
            // 
            tb_isletmeAdi.Location = new Point(138, 145);
            tb_isletmeAdi.Name = "tb_isletmeAdi";
            tb_isletmeAdi.Size = new Size(100, 23);
            tb_isletmeAdi.TabIndex = 2;
            // 
            // tb_yetkili
            // 
            tb_yetkili.Location = new Point(138, 174);
            tb_yetkili.Name = "tb_yetkili";
            tb_yetkili.Size = new Size(100, 23);
            tb_yetkili.TabIndex = 3;
            // 
            // tb_adres
            // 
            tb_adres.Location = new Point(138, 262);
            tb_adres.Name = "tb_adres";
            tb_adres.Size = new Size(100, 23);
            tb_adres.TabIndex = 6;
            // 
            // tb_telNo
            // 
            tb_telNo.Location = new Point(138, 203);
            tb_telNo.Name = "tb_telNo";
            tb_telNo.Size = new Size(100, 23);
            tb_telNo.TabIndex = 4;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(138, 234);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(100, 23);
            tb_mail.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 53);
            label8.Name = "label8";
            label8.Size = new Size(158, 15);
            label8.TabIndex = 2;
            label8.Text = "Lütfen işyeri bilgilerini giriniz";
            // 
            // btn_isyeriKaydet
            // 
            btn_isyeriKaydet.Location = new Point(53, 304);
            btn_isyeriKaydet.Name = "btn_isyeriKaydet";
            btn_isyeriKaydet.Size = new Size(75, 23);
            btn_isyeriKaydet.TabIndex = 7;
            btn_isyeriKaydet.Text = "Kaydet";
            btn_isyeriKaydet.UseVisualStyleBackColor = true;
            btn_isyeriKaydet.Click += btn_isyeriKaydet_Click;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(163, 304);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(75, 23);
            btn_giris.TabIndex = 7;
            btn_giris.Text = "Giriş Sayfası";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // form_kayitisyeri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 385);
            Controls.Add(btn_giris);
            Controls.Add(btn_isyeriKaydet);
            Controls.Add(label8);
            Controls.Add(tb_mail);
            Controls.Add(tb_telNo);
            Controls.Add(tb_adres);
            Controls.Add(tb_yetkili);
            Controls.Add(tb_isletmeAdi);
            Controls.Add(tb_sifre);
            Controls.Add(tb_kullaniciadi);
            Controls.Add(lbl_adres);
            Controls.Add(lbl_mail);
            Controls.Add(lbl_telNo);
            Controls.Add(lbl_yetkili);
            Controls.Add(lbl_isletmeAdi);
            Controls.Add(lbl_sifre);
            Controls.Add(lbl_kullaniciAdi);
            Name = "form_kayitisyeri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İşyeri Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_kullaniciAdi;
        private Label lbl_sifre;
        private Label lbl_isletmeAdi;
        private Label lbl_yetkili;
        private Label lbl_telNo;
        private Label lbl_mail;
        private Label lbl_adres;
        private TextBox tb_kullaniciadi;
        private TextBox tb_sifre;
        private TextBox tb_isletmeAdi;
        private TextBox tb_yetkili;
        private TextBox tb_adres;
        private TextBox tb_telNo;
        private TextBox tb_mail;
        private Label label8;
        private Button btn_isyeriKaydet;
        private Button btn_giris;
    }
}