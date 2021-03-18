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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        // SqlConnection _connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; initial catalog=EczaneOtoData;integrated security=true");
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public List<KategoriModel> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kategori", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<KategoriModel> kategoriUrunler = new List<KategoriModel>();
            while (reader.Read())
            {
                KategoriModel kategoriUrun = new KategoriModel
                {
                    KategoriAd = reader["kategoriAd"].ToString(),
                    KategoriKodAd = reader["kategoriKodAd"].ToString(),
                    KategoriId = Convert.ToInt32(reader["kategoriId"])

                };
                kategoriUrunler.Add(kategoriUrun);
            }
            reader.Close();
            baglanti.Close();
            return kategoriUrunler;
        }

        public void Add(KategoriModel kategoriUrun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Kategori values (@KategoriAd,@KategoriKodAd)", baglanti);
            command.Parameters.AddWithValue("kategoriAd", kategoriUrun.KategoriAd);
            command.Parameters.AddWithValue("kategoriKodAd", kategoriUrun.KategoriKodAd);
            command.ExecuteNonQuery();
            baglanti.Close();

        }
        public void Update(KategoriModel kategoriUrun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Kategori set kategoriAd=@KategoriAd,kategoriKodAd=@KategoriKodAd where kategoriId=@KategoriId", baglanti);
            command.Parameters.AddWithValue("kategoriId", kategoriUrun.KategoriId);
            command.Parameters.AddWithValue("kategoriAd", kategoriUrun.KategoriAd);
            command.Parameters.AddWithValue("kategoriKodAd", kategoriUrun.KategoriKodAd);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Kategori where  kategoriId=@KategoriId", baglanti);

            command.Parameters.AddWithValue("kategoriId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            dgwCategory.DataSource = GetAll();
        }

        private void dgwCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryTxt.Text = dgwCategory.CurrentRow.Cells[1].Value.ToString();
            categoryCTxt.Text = dgwCategory.CurrentRow.Cells[2].Value.ToString();
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Update(new KategoriModel
                {
                    KategoriId = Convert.ToInt32(dgwCategory.CurrentRow.Cells[0].Value),
                    KategoriAd = categoryTxt.Text,
                    KategoriKodAd = categoryCTxt.Text
                });
                MessageBox.Show("Ürün Sistemimize Başarıyla Guncellenmiştir.");
            }
            dgwCategory.DataSource = GetAll();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Add(
                    new KategoriModel{
                    KategoriAd = categoryTxt.Text ,
                        KategoriKodAd = categoryCTxt.Text
                    });
                MessageBox.Show("Ürün Sistemimize Başarıyla Eklenmiştir.");
            }
            dgwCategory.DataSource = GetAll();
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwCategory.CurrentRow.Cells[0].Value));
                MessageBox.Show("Ürün Sistemimize Başarıyla Silinmiştir.");
            }
            dgwCategory.DataSource = GetAll();
        }

        private void categoryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
