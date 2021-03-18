using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sepetim
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        public DateTime kucukTarih;
        public DateTime buyukTarih;
        public int persId, sipId, tesId;
        TeslimatPanel teslimat = new TeslimatPanel();
        PersonelPanel personel = new PersonelPanel();
        SubePanel sube = new SubePanel();
        MusteriPanel musteri = new MusteriPanel();

        private void Rapor_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            kucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            buyukTarih = Convert.ToDateTime(dateTimePicker2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            persId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            label3.Text= "Teslim Eden Kurye: "+personel.GetAllWithId(persId);
            sipId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            teslimat.GetAllWithId(sipId);
            label4.Text ="Sipariş Tutarı: "+teslimat.siparisTutar.ToString();
            label5.Text = "Müşteri: " + musteri.GetAllWithId(teslimat.musteriId);
            label6.Text = "Şube: " + sube.GetAllWithId(teslimat.subeId);
            label7.Text = "Teslimat Tarihi: " + dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label8.Text = "Sipariş Kodu: " + teslimat.siparisId.ToString();



        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            if (kucukTarih.ToString() != "1.01.0001 00:00:00" && buyukTarih.ToString() != "1.01.0001 00:00:00")
                dataGridView1.DataSource = teslimat.TeslimatGoruntuleTariheGore(kucukTarih, buyukTarih);
            else
                MessageBox.Show("Tarih Aralığı Seçiniz!");

        }
    }
}
