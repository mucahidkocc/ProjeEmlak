using Npgsql;
using System.Windows.Forms;

namespace ProjeEmlak
{
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=emlak; user ID = postgres; password=sa ");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (rb_isyeri.Checked)
            {
                NpgsqlCommand komutik = new NpgsqlCommand("select isletme_kullaniciadi from isletme_tablo where isletme_kullaniciadi= '" + tbKullaniciadi.Text + "'", baglanti);
                NpgsqlDataReader okuik = komutik.ExecuteReader();
                if (okuik.Read())
                {
                    okuik.Close();
                    NpgsqlCommand komutis = new NpgsqlCommand("select isletme_sifre from isletme_tablo where isletme_sifre= '" + tbSifre.Text + "'", baglanti);
                    NpgsqlDataReader okuis = komutis.ExecuteReader();
                    if (okuis.Read())
                    {
                        okuis.Close();
                        Form anaEkran = new form_isyeriAnaekran();
                        anaEkran.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Parola Hatalý", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Bilgileri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rb_musteri.Checked)
            {
                NpgsqlCommand komutmk = new NpgsqlCommand("select musteri_kullaniciadi from musteri_tablo where musteri_kullaniciadi= '" + tbKullaniciadi.Text + "'", baglanti);
                NpgsqlDataReader okumk = komutmk.ExecuteReader();
                if (okumk.Read())
                {
                    okumk.Close();
                    NpgsqlCommand komutms = new NpgsqlCommand("select musteri_sifre from musteri_tablo where musteri_sifre= '" + tbSifre.Text + "'", baglanti);
                    NpgsqlDataReader okums = komutms.ExecuteReader();
                    if (okums.Read())
                    {
                        okums.Close();
                        Form anaEkran = new form_musteriAnaekran();
                        anaEkran.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Parola Hatalý", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Bilgileri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lütfen Ýþletme / Müþteri seçimi yapýnýz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            baglanti.Close();
        }


        private void btnKayitol_Click(object sender, EventArgs e)
        {
            Form kayit = new formSecim();
            kayit.Show();
            this.Hide();
        }
    }
}
