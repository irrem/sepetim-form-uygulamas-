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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void productListBtn_Click(object sender, EventArgs e)
        {
            UrunlerPanel urunlerPanel = new UrunlerPanel();
            urunlerPanel.Show();
        }

        private void viewCategory_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Show();

        }

        private void viewCostumersBtn_Click(object sender, EventArgs e)
        {
            MusteriPanel musteriPanel = new MusteriPanel();
            musteriPanel.Show();
        }

        private void viewWorkPlaceBtn_Click(object sender, EventArgs e)
        {
            SubePanel subePanel = new SubePanel();
            subePanel.Show();
        }

        private void viewWorkerBtn_Click(object sender, EventArgs e)
        {
            PersonelPanel personelPanel = new PersonelPanel();
            personelPanel.Show();

        }
    }
}
