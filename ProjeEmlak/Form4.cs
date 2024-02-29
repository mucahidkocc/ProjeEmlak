using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeEmlak
{
    public partial class form_kayitMusteri : Form
    {
        public form_kayitMusteri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=emlak; user ID = postgres; password=sa ");
        private void btn_kaydetmusteri_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand kom_kullaniciAra = new NpgsqlCommand("select musteri_kullaniciadi from musteri_tablo where musteri_kullaniciadi =" +
                "('" + tb_kullaniciAdi.Text + "')", baglanti);
            NpgsqlDataReader ara_kullaniciAdi = kom_kullaniciAra.ExecuteReader();
            if (ara_kullaniciAdi.Read())
                MessageBox.Show("Seçtiğiniz kullanıcı adı kullanılıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(tb_kullaniciAdi.Text) || string.IsNullOrWhiteSpace(tb_sifre.Text))
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ara_kullaniciAdi.Close();
            }
            else
            {
                ara_kullaniciAdi.Close();

                string ekle = "insert into musteri_tablo (musteri_kullaniciadi,musteri_sifre,musteri_ad,musteri_soyad,musteri_tel,musteri_mail,musteri_adres) " +
                    "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
                cmd.Parameters.AddWithValue("@p1", tb_kullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@p2", tb_sifre.Text);
                cmd.Parameters.AddWithValue("@p3", tb_ad.Text);
                cmd.Parameters.AddWithValue("@p4", tb_soyad.Text);
                cmd.Parameters.AddWithValue("@p5", tb_telNo.Text);
                cmd.Parameters.AddWithValue("@p6", tb_mail.Text);
                cmd.Parameters.AddWithValue("@p7", tb_adres.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kaydınız tamamlandı");
            }

            baglanti.Close();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Form giris = new formGiris();
            giris.Show();
            this.Hide();
        }
    }
}
