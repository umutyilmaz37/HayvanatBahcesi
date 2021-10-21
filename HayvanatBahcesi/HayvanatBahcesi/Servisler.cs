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
    public partial class Servisler : Form
    {
        public IservisTuru ServisTuru { get; private set; }
        public Servisler(IservisTuru servist)
        {
            ServisTuru = servist;
        }

        public Servisler()
        {
            InitializeComponent();
        }
        
        public static Servisler _instance;

        public static Servisler GetInstance()
        {
            if (_instance == null)
                _instance = new Servisler();

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

        public interface IservisTuru 
        {
            void Generate();
        }

        public class VeterinerServis : Servisler 
        {
            public VeterinerServis(IservisTuru tur) : base(tur) 
            { 
            }
            public override void Display() 
            {
                base.Display();
            }
        }
        
        public class KalanBesinServis : Servisler
        {
            public KalanBesinServis(IservisTuru tur) : base(tur) 
            { 
            }
            public override void Display() 
            {
                base.Display();
            }
        }

        public class VeterinerTuruM : IservisTuru 
        {
            public void Generate() 
            {
                MessageBox.Show("Memeliler ile ilgilenen Veterinerler Gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }
        public class VeterinerTuruS : IservisTuru
        {
            public void Generate()
            {
                MessageBox.Show("Sürüngenler ile ilgilenen Veterinerler Gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }
        public class VeterinerTuruK : IservisTuru
        {
            public void Generate()
            {
                MessageBox.Show("Kuşlar ile ilgilenen Veterinerler Gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }


        public class KalanBesinTuruM : IservisTuru
        {
            public void Generate()
            {
                MessageBox.Show("Memelilerin kalan besinleri gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }
        public class KalanBesinTuruS : IservisTuru
        {
            public void Generate()
            {
                MessageBox.Show("Sürüngenlerin kalan besinleri gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }
        public class KalanBesinTuruK : IservisTuru
        {
            public void Generate()
            {
                MessageBox.Show("Kuşların kalan besinleri gösteriliyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        { 
            
            if (checkBox1.Checked)
            {
                
                if (checkBox2.Checked || checkBox3.Checked)
                {
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                   
                }

                else
                {
                    Servisler servis = new VeterinerServis(new VeterinerTuruM());
                    servis.Display();
                    GetInstance();
                    dataGridView1.DataSource = _instance.GetData("select *from veteriner_m");
                }
            }
            if (checkBox2.Checked)
            {
                if (checkBox1.Checked || checkBox3.Checked)
                {
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    Servisler servis = new VeterinerServis(new VeterinerTuruS());
                    servis.Display();
                    GetInstance();
                    dataGridView1.DataSource = _instance.GetData("select *from veteriner_s");
                }
            }
            if (checkBox3.Checked)
            {
                if (checkBox1.Checked || checkBox2.Checked)
                {
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    Servisler servis = new VeterinerServis(new VeterinerTuruK());
                    servis.Display();
                    GetInstance();
                    dataGridView1.DataSource = _instance.GetData("select *from veteriner_k");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox5.Checked || checkBox6.Checked)
                {
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    Servisler servis = new KalanBesinServis(new KalanBesinTuruM());
                    servis.Display();
                    GetInstance();
                    dataGridView2.DataSource = _instance.GetData("select *from h_yiyecek where hayvan_tur='memeli'");
                }
            }
            if (checkBox5.Checked)
            {
                 if (checkBox4.Checked || checkBox6.Checked) 
                { 
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); 
                }

                else
                {
                Servisler servis = new KalanBesinServis(new KalanBesinTuruS());
                servis.Display();
                GetInstance();
                dataGridView2.DataSource = _instance.GetData("select *from h_yiyecek where hayvan_tur='sürüngen'");
                }
            }
            if (checkBox6.Checked)
            {
                 if (checkBox4.Checked || checkBox5.Checked) 
                { 
                    MessageBox.Show("Lütfen tek kategori seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); 
                }

                else
                {
                Servisler servis = new KalanBesinServis(new KalanBesinTuruK());
                servis.Display();
                GetInstance();
                dataGridView2.DataSource = _instance.GetData("select *from h_yiyecek where hayvan_tur='kuş'");
                }
            }
        }

        public virtual void Display() 
        {
            ServisTuru.Generate();
        } 



       
    }
}
