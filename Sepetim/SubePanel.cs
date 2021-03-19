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
    public partial class SubePanel : Form
    {
        public SubePanel()
        {
            InitializeComponent();
        }

        private void SubePanel_Load(object sender, EventArgs e)
        {
           dgwSubeler.DataSource= GetAll();
            KategoriDoldur();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update(new SubeModel
            {
                subeId = Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value),
               
            });
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Ürün Sistemimize Başarıyla Guncellenmiştir.");
            }
            dgwSubeler.DataSource = GetAll();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value));
                MessageBox.Show("Ürün Sistemimize Başarıyla Silinmiştir.");
            }
            dgwSubeler.DataSource = GetAll();
        }
      
        public void KategoriDoldur()
        {
            PersonelPanel personel = new PersonelPanel();
            chooseTypeBox.DataSource = personel.GetAll();
            chooseTypeBox.DisplayMember = "personelAdSoyad";
            chooseTypeBox.ValueMember = "personelId";
        }
        public string GetAllWithId(int id)
        {
            ConnectionControl();
            SqlCommand command;
            string subeAd = "";
            command = new SqlCommand("Select * from Subeler where subeId=@id", baglanti);
            command.Parameters.AddWithValue("id", id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                subeAd = reader["subeAd"].ToString();


            }
            reader.Close();
            baglanti.Close();
            return subeAd;
        }
        public List<SubeModel> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Subeler", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<SubeModel> Subeler = new List<SubeModel>();
            while (reader.Read())
            {
                SubeModel subeModel = new SubeModel
                {
                    subeAd = reader["subeAd"].ToString(),
                    subeId = Convert.ToInt32(reader["subeId"]),
                    subeAdres = reader["subeAdres"].ToString(),
                    subeTelefon = reader["subeTelefon"].ToString(),
                    subeMail = reader["subeMail"].ToString(),
                    personelId = Convert.ToInt32(reader["personelId"]),
                   
                };
                Subeler.Add(subeModel);
            }
            reader.Close();
            baglanti.Close();
            return Subeler;
        }

        public void Add(SubeModel sube)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Subeler values (@subeAd,@subeAdres,@subeTelefon,@subeMail,@personelId)", baglanti);

            command.Parameters.AddWithValue("subeAd", sube.subeAd);
            command.Parameters.AddWithValue("subeAdres", sube.subeAdres);
            command.Parameters.AddWithValue("subeTelefon", sube.subeTelefon);
            command.Parameters.AddWithValue("subeMail", sube.subeMail);
            command.Parameters.AddWithValue("personelId", sube.personelId);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Update(SubeModel sube)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set subeAd=@subeAd," +
                "subeAdres=@subeAdres,subeTelefon=@subeTelefon,subeMail=@subeMail," +
                "personelId=@personelId," +
                " where subeId=@subeId", baglanti);

            command.Parameters.AddWithValue("subeAd", sube.subeAd);
            command.Parameters.AddWithValue("subeAdres", sube.subeAdres);
            command.Parameters.AddWithValue("subeTelefon", sube.subeTelefon);
            command.Parameters.AddWithValue("subeMail", sube.subeMail);
            command.Parameters.AddWithValue("personelId", sube.personelId);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Subeler where  subeId=@subeId", baglanti);

            command.Parameters.AddWithValue("subeId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Add(new SubeModel
                {
                    subeAd = textBox9.Text,
                    subeAdres = textBox8.Text,
                    subeTelefon = textBox1.Text,
                    subeMail = textBox2.Text,
                    personelId = Convert.ToInt32(chooseTypeBox.SelectedValue)
                });
                MessageBox.Show("Şube Sistemimize Başarıyla Eklenmiştir.");
            }
            dgwSubeler.DataSource = GetAll();
        }


        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Update(new SubeModel
                {
                    subeId = Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value),
                    subeAd = textBox9.Text,
                    subeAdres = textBox8.Text,
                    subeTelefon = textBox1.Text,
                    subeMail = textBox2.Text,
                    personelId = Convert.ToInt32(chooseTypeBox.SelectedValue)
                });
                MessageBox.Show("Şube Sistemimize Başarıyla Guncellenmiştir.");
            }
            dgwSubeler.DataSource = GetAll();
        }
         
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value));
                MessageBox.Show("Şube Sistemimize Başarıyla Silinmiştir.");
            }
            dgwSubeler.DataSource = GetAll();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgwSubeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox9.Text = dgwSubeler.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dgwSubeler.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dgwSubeler.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dgwSubeler.CurrentRow.Cells[4].Value.ToString();
        }
        

        private void chooseTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chooseTypeBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
