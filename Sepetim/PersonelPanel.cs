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
    public partial class PersonelPanel : Form
    {
        public PersonelPanel()
        {
            InitializeComponent();
        }
         public bool subeSorumlusu = false;
        private void PersonelPanel_Load(object sender, EventArgs e)
        {
            dgwPersonel.DataSource = GetAll();
           /* if (subeSorumlusu)
            {
                addBtn.Visible = false;
            }*/
            KategoriDoldur();
            SubeDoldur();

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value));
                MessageBox.Show("Ürün Sistemimize Başarıyla Silinmiştir.");
            }
            dgwPersonel.DataSource = GetAll();
        }
        
        public void KategoriDoldur()
        {
            chooseTypeBox.DataSource = GetCategoryAll();
            chooseTypeBox.DisplayMember = "kategori";
            chooseTypeBox.ValueMember = "KategoriId";
        }
        public void SubeDoldur()
        {
            SubePanel sube = new SubePanel();
            
            chooseTypeBox2.DataSource = sube.GetAll();
            chooseTypeBox2.DisplayMember = "subeAd";
            chooseTypeBox2.ValueMember = "subeId";
        }





        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        
        public List<PersonelKategoriModel> GetCategoryAll()
        {
            ConnectionControl();
            SqlCommand command;;
            if (subeSorumlusu)
            {
                command = new SqlCommand("Select * from PersonelKategori where kategoriId=2 or kategoriId=3 ", baglanti);
            }
            else
            {
                command = new SqlCommand("Select * from PersonelKategori", baglanti);
            }
            

            SqlDataReader reader = command.ExecuteReader();
            List<PersonelKategoriModel> PersonelKategori = new List<PersonelKategoriModel>();
            while (reader.Read())
            {
                PersonelKategoriModel personelKategori = new PersonelKategoriModel
                {
                    kategoriId = Convert.ToInt32(reader["kategoriId"]),
                    kategori = reader["kategori"].ToString(),

                };
                PersonelKategori.Add(personelKategori);
            }
            reader.Close();
            baglanti.Close();
            return PersonelKategori;
        }
        public List<PersonelModel> GetAll()
        {
            ConnectionControl();
            SqlCommand command;
             if (subeSorumlusu)
                command = new SqlCommand("Select * from Personel where personelKategori=2 or personelKategori=3", baglanti);
            else
                command = new SqlCommand("Select * from Personel", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<PersonelModel> Personeller = new List<PersonelModel>();
            while (reader.Read())
            {
                PersonelModel personelModel = new PersonelModel
                {
                    personelAdSoyad = reader["personelAdSoyad"].ToString(),
                    personelId = Convert.ToInt32(reader["personelId"]),
                    personelAdres = reader["personelAdres"].ToString(),
                    personelTelefon = reader["personelTelefon"].ToString(),
                    personelMail = reader["personelMail"].ToString(),
                    personelIsBaslangic = reader["personelIsBaslangic"].ToString(),
                    personelKategori = Convert.ToInt32(reader["personelKategori"]),
                    subeId= Convert.ToInt32(reader["subeId"]),

                };
                Personeller.Add(personelModel);
            }
            reader.Close();
            baglanti.Close();
            return Personeller;
        }
        public string GetAllWithId(int id)
        {
            ConnectionControl();
            SqlCommand command;
            string personelAdSoyad = "";
                command = new SqlCommand("Select * from Personel where personelId=@id", baglanti);
            command.Parameters.AddWithValue("id", id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                personelAdSoyad = reader["personelAdSoyad"].ToString();
                 
            }
            reader.Close();
            baglanti.Close();
            return personelAdSoyad;
        }
        public List<PersonelModel> GetAllWithCategory(int id)
        {
            
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Personel where personelKategori like '%" + id + "%'", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<PersonelModel> Personeller = new List<PersonelModel>();
            while (reader.Read())
            {
                PersonelModel personelModel = new PersonelModel
                {
                    personelAdSoyad = reader["personelAdSoyad"].ToString(),
                    personelId = Convert.ToInt32(reader["personelId"]),
                    personelAdres = reader["personelAdres"].ToString(),
                    personelTelefon = reader["personelTelefon"].ToString(),
                    personelMail = reader["personelMail"].ToString(),
                    personelIsBaslangic = reader["personelIsBaslangic"].ToString(),
                    personelKategori = Convert.ToInt32(reader["personelKategori"]),
                    subeId = Convert.ToInt32(reader["subeId"]),
                };
                Personeller.Add(personelModel);
            }
            reader.Close();
            baglanti.Close();
            return Personeller;
        }

        public void Add(PersonelModel personel)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Personel values (@personelAdSoyad,@personelTelefon," +
               "@personelMail,@personelAdres,@personelIsBaslangic,@personelKategori,@subeId)" ,baglanti);

            command.Parameters.AddWithValue("personelAdSoyad", personel.personelAdSoyad);
            command.Parameters.AddWithValue("personelTelefon", personel.personelTelefon);
            command.Parameters.AddWithValue("personelMail", personel.personelMail);
            command.Parameters.AddWithValue("personelAdres", personel.personelAdres);
            command.Parameters.AddWithValue("personelIsBaslangic", personel.personelIsBaslangic);
            command.Parameters.AddWithValue("personelKategori", personel.personelKategori);
            command.Parameters.AddWithValue("subeId", personel.subeId);
            command.ExecuteNonQuery();

        }
        public void Update(PersonelModel personel)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Personel set personelAdSoyad=@personelAdSoyad," +
                "personelTelefon=@personelTelefon," +
                "personelMail=@personelMail,personelAdres=@personelAdres,personelIsBaslangic=@personelIsBaslangic,personelKategori=@personelKategori,subeId=@subeId" +
                " where personelId=@personelId", baglanti);
            command.Parameters.AddWithValue("personelId", personel.personelId);
            command.Parameters.AddWithValue("personelAdSoyad", personel.personelAdSoyad);
            command.Parameters.AddWithValue("personelTelefon", personel.personelTelefon);
            command.Parameters.AddWithValue("personelMail", personel.personelMail);
            command.Parameters.AddWithValue("personelAdres", personel.personelAdres);
            command.Parameters.AddWithValue("personelIsBaslangic", personel.personelIsBaslangic);
            command.Parameters.AddWithValue("personelKategori", personel.personelKategori);
            command.Parameters.AddWithValue("subeId", personel.subeId);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Personel where  personelId=@personelId", baglanti);

            command.Parameters.AddWithValue("personelId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }


        private void chooseTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SqlCommand command = new SqlCommand("Select * from IlacDisiUrun where KategoriId like '%" + id + "%'", _connection);
            try
            {
                dgwPersonel.DataSource = GetAllWithCategory(Convert.ToInt32(chooseTypeBox.SelectedValue));

            }
            catch (Exception)
            {
            }
        }
        //exec sp_fkeys 'tableName' 
        private void addBtn_Click(object sender, EventArgs e)
        {
           
            
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Add(new PersonelModel
                {
                    personelAdSoyad = textBox9.Text,
                    personelTelefon = textBox1.Text,
                    personelMail = textBox2.Text,
                    personelAdres = textBox3.Text,
                    personelIsBaslangic = textBox4.Text,
                    personelKategori = Convert.ToInt32(chooseTypeBox.SelectedValue),
                    subeId = Convert.ToInt32(chooseTypeBox2.SelectedValue)
                });
                MessageBox.Show("Personel Sistemimize Başarıyla Eklenmiştir.");
            }

            dgwPersonel.DataSource = GetAll();


        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value));
                MessageBox.Show("Personel Sistemimize Başarıyla Silinmiştir.");
            }
            dgwPersonel.DataSource = GetAll();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
          

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Update(new PersonelModel
                {
                    personelId = Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value),
                    personelAdSoyad = textBox9.Text,
                    personelTelefon = textBox1.Text,
                    personelMail = textBox2.Text,
                    personelAdres = textBox3.Text,
                    personelIsBaslangic = textBox4.Text,
                    personelKategori = Convert.ToInt32(chooseTypeBox.SelectedValue),
                    subeId = Convert.ToInt32(chooseTypeBox2.SelectedValue)
                });
                MessageBox.Show("Personel Sistemimize Başarıyla Guncellenmiştir.");
            }
            dgwPersonel.DataSource = GetAll();
        }

        private void dgwPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox9.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dgwPersonel.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dgwPersonel.CurrentRow.Cells[5].Value.ToString();
        }

        private void chooseTypeBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
