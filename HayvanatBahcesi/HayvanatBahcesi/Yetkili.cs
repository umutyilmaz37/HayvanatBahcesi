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
    public partial class Yetkili : Form
    {
        public static Yetkili _instance;
        
        public Yetkili()
        {
            InitializeComponent();
        }

        public static Yetkili GetInstance()
        {
            if (_instance == null)
                _instance = new Yetkili();

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
       
        public void EkleVeri(String sqlCmd) 
        {
            try
            {
                NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=1234;Database=Hayvanat_bahcesi");
                baglanti.Open();
                string komut =sqlCmd;
                NpgsqlCommand com = new NpgsqlCommand(komut, baglanti);
                NpgsqlDataReader dr;
                dr = com.ExecuteReader();
                MessageBox.Show("Kayıt Başarılı");
                while (dr.Read())
                {

                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void SilVeri(String sqlCmd) 
        {
            try
            {
                NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=1234;Database=Hayvanat_bahcesi");
                baglanti.Open();
                string komut = sqlCmd;
                NpgsqlCommand com = new NpgsqlCommand(komut, baglanti);
                NpgsqlDataReader dr;
                dr = com.ExecuteReader();
                MessageBox.Show("Silme Başarılı");
                while (dr.Read())
                {

                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        
        private void button5_Click(object sender, EventArgs e) // Çıkış Butonu
        {
            this.Close();
        }
        
        private void button6_Click(object sender, EventArgs e) // Hayvanları Listele
        {
            GetInstance();
            dataGridView1.DataSource = _instance.GetData("select *from hayvanlar");
        }

        private void button7_Click(object sender, EventArgs e) // Personelleri Listele
        {
            GetInstance();
            dataGridView2.DataSource = _instance.GetData("select *from personel");
        }

        private void button1_Click(object sender, EventArgs e) // Hayvan Ekleme
        {
            EkleVeri("insert into hayvanlar(h_id,h_ad,h_tur) values('" + this.textBox3.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "')");
        }

        private void button2_Click(object sender, EventArgs e) // Hayvan Silme
        {
            
          SilVeri("delete from hayvanlar where h_id='" + this.textBox3.Text + "';");
           
        }

        private void button3_Click(object sender, EventArgs e)   // Personel Ekleme
        {
            EkleVeri("insert into personel(p_id,p_ad,p_birim) values('" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')");
        }

        private void button4_Click(object sender, EventArgs e) //Personel Silme
        {
            SilVeri("delete from personel where p_id='" + this.textBox4.Text + "';");
        }


    }
}
