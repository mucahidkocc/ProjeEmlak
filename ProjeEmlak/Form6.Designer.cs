namespace ProjeEmlak
{
    partial class form_musteriAnaekran
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_emlakTur = new TextBox();
            tb_oda = new TextBox();
            tb_daireKat = new TextBox();
            tb_min_m2 = new TextBox();
            tb_binaKat = new TextBox();
            tb_isinma = new TextBox();
            btn_emlakAra = new Button();
            dgv_musteri = new DataGridView();
            cb_il = new ComboBox();
            cb_ilce = new ComboBox();
            lbl_fiyat = new Label();
            tb_minFiyat = new TextBox();
            tb_max_m2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            tb_maxFiyat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_musteri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 26);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 0;
            label1.Text = "Aramak iştediğiniz emlak bilgilerini giriniz: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Emlak Türü: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 92);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 1;
            label3.Text = "İl:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "İlçe: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 150);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 1;
            label5.Text = "Max. Bina Katı: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 179);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 1;
            label6.Text = "Daire Katı: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 208);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 1;
            label7.Text = "Min. Metrekare: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 266);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 1;
            label8.Text = "Oda Sayısı: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 295);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 1;
            label9.Text = "Isınma Türü: ";
            // 
            // tb_emlakTur
            // 
            tb_emlakTur.Location = new Point(190, 55);
            tb_emlakTur.Name = "tb_emlakTur";
            tb_emlakTur.Size = new Size(121, 23);
            tb_emlakTur.TabIndex = 0;
            // 
            // tb_oda
            // 
            tb_oda.Location = new Point(190, 258);
            tb_oda.Name = "tb_oda";
            tb_oda.Size = new Size(121, 23);
            tb_oda.TabIndex = 6;
            // 
            // tb_daireKat
            // 
            tb_daireKat.Location = new Point(190, 171);
            tb_daireKat.Name = "tb_daireKat";
            tb_daireKat.Size = new Size(121, 23);
            tb_daireKat.TabIndex = 4;
            // 
            // tb_min_m2
            // 
            tb_min_m2.Location = new Point(190, 200);
            tb_min_m2.Name = "tb_min_m2";
            tb_min_m2.Size = new Size(121, 23);
            tb_min_m2.TabIndex = 5;
            // 
            // tb_binaKat
            // 
            tb_binaKat.Location = new Point(190, 142);
            tb_binaKat.Name = "tb_binaKat";
            tb_binaKat.Size = new Size(121, 23);
            tb_binaKat.TabIndex = 3;
            // 
            // tb_isinma
            // 
            tb_isinma.Location = new Point(190, 287);
            tb_isinma.Name = "tb_isinma";
            tb_isinma.Size = new Size(121, 23);
            tb_isinma.TabIndex = 7;
            // 
            // btn_emlakAra
            // 
            btn_emlakAra.Location = new Point(120, 389);
            btn_emlakAra.Name = "btn_emlakAra";
            btn_emlakAra.Size = new Size(108, 36);
            btn_emlakAra.TabIndex = 9;
            btn_emlakAra.Text = "Ara";
            btn_emlakAra.UseVisualStyleBackColor = true;
            btn_emlakAra.Click += btn_emlakAra_Click;
            // 
            // dgv_musteri
            // 
            dgv_musteri.AllowUserToAddRows = false;
            dgv_musteri.AllowUserToDeleteRows = false;
            dgv_musteri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_musteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_musteri.Location = new Point(344, 12);
            dgv_musteri.Name = "dgv_musteri";
            dgv_musteri.ReadOnly = true;
            dgv_musteri.Size = new Size(410, 443);
            dgv_musteri.TabIndex = 11;
            // 
            // cb_il
            // 
            cb_il.FormattingEnabled = true;
            cb_il.Location = new Point(190, 84);
            cb_il.Name = "cb_il";
            cb_il.Size = new Size(121, 23);
            cb_il.TabIndex = 1;
            cb_il.SelectedIndexChanged += cb_il_SelectedIndexChanged;
            // 
            // cb_ilce
            // 
            cb_ilce.FormattingEnabled = true;
            cb_ilce.Location = new Point(190, 113);
            cb_ilce.Name = "cb_ilce";
            cb_ilce.Size = new Size(121, 23);
            cb_ilce.TabIndex = 2;
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(59, 324);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(65, 15);
            lbl_fiyat.TabIndex = 17;
            lbl_fiyat.Text = "Min. Fiyat: ";
            // 
            // tb_minFiyat
            // 
            tb_minFiyat.Location = new Point(190, 316);
            tb_minFiyat.Name = "tb_minFiyat";
            tb_minFiyat.Size = new Size(121, 23);
            tb_minFiyat.TabIndex = 8;
            // 
            // tb_max_m2
            // 
            tb_max_m2.Location = new Point(190, 229);
            tb_max_m2.Name = "tb_max_m2";
            tb_max_m2.Size = new Size(121, 23);
            tb_max_m2.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 237);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 19;
            label10.Text = "Max. Metrekare: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 353);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 22;
            label11.Text = "Max. Fiyat: ";
            // 
            // tb_maxFiyat
            // 
            tb_maxFiyat.Location = new Point(190, 345);
            tb_maxFiyat.Name = "tb_maxFiyat";
            tb_maxFiyat.Size = new Size(121, 23);
            tb_maxFiyat.TabIndex = 21;
            // 
            // form_musteriAnaekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 467);
            Controls.Add(label11);
            Controls.Add(tb_maxFiyat);
            Controls.Add(tb_max_m2);
            Controls.Add(label10);
            Controls.Add(lbl_fiyat);
            Controls.Add(tb_minFiyat);
            Controls.Add(cb_ilce);
            Controls.Add(cb_il);
            Controls.Add(dgv_musteri);
            Controls.Add(btn_emlakAra);
            Controls.Add(tb_isinma);
            Controls.Add(tb_oda);
            Controls.Add(tb_binaKat);
            Controls.Add(tb_emlakTur);
            Controls.Add(tb_min_m2);
            Controls.Add(tb_daireKat);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form_musteriAnaekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            Load += form_musteriAnaekran_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_musteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_emlakTur;
        private TextBox tb_oda;
        private TextBox tb_daireKat;
        private TextBox tb_min_m2;
        private TextBox tb_binaKat;
        private TextBox tb_isinma;
        private Button btn_emlakAra;
        private DataGridView dgv_musteri;
        private ComboBox cb_il;
        private ComboBox cb_ilce;
        private Label lbl_fiyat;
        private TextBox tb_minFiyat;
        private TextBox tb_max_m2;
        private Label label10;
        private Label label11;
        private TextBox tb_maxFiyat;
    }
}