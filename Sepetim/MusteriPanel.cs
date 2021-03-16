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
    public partial class MusteriPanel : Form
    {
        public MusteriPanel()
        {
            InitializeComponent();
        }

        private void dgwCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryTxt.Text = dgwCostumers.CurrentRow.Cells[1].Value.ToString();
        }

        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            dgwCostumers.DataSource = GetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            Update(new MusteriModel
            {
                musteriId = Convert.ToInt32(dgwCostumers.CurrentRow.Cells[1].Value),
                musteriAd = categoryTxt.Text
            });
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Ürün Sistemimize Başarıyla Guncellenmiştir.");
            }
            dgwCostumers.DataSource = GetAll();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwCostumers.CurrentRow.Cells[0].Value));
                MessageBox.Show("Müşteri Sistemimize Başarıyla Silinmiştir.");
            }
            dgwCostumers.DataSource = GetAll();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public List<MusteriModel> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Musteri", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<MusteriModel> Musteriler = new List<MusteriModel>();
            while (reader.Read())
            {
                MusteriModel musteri = new MusteriModel
                {
                    musteriId = Convert.ToInt32(reader["musteriId"]),
                    musteriAd = reader["musteriAd"].ToString(),
                    musteriSoyad = reader["musteriSoyad"].ToString(),
                    musteriTelefon = reader["musteriTelefon"].ToString(),
                    musteriAdres = reader["musteriAdres"].ToString(),
                    musteriIl = reader["musteriIl"].ToString(),
                    musteriIlce = reader["musteriIlce"].ToString(),
                    musteriEnlemBoylam = reader["musteriEnlemBoylam"].ToString(),
                    musteriMail = reader["musteriMail"].ToString(),
                    musteriSanalSepetPuan = Convert.ToInt32(reader["musteriSanalSepetPuan"])

                };
                Musteriler.Add(musteri);
            }
            reader.Close();
            baglanti.Close();
            return Musteriler;
        }

       /* public void Add(MusteriModel Musteri)
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

        }*/
        public void Update(MusteriModel Musteri)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Musteri set musteriAd=@musteriAd," +
                "musteriSoyad=@musteriSoyad,musteriTelefon=@musteriTelefon,musteriAdres=@musteriAdres," +
                "musteriIl=@musteriIl,musteriIlce=@musteriIlce,musteriEnlemBoylam=@musteriEnlemBoylam," +
                "musteriMail=@musteriMail,musteriSanalSepetPuan=@musteriSanalSepetPuan," +
                " where musteriId=@musteriId", baglanti);

            command.Parameters.AddWithValue("musteriId", Musteri.musteriId);
            command.Parameters.AddWithValue("musteriAd", Musteri.musteriAd);
            command.Parameters.AddWithValue("musteriSoyad", Musteri.musteriSoyad);
            command.Parameters.AddWithValue("musteriTelefon", Musteri.musteriTelefon);
            command.Parameters.AddWithValue("musteriAdres", Musteri.musteriAdres);
            command.Parameters.AddWithValue("musteriIl", Musteri.musteriIl);
            command.Parameters.AddWithValue("musteriIlce", Musteri.musteriIlce);
            command.Parameters.AddWithValue("musteriEnlemBoylam", Musteri.musteriEnlemBoylam);
            command.Parameters.AddWithValue("musteriMail", Musteri.musteriMail);
            command.Parameters.AddWithValue("musteriSanalSepetPuan", Musteri.musteriSanalSepetPuan);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Musteri where  musteriId=@musteriId", baglanti);

            command.Parameters.AddWithValue("musteriId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
    }
}
