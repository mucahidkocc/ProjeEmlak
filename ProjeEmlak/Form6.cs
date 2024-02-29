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
    public partial class form_musteriAnaekran : Form
    {
        public form_musteriAnaekran()
        {
            InitializeComponent();
        }
        NpgsqlConnection veritabani = new NpgsqlConnection("server=localHost; port=5432; Database=emlak; user ID = postgres; password=sa ");
        private void btn_emlakAra_Click(object sender, EventArgs e)
        {
            int maxBinaKat = 0;
            int minM2 = 0;
            int maxM2 = 0;
            int minFiyat = 0;
            int maxFiyat = 0;

            string sorgu = @"SELECT * FROM emlak_tablo WHERE 
                    emlak_tur LIKE '%" + tb_emlakTur.Text + @"%' 
                    AND emlak_il LIKE '%" + cb_il.Text + @"%'
                    AND emlak_ilce LIKE '%" + cb_ilce.Text + @"%'
                    AND emlak_isinma LIKE '%" + tb_isinma.Text + @"%'";

            if (!string.IsNullOrEmpty(tb_binaKat.Text))
            {
                maxBinaKat = Convert.ToInt32(tb_binaKat.Text);
                sorgu += @" AND emlak_binakat::INTEGER <= " + maxBinaKat;
            }

            if (!string.IsNullOrEmpty(tb_daireKat.Text))
            {
                sorgu += @" AND emlak_dairekat = '" + tb_daireKat.Text + "'";
            }

            if (!string.IsNullOrEmpty(tb_min_m2.Text))
            {
                minM2 = Convert.ToInt32(tb_min_m2.Text);
                sorgu += @" AND emlak_m2::INTEGER >= " + minM2;
            }

            if (!string.IsNullOrEmpty(tb_max_m2.Text))
            {
                maxM2 = Convert.ToInt32(tb_max_m2.Text);
                sorgu += @" AND emlak_m2::INTEGER <= " + maxM2;
            }

            if (!string.IsNullOrEmpty(tb_oda.Text))
            {
                sorgu += @" AND emlak_odasayi = '" + tb_oda.Text + "'";
            }

            if (!string.IsNullOrEmpty(tb_minFiyat.Text))
            {
                minFiyat = Convert.ToInt32(tb_minFiyat.Text);
                sorgu += @" AND emlak_fiyat::INTEGER >= " + minFiyat;
            }

            if (!string.IsNullOrEmpty(tb_maxFiyat.Text))
            {
                maxFiyat = Convert.ToInt32(tb_maxFiyat.Text);
                sorgu += @" AND emlak_fiyat::INTEGER <= " + maxFiyat;
            }

            sorgu += ";";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, veritabani);
            DataSet ds = new();
            da.Fill(ds);
            dgv_musteri.DataSource = ds.Tables[0];
        }
        private void form_musteriAnaekran_Load(object sender, EventArgs e)
        {
            veritabani.Open();


            NpgsqlCommand db_iller = new NpgsqlCommand("select sehir from iller ", veritabani);
            NpgsqlDataReader dr_iller = db_iller.ExecuteReader();

            while (dr_iller.Read())
            {
                cb_il.Items.Add(dr_iller["sehir"]);
            }
            dr_iller.Close();
        }

        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ilce.Items.Clear();

            NpgsqlCommand db_ilceler = new NpgsqlCommand("select aciklama from ilceler where il_id=@p1", veritabani);
            db_ilceler.Parameters.AddWithValue("@p1", cb_il.SelectedIndex + 1);
            NpgsqlDataReader dr_ilceler = db_ilceler.ExecuteReader();

            while (dr_ilceler.Read())
            {
                cb_ilce.Items.Add(dr_ilceler["aciklama"]);
            }
            dr_ilceler.Close();
        }
    }
}
