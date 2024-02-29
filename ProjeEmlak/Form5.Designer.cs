namespace ProjeEmlak
{
    partial class form_isyeriAnaekran
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
            btn_emlakAra = new Button();
            btn_emlakEkle = new Button();
            btn_emlakSil = new Button();
            tb_isinma = new TextBox();
            tb_oda = new TextBox();
            tb_binaKat = new TextBox();
            tb_emlakTur = new TextBox();
            tb_m2 = new TextBox();
            tb_daireKat = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            tb_sahibi = new TextBox();
            cb_il = new ComboBox();
            cb_ilce = new ComboBox();
            btn_emlakGuncelle = new Button();
            lbl_fiyat = new Label();
            tb_fiyat = new TextBox();
            dgv_isyeri = new DataGridView();
            tb_id = new TextBox();
            btn_listele = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_isyeri).BeginInit();
            SuspendLayout();
            // 
            // btn_emlakAra
            // 
            btn_emlakAra.Location = new Point(225, 404);
            btn_emlakAra.Name = "btn_emlakAra";
            btn_emlakAra.Size = new Size(105, 41);
            btn_emlakAra.TabIndex = 13;
            btn_emlakAra.Text = "Arama";
            btn_emlakAra.UseVisualStyleBackColor = true;
            btn_emlakAra.Click += btn_emlakAra_Click;
            // 
            // btn_emlakEkle
            // 
            btn_emlakEkle.Location = new Point(75, 357);
            btn_emlakEkle.Name = "btn_emlakEkle";
            btn_emlakEkle.Size = new Size(105, 41);
            btn_emlakEkle.TabIndex = 10;
            btn_emlakEkle.Text = "Ekle";
            btn_emlakEkle.UseVisualStyleBackColor = true;
            btn_emlakEkle.Click += btn_emlakEkle_Click;
            // 
            // btn_emlakSil
            // 
            btn_emlakSil.Location = new Point(225, 357);
            btn_emlakSil.Name = "btn_emlakSil";
            btn_emlakSil.Size = new Size(105, 41);
            btn_emlakSil.TabIndex = 11;
            btn_emlakSil.Text = "Sil";
            btn_emlakSil.UseVisualStyleBackColor = true;
            btn_emlakSil.Click += btn_emlakSil_Click;
            // 
            // tb_isinma
            // 
            tb_isinma.Location = new Point(209, 263);
            tb_isinma.Name = "tb_isinma";
            tb_isinma.Size = new Size(121, 23);
            tb_isinma.TabIndex = 7;
            // 
            // tb_oda
            // 
            tb_oda.Location = new Point(209, 234);
            tb_oda.Name = "tb_oda";
            tb_oda.Size = new Size(121, 23);
            tb_oda.TabIndex = 6;
            // 
            // tb_binaKat
            // 
            tb_binaKat.Location = new Point(209, 147);
            tb_binaKat.Name = "tb_binaKat";
            tb_binaKat.Size = new Size(121, 23);
            tb_binaKat.TabIndex = 3;
            // 
            // tb_emlakTur
            // 
            tb_emlakTur.Location = new Point(209, 60);
            tb_emlakTur.Name = "tb_emlakTur";
            tb_emlakTur.Size = new Size(121, 23);
            tb_emlakTur.TabIndex = 0;
            // 
            // tb_m2
            // 
            tb_m2.Location = new Point(209, 205);
            tb_m2.Name = "tb_m2";
            tb_m2.Size = new Size(121, 23);
            tb_m2.TabIndex = 5;
            // 
            // tb_daireKat
            // 
            tb_daireKat.Location = new Point(209, 176);
            tb_daireKat.Name = "tb_daireKat";
            tb_daireKat.Size = new Size(121, 23);
            tb_daireKat.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(78, 271);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 11;
            label9.Text = "Isınma Türü: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 242);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 10;
            label8.Text = "Oda Sayısı: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 213);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 9;
            label7.Text = "Metrekare: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 184);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Daire Katı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 155);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 7;
            label5.Text = "Bina Katı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 126);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "İlçe: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 97);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 5;
            label3.Text = "İl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 68);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 12;
            label2.Text = "Emlak Türü: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 31);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 4;
            label1.Text = "Emlak bilgilerini giriniz: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 300);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 11;
            label10.Text = "Sahibi: ";
            // 
            // tb_sahibi
            // 
            tb_sahibi.Location = new Point(209, 292);
            tb_sahibi.Name = "tb_sahibi";
            tb_sahibi.Size = new Size(121, 23);
            tb_sahibi.TabIndex = 8;
            // 
            // cb_il
            // 
            cb_il.FormattingEnabled = true;
            cb_il.Location = new Point(209, 89);
            cb_il.Name = "cb_il";
            cb_il.Size = new Size(121, 23);
            cb_il.TabIndex = 1;
            cb_il.SelectedIndexChanged += cb_il_SelectedIndexChanged;
            // 
            // cb_ilce
            // 
            cb_ilce.FormattingEnabled = true;
            cb_ilce.Location = new Point(209, 118);
            cb_ilce.Name = "cb_ilce";
            cb_ilce.Size = new Size(121, 23);
            cb_ilce.TabIndex = 2;
            // 
            // btn_emlakGuncelle
            // 
            btn_emlakGuncelle.Location = new Point(75, 404);
            btn_emlakGuncelle.Name = "btn_emlakGuncelle";
            btn_emlakGuncelle.Size = new Size(108, 41);
            btn_emlakGuncelle.TabIndex = 12;
            btn_emlakGuncelle.Text = "Güncelle";
            btn_emlakGuncelle.UseVisualStyleBackColor = true;
            btn_emlakGuncelle.Click += btn_emlakGuncelle_Click;
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(78, 326);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(38, 15);
            lbl_fiyat.TabIndex = 15;
            lbl_fiyat.Text = "Fiyat: ";
            // 
            // tb_fiyat
            // 
            tb_fiyat.Location = new Point(209, 318);
            tb_fiyat.Name = "tb_fiyat";
            tb_fiyat.Size = new Size(121, 23);
            tb_fiyat.TabIndex = 9;
            // 
            // dgv_isyeri
            // 
            dgv_isyeri.AllowUserToAddRows = false;
            dgv_isyeri.AllowUserToDeleteRows = false;
            dgv_isyeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_isyeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_isyeri.Location = new Point(365, 12);
            dgv_isyeri.Name = "dgv_isyeri";
            dgv_isyeri.ReadOnly = true;
            dgv_isyeri.Size = new Size(384, 487);
            dgv_isyeri.TabIndex = 17;
            dgv_isyeri.CellClick += dgv_isyeri_CellClick;
            // 
            // tb_id
            // 
            tb_id.BackColor = SystemColors.Control;
            tb_id.BorderStyle = BorderStyle.None;
            tb_id.Location = new Point(9, 12);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(100, 16);
            tb_id.TabIndex = 18;
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(143, 451);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(108, 36);
            btn_listele.TabIndex = 16;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // form_isyeriAnaekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(761, 511);
            Controls.Add(tb_id);
            Controls.Add(dgv_isyeri);
            Controls.Add(btn_listele);
            Controls.Add(lbl_fiyat);
            Controls.Add(btn_emlakGuncelle);
            Controls.Add(cb_ilce);
            Controls.Add(cb_il);
            Controls.Add(tb_fiyat);
            Controls.Add(tb_sahibi);
            Controls.Add(tb_isinma);
            Controls.Add(tb_oda);
            Controls.Add(tb_binaKat);
            Controls.Add(tb_emlakTur);
            Controls.Add(tb_m2);
            Controls.Add(tb_daireKat);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_emlakSil);
            Controls.Add(btn_emlakEkle);
            Controls.Add(btn_emlakAra);
            Name = "form_isyeriAnaekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            Load += form_isyeriAnaekran_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_isyeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_emlakAra;
        private Button btn_emlakEkle;
        private Button btn_emlakSil;
        private TextBox tb_isinma;
        private TextBox tb_oda;
        private TextBox tb_binaKat;
        private TextBox tb_emlakTur;
        private TextBox tb_m2;
        private TextBox tb_daireKat;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private TextBox tb_sahibi;
        private ComboBox cb_il;
        private ComboBox cb_ilce;
        private Button btn_emlakGuncelle;
        private Label lbl_fiyat;
        private TextBox tb_fiyat;
        private DataGridView dgv_isyeri;
        private TextBox tb_id;
        private Button btn_listele;
    }
}