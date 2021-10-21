using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace HayvanatBahcesi
{
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool blnfound = false;

            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=1234;Database=Hayvanat_bahcesi");
            baglanti.Open();
            string sorgu=("select *from yetkililer where y_ad='"+textBox1.Text+"'and y_sifre='"+textBox2.Text+"'");
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu,baglanti);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
                blnfound = true;
                Yetkili f5 = new Yetkili();
                f5.ShowDialog();
                this.Hide();
            }

            if (blnfound == false) 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı !","uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                
                dr.Close();
                baglanti.Close();
            }
        }
    }
}
