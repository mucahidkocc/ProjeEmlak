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

    public partial class formSecim : Form
    {

        public formSecim()
        {
            InitializeComponent();
        }

        private void btn_isyeriKayit_Click(object sender, EventArgs e)
        {
            Form isyeriKayit = new form_kayitisyeri();
            isyeriKayit.Show();
            this.Hide();
        }

        private void btn_musteriKayit_Click(object sender, EventArgs e)
        {
            Form musteriKayit = new form_kayitMusteri();
            musteriKayit.Show();
            this.Hide();
        }
    }
}
