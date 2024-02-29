namespace ProjeEmlak
{
    partial class formSecim
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
            btn_musteriKayit = new Button();
            btn_isyeriKayit = new Button();
            SuspendLayout();
            // 
            // btn_musteriKayit
            // 
            btn_musteriKayit.BackColor = SystemColors.GradientInactiveCaption;
            btn_musteriKayit.Location = new Point(70, 118);
            btn_musteriKayit.Name = "btn_musteriKayit";
            btn_musteriKayit.Size = new Size(138, 57);
            btn_musteriKayit.TabIndex = 3;
            btn_musteriKayit.Text = "Müşteri Kayıt";
            btn_musteriKayit.UseVisualStyleBackColor = false;
            btn_musteriKayit.Click += btn_musteriKayit_Click;
            // 
            // btn_isyeriKayit
            // 
            btn_isyeriKayit.BackColor = SystemColors.GradientInactiveCaption;
            btn_isyeriKayit.Location = new Point(70, 52);
            btn_isyeriKayit.Name = "btn_isyeriKayit";
            btn_isyeriKayit.Size = new Size(138, 60);
            btn_isyeriKayit.TabIndex = 2;
            btn_isyeriKayit.Text = "İşyeri Kayıt";
            btn_isyeriKayit.UseVisualStyleBackColor = false;
            btn_isyeriKayit.Click += btn_isyeriKayit_Click;
            // 
            // formSecim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 227);
            Controls.Add(btn_musteriKayit);
            Controls.Add(btn_isyeriKayit);
            Name = "formSecim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seçim Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_musteriKayit;
        private Button btn_isyeriKayit;
    }
}