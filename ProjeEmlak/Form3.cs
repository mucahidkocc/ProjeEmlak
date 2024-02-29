using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeEmlak
{
    public partial class form_kayitisyeri : Form
    {
        public form_kayitisyeri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=emlak; user ID = postgres; password=sa ");

        private void btn_isyeriKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand kom_kullaniciAra = new NpgsqlCommand("select isletme_kullaniciadi from isletme_tablo where isletme_kullaniciadi =('" + tb_kullaniciadi.Text + "')", baglanti);
            NpgsqlDataReader ara_kullaniciAdi = kom_kullaniciAra.ExecuteReader();
            if (ara_kullaniciAdi.Read())
            {
                MessageBox.Show("Seçtiğiniz kullanıcı adı kullanılıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(tb_kullaniciadi.Text) || string.IsNullOrWhiteSpace(tb_sifre.Text))
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ara_kullaniciAdi.Close();
            }
            else
            {
                ara_kullaniciAdi.Close();
                string ekle = "insert into isletme_tablo (isletme_kullaniciadi,isletme_sifre,isletme_adi,isletme_yetkili,isletme_tel,isletme_mail,isletme_adres) " +
                    "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
                cmd.Parameters.AddWithValue("@p1", tb_kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@p2", tb_sifre.Text);
                cmd.Parameters.AddWithValue("@p3", tb_isletmeAdi.Text);
                cmd.Parameters.AddWithValue("@p4", tb_yetkili.Text);
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
