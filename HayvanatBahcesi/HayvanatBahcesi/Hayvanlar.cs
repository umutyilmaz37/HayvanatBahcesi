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
    public partial class Hayvanlar : Form
    {
        public static Hayvanlar _instance;

        public Hayvanlar()
        {
            InitializeComponent();
        }

        public static Hayvanlar GetInstance()
        {
            if (_instance == null)
                _instance = new Hayvanlar();

            return _instance;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=1234;Database=Hayvanat_bahcesi");

        public int Insert(string sqlCmd)
        {
            NpgsqlCommand com = new NpgsqlCommand(sqlCmd, baglanti);
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            int sonuc = com.ExecuteNonQuery();
            baglanti.Close();
            return sonuc;
        }

        public DataTable GetData(String sqlCmd)
        {
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sqlCmd, baglanti);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        
        private void button1_Click(object sender, EventArgs e) // Çıkış butonu
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Memeli Hayvanları Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from hayvanlar where h_tur='memeli'");
          
        }

        private void button3_Click(object sender, EventArgs e) // Kuş Türü Hayvanları Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from hayvanlar where h_tur='kuş'");
          
        }

        private void button4_Click(object sender, EventArgs e) // Sürüngen Hayvanları Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from hayvanlar where h_tur='sürüngen'");
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from hayvanlar where h_ad like '"+textBox1.Text+"'");
        }

       
        
    }
}
