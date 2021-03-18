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
    public partial class SubeSorumlusuPanel : Form
    {
        public SubeSorumlusuPanel()
        {
            InitializeComponent();
        }

        private void personelControl_Click(object sender, EventArgs e)
        {
            PersonelPanel personel = new PersonelPanel();
            personel.subeSorumlusu = true;
            personel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeslimatPanel teslimatPanel = new TeslimatPanel();
            teslimatPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
        }
    }
}
