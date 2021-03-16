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

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update(new UrunModel
            {
                UrunId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                UrunAd = categoryTxt.Text
            });
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Ürün Sistemimize Başarıyla Guncellenmiştir.");
            }
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
                    UrunAd = reader["urunAd"].ToString(),
                    UrunId = Convert.ToInt32(reader["urunId"]),
                    UrunStok= Convert.ToInt32(reader["urunStok"]),
                    UrunBirimFiyat= Convert.ToInt32(reader["urunBirimFiyat"]),
                    UrunKdvYuzdeOran = Convert.ToInt32(reader["urunKdvYuzdeOran"]),
                    UrunSatisFiyat = Convert.ToInt32(reader["urunSatisFiyat"]),
                    UrunSubeId = Convert.ToInt32(reader["subeId"]),
                    UrunKategoriId = Convert.ToInt32(reader["kategoriId"]),

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
            SqlCommand command = new SqlCommand("insert into Urunler values (@UrunAd,@UrunStok,@UrunBirimFiyat,@UrunKdvYuzdeOran,@UrunSatisFiyat,@UrunSubeId,@UrunKategoriId)", baglanti);
           
            command.Parameters.AddWithValue("urunAd", Urun.UrunAd);
            command.Parameters.AddWithValue("urunStok", Urun.UrunStok);
            command.Parameters.AddWithValue("urunBirimFiyat", Urun.UrunBirimFiyat);
            command.Parameters.AddWithValue("urunKdvYuzdeOran", Urun.UrunKdvYuzdeOran);
            command.Parameters.AddWithValue("urunSatisFiyat", Urun.UrunSatisFiyat);
            command.Parameters.AddWithValue("subeId", Urun.UrunSubeId);
            command.Parameters.AddWithValue("kategoriId", Urun.UrunKategoriId);
            command.ExecuteNonQuery();
           
            baglanti.Close();

        }
        public void Update(UrunModel Urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set urunAd=@UrunAd," +
                "urunStok=@UrunStok,urunBirimFiyat=@UrunBirimFiyat,urunKdvYuzdeOran=@UrunKdvYuzdeOran," +
                "urunStok=@UrunSatisFiyat,subeId=@UrunSubeId,kategoriId=@UrunKategoriId," +
                " where urunId=@UrunId", baglanti);

            command.Parameters.AddWithValue("urunId", Urun.UrunId);
            command.Parameters.AddWithValue("urunAd", Urun.UrunAd);
            command.Parameters.AddWithValue("urunStok", Urun.UrunStok);
            command.Parameters.AddWithValue("urunBirimFiyat", Urun.UrunBirimFiyat);
            command.Parameters.AddWithValue("urunKdvYuzdeOran", Urun.UrunKdvYuzdeOran);
            command.Parameters.AddWithValue("urunSatisFiyat", Urun.UrunSatisFiyat);
            command.Parameters.AddWithValue("subeId", Urun.UrunSubeId);
            command.Parameters.AddWithValue("kategoriId", Urun.UrunKategoriId);
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

        }
    }

}
