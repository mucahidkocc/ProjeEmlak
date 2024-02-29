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
    public partial class form_isyeriAnaekran : Form
    {
        public form_isyeriAnaekran()
        {
            InitializeComponent();
        }

        NpgsqlConnection veritabani = new NpgsqlConnection("server=localHost; port=5432; Database=emlak; user ID = postgres; password=sa ");
        
        private void btn_emlakEkle_Click(object sender, EventArgs e)
        {
            string ekle = "insert into emlak_tablo (emlak_tur,emlak_il,emlak_ilce,emlak_binakat,emlak_dairekat,emlak_m2,emlak_odasayi,emlak_isinma,emlak_sahibi," +
                "emlak_fiyat) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, veritabani);
            cmd.Parameters.AddWithValue("@p1", tb_emlakTur.Text);
            cmd.Parameters.AddWithValue("@p2", cb_il.Text);
            cmd.Parameters.AddWithValue("@p3", cb_ilce.Text);
            cmd.Parameters.AddWithValue("@p4", tb_binaKat.Text);
            cmd.Parameters.AddWithValue("@p5", tb_daireKat.Text);
            cmd.Parameters.AddWithValue("@p6", tb_m2.Text);
            cmd.Parameters.AddWithValue("@p7", tb_oda.Text);
            cmd.Parameters.AddWithValue("@p8", tb_isinma.Text);
            cmd.Parameters.AddWithValue("@p9", tb_sahibi.Text);
            cmd.Parameters.AddWithValue("@p10", Convert.ToInt32(tb_fiyat.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Emlak Eklendi");
        }

        private void btn_emlakSil_Click(object sender, EventArgs e)
        {
            string sil = "delete from emlak_tablo where id=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, veritabani);
            cmd.Parameters.AddWithValue("@p1", int.Parse(tb_id.Text));
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Emlak Silindi");
        }

        private void btn_emlakAra_Click(object sender, EventArgs e)
        {

            Form ara = new form_arama();
            ara.Show();
            this.Hide();
        }


        private void btn_emlakGuncelle_Click(object sender, EventArgs e)
        {
            string guncelle = "update emlak_tablo set emlak_tur=@p2, emlak_il=@p3, emlak_ilce=@p4, emlak_binakat=@p5, emlak_dairekat=@p6, emlak_m2=@p7," +
                "emlak_odasayi=@p8, emlak_isinma=@p9, emlak_sahibi=@p10, emlak_fiyat=@p11 where id = @p1";
            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, veritabani);
            cmd.Parameters.AddWithValue("@p1", int.Parse(tb_id.Text));
            cmd.Parameters.AddWithValue("@p2", tb_emlakTur.Text);
            cmd.Parameters.AddWithValue("@p3", cb_il.Text);
            cmd.Parameters.AddWithValue("@p4", cb_ilce.Text);
            cmd.Parameters.AddWithValue("@p5", tb_binaKat.Text);
            cmd.Parameters.AddWithValue("@p6", tb_daireKat.Text);
            cmd.Parameters.AddWithValue("@p7", tb_m2.Text);
            cmd.Parameters.AddWithValue("@p8", tb_oda.Text);
            cmd.Parameters.AddWithValue("@p9", tb_isinma.Text);
            cmd.Parameters.AddWithValue("@p10", tb_sahibi.Text);
            cmd.Parameters.AddWithValue("@p11", int.Parse(tb_fiyat.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show("Emlak Güncellendi");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from emlak_tablo";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, veritabani);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv_isyeri.DataSource = ds.Tables[0];
        }

        private void form_isyeriAnaekran_Load(object sender, EventArgs e)
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

        private void dgv_isyeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dgv_isyeri.CurrentRow.Cells[0].Value.ToString();
            tb_emlakTur.Text = dgv_isyeri.CurrentRow.Cells[1].Value.ToString();
            cb_il.Text = dgv_isyeri.CurrentRow.Cells[2].Value.ToString();
            cb_ilce.Text = dgv_isyeri.CurrentRow.Cells[3].Value.ToString();
            tb_binaKat.Text = dgv_isyeri.CurrentRow.Cells[4].Value.ToString();
            tb_daireKat.Text = dgv_isyeri.CurrentRow.Cells[5].Value.ToString();
            tb_m2.Text = dgv_isyeri.CurrentRow.Cells[6].Value.ToString();
            tb_oda.Text = dgv_isyeri.CurrentRow.Cells[7].Value.ToString();
            tb_isinma.Text = dgv_isyeri.CurrentRow.Cells[8].Value.ToString();
            tb_sahibi.Text = dgv_isyeri.CurrentRow.Cells[9].Value.ToString();
            tb_fiyat.Text = dgv_isyeri.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
