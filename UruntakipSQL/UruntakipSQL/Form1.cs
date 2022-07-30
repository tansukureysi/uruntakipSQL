using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// SQL Server ile bağlı işlemlerin gerçekleştirilebilmesi için kütüphaneyi tanımlıyoruz 
using System.Data.SqlClient;


namespace UruntakipSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //public olarak erişim için SQL bağlantısını gerçekleştiriyoruz
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-B7T40IKF\\SQLEXPRESS01; Initial Catalog=Uruntakip; Integrated Security=True"); 

        void temizle()
        {
            txturun.Text = "";
            txtkategori.Text = "";
            txtid.Text = "";
            sube.Text="";
            sehir.Text = "";
            txtmaliyet.Text = "";
            txtstok.Text = "";
            txturun.Focus();

        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGridView 'da SQL'de girdiğimiz verileri görebilmemiz için gerekli tablo bağlantısı
            this.urunTableAdapter.Fill(this.uruntakipDataSet.urun);

        }

        private void listeleme_button_Click(object sender, EventArgs e)
        {
            //Her seferinde form1_Load'ın yüklenmesini beklememek için tablo bağlantısını listele butonu altında da yapıyoruz
            this.urunTableAdapter.Fill(this.uruntakipDataSet.urun);

        }



        // tabloda herhangi bir satıra çift tıklandığında bilgilerin textboxlara getirilmesi için CellContentClick altında tanımlama işlemlerini yapıyoruz
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim= dataGridView1.SelectedCells[0].RowIndex;  

            //seçili değerlerin ait olduğu textboxlara gitmesini sağlıyoruz

            txtid.Text= dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txturun.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            sube.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            sehir.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtmaliyet.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtstok.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // silme işleminin gerçekleştirilmesi
            // SQL'de girdiğimiz bilgilere dikkat ederek ürün id'sine ait verileri seçip silme işlemi komutlarını yazıyoruz
            SqlCommand sil = new SqlCommand("Delete from urun where ID=@id", baglanti)
;           sil.Parameters.AddWithValue("@id", txtid.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün kaydı silindi.");
        }

        private void gunvelle_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update urun set Urun=@urun, Kategori=@kategori, Sube=@sube, Sehir=@sehir, Maliyet=@maliyet, Stok=@stok where ID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@id", txtid.Text);
            guncelle.Parameters.AddWithValue("@urun", txturun.Text);
            guncelle.Parameters.AddWithValue("@kategori", txtkategori.Text);
            guncelle.Parameters.AddWithValue("@sube", sube.Text);
            guncelle.Parameters.AddWithValue("@sehir", sehir.Text);
            guncelle.Parameters.AddWithValue("@maliyet", txtmaliyet.Text);
            guncelle.Parameters.AddWithValue("@stok", txtstok.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün güncellemesi tamamlandı.");

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            //oluşturduğumuz bağlantı nesnesini burada açıyoruz
            baglanti.Open();

            // komut nesnesi yaratarak burada SQL'deki şekliyle kayıtlı verileri ekliyoruz ve bu parametrelere değer ataması yapıyoruz
            SqlCommand ekle = new SqlCommand("insert into urun (ID, Urun, Kategori, Sube, Sehir, Maliyet, Stok) values (@id,@urun,@kategori,@sube,@sehir,@maliyet,@stok)", baglanti);
            ekle.Parameters.AddWithValue("@id", txtid.Text);
            ekle.Parameters.AddWithValue("@urun", txturun.Text);
            ekle.Parameters.AddWithValue("@kategori", txtkategori.Text);
            ekle.Parameters.AddWithValue("@sube", sube.Text);
            ekle.Parameters.AddWithValue("@sehir", sehir.Text);
            ekle.Parameters.AddWithValue("@maliyet", txtmaliyet.Text);
            ekle.Parameters.AddWithValue("@stok", txtstok.Text);

            //değer ataması yapılan parametre komutlarının çalışması için çalıştırma komutunu yazdık
            ekle.ExecuteNonQuery();
            baglanti.Close();


            //Ekrana ürün bilgisinin eklendiğini gösteren bir ifade yazdırıyoruz
            MessageBox.Show("Ürün bilgisi eklendi.");

        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
