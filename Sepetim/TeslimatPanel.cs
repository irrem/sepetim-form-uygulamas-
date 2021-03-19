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
    public partial class TeslimatPanel : Form
    {
        public TeslimatPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
        public bool admin = false;
        private void ConnectionControl()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        private void dgwSubeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSiparisId = Convert.ToInt32(dgwSiparis.CurrentRow.Cells[0].Value);
            label4.Text = "Sipariş kodu:  "+dgwSiparis.CurrentRow.Cells[0].Value.ToString();
        }

        private void TeslimatPanel_Load(object sender, EventArgs e)
        {
            siparisSilBtn.Visible = false ;
            button1.Visible = false;
            dgwSiparis.DataSource = GetSiparis();
            PersonelGetir();
             dgwTeslimat.DataSource = TeslimatGoruntule();
            if (admin)
            {
                siparisSilBtn.Visible=true;
                button1.Visible = true;
            }

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Siparis where  siparisId=@siparisId", baglanti);
            command.Parameters.AddWithValue("siparisId", id);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void PersonelGetir()
        {
            PersonelPanel personel = new PersonelPanel();
            chooseTypeBox.DataSource = personel.GetAllWithCategory(3);
            chooseTypeBox.DisplayMember = "personelAdSoyad";
            chooseTypeBox.ValueMember = "personelId";
        }

        public List<SiparisModel> GetSiparis()
        {
            ConnectionControl();
            SqlCommand command;
            
                command = new SqlCommand("Select * from Siparis", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<SiparisModel> Siparis = new List<SiparisModel>();
            while (reader.Read())
            {
                SiparisModel siparisModel = new SiparisModel
                {
                    siparisId = Convert.ToInt32(reader["siparisId"]),
                    urunId = Convert.ToInt32(reader["urunId"]),
                    subeId = Convert.ToInt32(reader["subeId"]),
                    musteriId = Convert.ToInt32(reader["musteriId"]),
                    siparisTutar = Convert.ToInt32(reader["siparisTutar"])
                };
                Siparis.Add(siparisModel);
            }
            reader.Close();
            baglanti.Close();
            return Siparis;
        }
        public void Add(TeslimatModel teslimat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Teslimat values (@personelId,@siparisId,@teslimatSaatiMin,@teslimatSaatiMax,@teslimatDurumu)", baglanti);

           
            command.Parameters.AddWithValue("personelId", teslimat.personelId);
            command.Parameters.AddWithValue("siparisId", teslimat.siparisId); 
            command.Parameters.AddWithValue("teslimatSaatiMin", teslimat.teslimatSaatiMin);
            command.Parameters.AddWithValue("teslimatSaatiMax", teslimat.teslimatSaatiMax);
            command.Parameters.AddWithValue("teslimatDurumu", teslimat.teslimatDurumu);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void KuryeIsGuncelle(KuryeIsYukuModel kurye)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update KuryeIsYuku set durum=@durum,calismaSaati=@calismaSaati where personelId=@personelId", baglanti);

            command.Parameters.AddWithValue("personelId", kurye.personelId);
            command.Parameters.AddWithValue("durum", kurye.durum);
            command.Parameters.AddWithValue("calismaSaati", kurye.calismaSaati);
            command.ExecuteNonQuery();

            baglanti.Close();

        }
        public void KuryeIsEkle(KuryeIsYukuModel kurye)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into KuryeIsYuku values (@personelId,@durum,@calismaSaati)", baglanti);

            command.Parameters.AddWithValue("personelId", kurye.personelId);
            command.Parameters.AddWithValue("durum", kurye.durum);
            command.Parameters.AddWithValue("calismaSaati", kurye.calismaSaati);
            command.ExecuteNonQuery();

            baglanti.Close();

        }


        public int secilenSiparisId;
        public void Update(TeslimatModel teslimat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Teslimat set teslimatDurumu=@teslimatDurumu where teslimatId=@teslimatId", baglanti);
            command.Parameters.AddWithValue("teslimatId", teslimat.teslimatId);
            command.Parameters.AddWithValue("teslimatDurumu", teslimat.teslimatDurumu);
            command.ExecuteNonQuery();
            MessageBox.Show(teslimat.teslimatId.ToString());

            baglanti.Close();

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            
            int x = int.Parse(localDate.ToShortTimeString().Substring(0, 2));
            if (x != null)
            {
                string sonCalismaSaati=personelCalismaSaatiCek(Convert.ToInt32(chooseTypeBox.SelectedValue));
                
                if (sonCalismaSaati != "")
                {
                    int choosePersonel = Convert.ToInt32(chooseTypeBox.SelectedValue);
                    DateTime sonSaat = Convert.ToDateTime(sonCalismaSaati);
                    if (Convert.ToInt32(DateTime.Now.ToShortTimeString().Substring(0, 2)) - Convert.ToInt32(sonSaat.ToShortTimeString().Substring(0, 2)) < 2)
                        MessageBox.Show("Kurye dağıtımda, başka personel seçiniz!");
                    else
                    {
                        if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Add(new TeslimatModel
                            {
                                personelId = Convert.ToInt32(chooseTypeBox.SelectedValue),
                                siparisId = secilenSiparisId,
                                teslimatSaatiMin = DateTime.Now,
                                teslimatSaatiMax = DateTime.Now.AddHours(2),
                                teslimatDurumu = "Teslimat Bekleniyor"
                            });
                            KuryeIsGuncelle(new KuryeIsYukuModel
                            {
                                personelId = Convert.ToInt32(chooseTypeBox.SelectedValue),
                                durum = "Dolu",
                                calismaSaati = DateTime.Now.AddHours(2)

                            });
                            MessageBox.Show("Sipariş Teslimat Listesine Eklenmiştir.");

                            dgwTeslimat.DataSource = TeslimatGoruntule();
                        }
                    }
                   
                }
                else
                {
                        int choosePersonel = Convert.ToInt32(chooseTypeBox.SelectedValue);

                        if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Add(new TeslimatModel
                            {
                                personelId = Convert.ToInt32(chooseTypeBox.SelectedValue),
                                siparisId = secilenSiparisId,
                                teslimatSaatiMin = DateTime.Now,
                                teslimatSaatiMax = DateTime.Now.AddHours(2),
                                teslimatDurumu = "Teslimat Bekleniyor"
                            });
                            KuryeIsEkle(new KuryeIsYukuModel
                            {
                                personelId = Convert.ToInt32(chooseTypeBox.SelectedValue),
                                durum = "Dolu",
                                calismaSaati = DateTime.Now.AddHours(2)

                            });
                            MessageBox.Show("Sipariş Teslimat Listesine Eklenmiştir.");
                        }

                        dgwTeslimat.DataSource = TeslimatGoruntule();
                }
               
                
            }
            else
                MessageBox.Show("Çalışma Saatleri Dışında Teslimat Ekleyemezsiniz!");
        }
        public List<TeslimatModel> TeslimatGoruntule()
        {
            ConnectionControl();
            SqlCommand command;

            command = new SqlCommand("Select * from Teslimat", baglanti);

            SqlDataReader reader = command.ExecuteReader();
            List<TeslimatModel> Teslimat = new List<TeslimatModel>();
            while (reader.Read())
            {
                TeslimatModel teslimatModel = new TeslimatModel
                {
                    teslimatId= Convert.ToInt32(reader["teslimatId"]),
                    siparisId = Convert.ToInt32(reader["siparisId"]),
                    personelId = Convert.ToInt32(reader["personelId"]),
                    teslimatSaatiMin = Convert.ToDateTime(reader["teslimatSaatiMin"]),
                    teslimatSaatiMax = Convert.ToDateTime(reader["teslimatSaatiMax"]),
                    teslimatDurumu = reader["teslimatDurumu"].ToString()
                };
                Teslimat.Add(teslimatModel);
            }
            reader.Close();
            baglanti.Close();
            return Teslimat;
        }
        public List<TeslimatModel> TeslimatGoruntuleTariheGore(DateTime date1,DateTime date2)
        {
            ConnectionControl();
            SqlCommand command;

            command = new SqlCommand("Select * from Teslimat where teslimatSaatiMax>@date1 and teslimatSaatiMax<@date2", baglanti);
            command.Parameters.AddWithValue("date1", date1);
            command.Parameters.AddWithValue("date2", date2);

            SqlDataReader reader = command.ExecuteReader();
            List<TeslimatModel> Teslimat = new List<TeslimatModel>();
            while (reader.Read())
            {
                TeslimatModel teslimatModel = new TeslimatModel
                {
                    teslimatId = Convert.ToInt32(reader["teslimatId"]),
                    siparisId = Convert.ToInt32(reader["siparisId"]),
                    personelId = Convert.ToInt32(reader["personelId"]),
                    teslimatSaatiMin = Convert.ToDateTime(reader["teslimatSaatiMin"]),
                    teslimatSaatiMax = Convert.ToDateTime(reader["teslimatSaatiMax"]),
                    teslimatDurumu = reader["teslimatDurumu"].ToString()
                };
                Teslimat.Add(teslimatModel);
            }
            reader.Close();
            baglanti.Close();
            return Teslimat;
        }

       public int siparisId, subeId, musteriId, siparisTutar;
        public void GetAllWithId(int id)
        {
            ConnectionControl();
            SqlCommand command;
            string personelAdSoyad = "";
            command = new SqlCommand("Select * from Siparis where siparisId=@id", baglanti);
            command.Parameters.AddWithValue("id", id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                siparisId = Convert.ToInt32(reader["siparisId"]);
                subeId = Convert.ToInt32(reader["subeId"]);
                musteriId= Convert.ToInt32(reader["musteriId"]);
                siparisTutar = Convert.ToInt32(reader["siparisTutar"]);
            }
            reader.Close();
            baglanti.Close();
        }

        
        public string personelCalismaSaatiCek(int id)
        {
            
            ConnectionControl();
            string calismaSaati = "";
            SqlCommand command;
            command = new SqlCommand("Select * from KuryeIsYuku where personelId=@personelId", baglanti);
            command.Parameters.AddWithValue("personelId", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                calismaSaati = reader["calismaSaati"].ToString();
            }
            reader.Close();
            baglanti.Close();
            return calismaSaati;

        }

        private void chooseTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siparisSilBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Delete(Convert.ToInt32(dgwSiparis.CurrentRow.Cells[0].Value));
                MessageBox.Show("Sipariş Sistemden Başarıyla Silinmiştir.");
            }
            dgwSiparis.DataSource = GetSiparis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                Update(new TeslimatModel
                {
                    teslimatId = Convert.ToInt32(dgwTeslimat.CurrentRow.Cells[0].Value),
                    teslimatDurumu = "Teslim edildi!"
                    
                });
                MessageBox.Show("Teslimat Başarıyla Tamamlanmıştır.");
                 }
             

            dgwTeslimat.DataSource = TeslimatGoruntule();

        }
        

        private void dgwTeslimat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSiparisLbl.Text = "Teslimat kodu:  "+dgwTeslimat.CurrentRow.Cells[0].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Update(new TeslimatModel
                {
                    teslimatId = Convert.ToInt32(dgwTeslimat.CurrentRow.Cells[0].Value),
                    teslimatDurumu = "İptal edildi!"

                });
                MessageBox.Show("Teslimat İptal Edilmiştir.");

            }


            dgwTeslimat.DataSource = TeslimatGoruntule();
        }
    }
}
