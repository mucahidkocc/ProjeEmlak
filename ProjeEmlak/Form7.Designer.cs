namespace ProjeEmlak
{
    partial class form_arama
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
            tb_id = new TextBox();
            dgv_isyeri = new DataGridView();
            lbl_min_fiyat = new Label();
            cb_ilce = new ComboBox();
            cb_il = new ComboBox();
            tb_minFiyat = new TextBox();
            tb_sahibi = new TextBox();
            tb_isinma = new TextBox();
            tb_oda = new TextBox();
            tb_binaKat = new TextBox();
            tb_emlakTur = new TextBox();
            tb_min_m2 = new TextBox();
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
            btn_emlakAra = new Button();
            label10 = new Label();
            btn_anaEkran = new Button();
            lbl_max_fiyat = new Label();
            tb_maxFiyat = new TextBox();
            tb_max_m2 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_isyeri).BeginInit();
            SuspendLayout();
            // 
            // tb_id
            // 
            tb_id.BackColor = SystemColors.Control;
            tb_id.BorderStyle = BorderStyle.None;
            tb_id.Location = new Point(30, -18);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(100, 16);
            tb_id.TabIndex = 46;
            // 
            // dgv_isyeri
            // 
            dgv_isyeri.AllowUserToAddRows = false;
            dgv_isyeri.AllowUserToDeleteRows = false;
            dgv_isyeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_isyeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_isyeri.Location = new Point(398, 12);
            dgv_isyeri.Name = "dgv_isyeri";
            dgv_isyeri.ReadOnly = true;
            dgv_isyeri.Size = new Size(510, 498);
            dgv_isyeri.TabIndex = 45;
            // 
            // lbl_min_fiyat
            // 
            lbl_min_fiyat.AutoSize = true;
            lbl_min_fiyat.Location = new Point(86, 351);
            lbl_min_fiyat.Name = "lbl_min_fiyat";
            lbl_min_fiyat.Size = new Size(65, 15);
            lbl_min_fiyat.TabIndex = 43;
            lbl_min_fiyat.Text = "Min. Fiyat: ";
            // 
            // cb_ilce
            // 
            cb_ilce.FormattingEnabled = true;
            cb_ilce.Location = new Point(217, 113);
            cb_ilce.Name = "cb_ilce";
            cb_ilce.Size = new Size(121, 23);
            cb_ilce.TabIndex = 21;
            // 
            // cb_il
            // 
            cb_il.FormattingEnabled = true;
            cb_il.Location = new Point(217, 84);
            cb_il.Name = "cb_il";
            cb_il.Size = new Size(121, 23);
            cb_il.TabIndex = 20;
            cb_il.SelectedIndexChanged += cb_il_SelectedIndexChanged;
            // 
            // tb_minFiyat
            // 
            tb_minFiyat.Location = new Point(217, 343);
            tb_minFiyat.Name = "tb_minFiyat";
            tb_minFiyat.Size = new Size(121, 23);
            tb_minFiyat.TabIndex = 33;
            // 
            // tb_sahibi
            // 
            tb_sahibi.Location = new Point(217, 317);
            tb_sahibi.Name = "tb_sahibi";
            tb_sahibi.Size = new Size(121, 23);
            tb_sahibi.TabIndex = 31;
            // 
            // tb_isinma
            // 
            tb_isinma.Location = new Point(217, 288);
            tb_isinma.Name = "tb_isinma";
            tb_isinma.Size = new Size(121, 23);
            tb_isinma.TabIndex = 29;
            // 
            // tb_oda
            // 
            tb_oda.Location = new Point(217, 259);
            tb_oda.Name = "tb_oda";
            tb_oda.Size = new Size(121, 23);
            tb_oda.TabIndex = 27;
            // 
            // tb_binaKat
            // 
            tb_binaKat.Location = new Point(217, 142);
            tb_binaKat.Name = "tb_binaKat";
            tb_binaKat.Size = new Size(121, 23);
            tb_binaKat.TabIndex = 22;
            // 
            // tb_emlakTur
            // 
            tb_emlakTur.Location = new Point(217, 55);
            tb_emlakTur.Name = "tb_emlakTur";
            tb_emlakTur.Size = new Size(121, 23);
            tb_emlakTur.TabIndex = 19;
            // 
            // tb_min_m2
            // 
            tb_min_m2.Location = new Point(217, 200);
            tb_min_m2.Name = "tb_min_m2";
            tb_min_m2.Size = new Size(121, 23);
            tb_min_m2.TabIndex = 25;
            // 
            // tb_daireKat
            // 
            tb_daireKat.Location = new Point(217, 171);
            tb_daireKat.Name = "tb_daireKat";
            tb_daireKat.Size = new Size(121, 23);
            tb_daireKat.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 296);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 39;
            label9.Text = "Isınma Türü: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 267);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 36;
            label8.Text = "Oda Sayısı: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 208);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 34;
            label7.Text = "Min.  Metrekare:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 179);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 32;
            label6.Text = "Daire Katı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 150);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 30;
            label5.Text = "Max. Bina Katı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 28;
            label4.Text = "İlçe: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 92);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 26;
            label3.Text = "İl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 40;
            label2.Text = "Emlak Türü: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 26);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 24;
            label1.Text = "Emlak bilgilerini giriniz: ";
            // 
            // btn_emlakAra
            // 
            btn_emlakAra.Location = new Point(233, 412);
            btn_emlakAra.Name = "btn_emlakAra";
            btn_emlakAra.Size = new Size(105, 41);
            btn_emlakAra.TabIndex = 42;
            btn_emlakAra.Text = "Arama";
            btn_emlakAra.UseVisualStyleBackColor = true;
            btn_emlakAra.Click += btn_emlakAra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 325);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 38;
            label10.Text = "Sahibi: ";
            // 
            // btn_anaEkran
            // 
            btn_anaEkran.Location = new Point(86, 412);
            btn_anaEkran.Name = "btn_anaEkran";
            btn_anaEkran.Size = new Size(105, 41);
            btn_anaEkran.TabIndex = 42;
            btn_anaEkran.Text = "Ana Ekran";
            btn_anaEkran.UseVisualStyleBackColor = true;
            btn_anaEkran.Click += btn_anaEkran_Click;
            // 
            // lbl_max_fiyat
            // 
            lbl_max_fiyat.AutoSize = true;
            lbl_max_fiyat.Location = new Point(86, 379);
            lbl_max_fiyat.Name = "lbl_max_fiyat";
            lbl_max_fiyat.Size = new Size(67, 15);
            lbl_max_fiyat.TabIndex = 48;
            lbl_max_fiyat.Text = "Max. Fiyat: ";
            // 
            // tb_maxFiyat
            // 
            tb_maxFiyat.Location = new Point(217, 371);
            tb_maxFiyat.Name = "tb_maxFiyat";
            tb_maxFiyat.Size = new Size(121, 23);
            tb_maxFiyat.TabIndex = 47;
            // 
            // tb_max_m2
            // 
            tb_max_m2.Location = new Point(217, 229);
            tb_max_m2.Name = "tb_max_m2";
            tb_max_m2.Size = new Size(121, 23);
            tb_max_m2.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 237);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 50;
            label11.Text = "Max.  Metrekare:";
            // 
            // form_arama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 522);
            Controls.Add(tb_max_m2);
            Controls.Add(label11);
            Controls.Add(lbl_max_fiyat);
            Controls.Add(tb_maxFiyat);
            Controls.Add(tb_id);
            Controls.Add(dgv_isyeri);
            Controls.Add(lbl_min_fiyat);
            Controls.Add(cb_ilce);
            Controls.Add(cb_il);
            Controls.Add(tb_minFiyat);
            Controls.Add(tb_sahibi);
            Controls.Add(tb_isinma);
            Controls.Add(tb_oda);
            Controls.Add(tb_binaKat);
            Controls.Add(tb_emlakTur);
            Controls.Add(tb_min_m2);
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
            Controls.Add(btn_anaEkran);
            Controls.Add(btn_emlakAra);
            Name = "form_arama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arama Ekranı";
            Load += form_arama_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_isyeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_id;
        private DataGridView dgv_isyeri;
        private Label lbl_min_fiyat;
        private ComboBox cb_ilce;
        private ComboBox cb_il;
        private TextBox tb_minFiyat;
        private TextBox tb_sahibi;
        private TextBox tb_isinma;
        private TextBox tb_oda;
        private TextBox tb_binaKat;
        private TextBox tb_emlakTur;
        private TextBox tb_min_m2;
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
        private Button btn_emlakAra;
        private Label label10;
        private Button btn_anaEkran;
        private Label lbl_max_fiyat;
        private TextBox tb_maxFiyat;
        private TextBox tb_max_m2;
        private Label label11;
    }
}