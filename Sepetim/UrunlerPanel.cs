using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sepetim
{
    public partial class UrunlerPanel : Form
    {
        public UrunlerPanel()
        {
            InitializeComponent();
        }

        private void dgwCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox9.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dgwProduct.CurrentRow.Cells[6].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Add(new UrunModel
            {

                urunAd = textBox9.Text,
                urunStok = Convert.ToInt32(textBox8.Text),
                urunBirimFiyat = Convert.ToInt32(textBox1.Text),
                urunKdvYuzdeOran = Convert.ToInt32(textBox2.Text),
                urunSatisFiyat = Convert.ToInt32(textBox3.Text),
                subeId = Convert.ToInt32(textBox4.Text),
                kategoriId = Convert.ToInt32(comboBox1.SelectedValue)

            });

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Ürün Sistemimize Başarıyla Eklenmiştir.");
            }

            dgwProduct.DataSource = GetAll();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update(new UrunModel
            {

                urunId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                urunAd = textBox9.Text,
                urunStok = Convert.ToInt32(textBox8.Text),
                urunBirimFiyat = Convert.ToInt32(textBox1.Text),
                urunKdvYuzdeOran = Convert.ToInt32(textBox2.Text),
                urunSatisFiyat = Convert.ToInt32(textBox3.Text),
                subeId = Convert.ToInt32(textBox4.Text),
                kategoriId = Convert.ToInt32(comboBox1.SelectedValue)
            });

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Ürün Başarıyla Güncellenmiştir.");


            dgwProduct.DataSource = GetAll();


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value));
                MessageBox.Show("Ürün Sistemimize Başarıyla Silinmiştir.");
            }
            dgwProduct.DataSource = GetAll();
        }
        Kategori kategori = new Kategori();
        public void KategoriDoldur()
        {
            comboBox1.DataSource = kategori.GetAll();
            comboBox1.DisplayMember = "KategoriAd";
            comboBox1.ValueMember = "KategoriId";
        }
        private void UrunlerPanel_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = GetAll();
            KategoriDoldur();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public List<UrunModel> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Urunler", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<UrunModel> Urunler = new List<UrunModel>();
            while (reader.Read())
            {
                UrunModel urun = new UrunModel
                {
                    urunAd = reader["urunAd"].ToString(),
                    urunId = Convert.ToInt32(reader["urunId"]),
                    urunStok= Convert.ToInt32(reader["urunStok"]),
                    urunBirimFiyat= Convert.ToInt32(reader["urunBirimFiyat"]),
                    urunKdvYuzdeOran = Convert.ToInt32(reader["urunKdvYuzdeOran"]),
                    urunSatisFiyat = Convert.ToInt32(reader["urunSatisFiyat"]),
                    subeId = Convert.ToInt32(reader["subeId"]),
                    kategoriId = Convert.ToInt32(reader["kategoriId"]),

                };
                Urunler.Add(urun);
            }
            reader.Close();
            baglanti.Close();
            return Urunler;
        }

        public void Add(UrunModel Urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Urunler values (@urunAd,@urunStok,@urunBirimFiyat,@urunKdvYuzdeOran,@urunSatisFiyat,@subeId,@kategoriId)", baglanti);
           
            command.Parameters.AddWithValue("urunAd", Urun.urunAd);
            command.Parameters.AddWithValue("urunStok", Urun.urunStok);
            command.Parameters.AddWithValue("urunBirimFiyat", Urun.urunBirimFiyat);
            command.Parameters.AddWithValue("urunKdvYuzdeOran", Urun.urunKdvYuzdeOran);
            command.Parameters.AddWithValue("urunSatisFiyat", Urun.urunSatisFiyat);
            command.Parameters.AddWithValue("subeId", Urun.subeId);
            command.Parameters.AddWithValue("kategoriId", Urun.kategoriId);
            command.ExecuteNonQuery();
           
            baglanti.Close();

        }
        public void Update(UrunModel Urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set urunAd=@urunAd," +
                "urunStok=@urunStok,urunBirimFiyat=@urunBirimFiyat,urunKdvYuzdeOran=@urunKdvYuzdeOran," +
                "urunStok=@urunSatisFiyat,subeId=@subeId,kategoriId=@kategoriId," +
                " where urunId=@UrunId", baglanti);

            command.Parameters.AddWithValue("urunId", Urun.urunId);
            command.Parameters.AddWithValue("urunAd", Urun.urunAd);
            command.Parameters.AddWithValue("urunStok", Urun.urunStok);
            command.Parameters.AddWithValue("urunBirimFiyat", Urun.urunBirimFiyat);
            command.Parameters.AddWithValue("urunKdvYuzdeOran", Urun.urunKdvYuzdeOran);
            command.Parameters.AddWithValue("urunSatisFiyat", Urun.urunSatisFiyat);
            command.Parameters.AddWithValue("subeId", Urun.subeId);
            command.Parameters.AddWithValue("kategoriId", Urun.kategoriId);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Urunler where  urunId=@UrunId", baglanti);

            command.Parameters.AddWithValue("urunId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedValue.ToString());
        }
    }

}
