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
namespace HayvanatBahcesi
{
    public partial class Personeller : Form
    {
        public static Personeller _instance;
        
        public Personeller() {
            InitializeComponent();
        }
        
        public static Personeller GetInstance()
        {
            if(_instance==null)
               _instance=new Personeller();
            
            return _instance;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=1234;Database=Hayvanat_bahcesi");

        public int Insert(string sqlCmd) 
        {
            NpgsqlCommand com = new NpgsqlCommand(sqlCmd,baglanti);
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            int sonuc = com.ExecuteNonQuery();
            baglanti.Close();
            return sonuc; 
        }

        public DataTable GetData(String sqlCmd) 
        {
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sqlCmd,baglanti);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        private void personel_buton_tikla(object sender, EventArgs e) // Personelleri Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from personel");
        }

        private void button1_Click(object sender, EventArgs e)  // Çıkış butonu
        {
            this.Close();
        }
        
        private void yonetim_buton_tikla(object sender, EventArgs e)  // Yönetimdeki Kişileri Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from personel where p_birim='yönetim'");
        }

        private void mpersonel_buton_tikla(object sender, EventArgs e) // Memeli Hayvanlar ile İlgilenen Personelleri Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from personel where p_birim='memeliler'");
        }
        
        private void kpersonel_buton_tikla(object sender, EventArgs e) // Kuşlar ile İlgilenen Personelleri Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from personel where p_birim='kuşlar'");
        }

        private void spersonel_buton_tikla(object sender, EventArgs e) // Sürüngen Hayvanlar ile İlgilenen Personelleri Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from personel where p_birim='sürüngenler'");
        }
    }
}
