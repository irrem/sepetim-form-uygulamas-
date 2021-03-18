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
            textBox9.Text = dgwCostumers.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dgwCostumers.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dgwCostumers.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dgwCostumers.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dgwCostumers.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dgwCostumers.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dgwCostumers.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dgwCostumers.CurrentRow.Cells[8].Value.ToString();
            textBox7.Text = dgwCostumers.CurrentRow.Cells[9].Value.ToString();

        }

        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            dgwCostumers.DataSource = GetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
              

                if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Add(new MusteriModel
                {

                    musteriAd = textBox9.Text,
                    musteriSoyad = textBox8.Text,
                    musteriTelefon = textBox1.Text,
                    musteriAdres = textBox2.Text,
                    musteriIl = textBox3.Text,
                    musteriIlce = textBox4.Text,
                    musteriEnlemBoylam = textBox5.Text,
                    musteriMail = textBox6.Text,
                    musteriSanalSepetPuan = Convert.ToInt32(textBox7.Text)

                });

                MessageBox.Show("Ürün Sistemimize Başarıyla Eklenmiştir.");
                }

                dgwCostumers.DataSource = GetAll();
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Update(new MusteriModel
                {
                    musteriId = Convert.ToInt32(dgwCostumers.CurrentRow.Cells[0].Value),
                    musteriAd = textBox9.Text,
                    musteriSoyad = textBox8.Text,
                    musteriTelefon = textBox1.Text,
                    musteriAdres = textBox2.Text,
                    musteriIl = textBox3.Text,
                    musteriIlce = textBox4.Text,
                    musteriEnlemBoylam = textBox5.Text,
                    musteriMail = textBox6.Text,
                    musteriSanalSepetPuan = Convert.ToInt32(textBox7.Text)

                });
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

        public void Add(MusteriModel musteri)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Musteri values (@musteriAd," +
                "@musteriSoyad,@musteriTelefon,@musteriAdres," +
                "@musteriIl,@musteriIlce,@musteriEnlemBoylam," +
                "@musteriMail,@musteriSanalSepetPuan)", baglanti);

        
         command.Parameters.AddWithValue("musteriAd", musteri.musteriAd);
         command.Parameters.AddWithValue("musteriSoyad", musteri.musteriSoyad);
         command.Parameters.AddWithValue("musteriTelefon", musteri.musteriTelefon);
         command.Parameters.AddWithValue("musteriAdres", musteri.musteriAdres);
         command.Parameters.AddWithValue("musteriIl", musteri.musteriIl);
         command.Parameters.AddWithValue("musteriIlce", musteri.musteriIlce);
         command.Parameters.AddWithValue("musteriEnlemBoylam", musteri.musteriEnlemBoylam);
         command.Parameters.AddWithValue("musteriMail", musteri.musteriMail);
         command.Parameters.AddWithValue("musteriSanalSepetPuan", musteri.musteriSanalSepetPuan);
            command.ExecuteNonQuery();
            baglanti.Close();

        }
        public void Update(MusteriModel Musteri)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Musteri set musteriAd=@musteriAd," +
                "musteriSoyad=@musteriSoyad,musteriTelefon=@musteriTelefon,musteriAdres=@musteriAdres," +
                "musteriIl=@musteriIl,musteriIlce=@musteriIlce,musteriEnlemBoylam=@musteriEnlemBoylam," +
                "musteriMail=@musteriMail,musteriSanalSepetPuan=@musteriSanalSepetPuan" +
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
