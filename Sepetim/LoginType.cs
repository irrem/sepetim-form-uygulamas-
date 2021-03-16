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
    public partial class LoginType : Form
    {
        public LoginType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.persType = 2;
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.persType = 3;
            login.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.persType = 1;
            login.Show();
            this.Hide();
        }
    }
}
