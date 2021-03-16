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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =DESKTOP-UF1JUFT\SQLEXPRESS; initial catalog=Sepetim;integrated security=true");
       public int persType = 0;
        SqlCommand command;
        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       public void loginAdmin(string username, string password, int persType)
       {

            baglanti.Open();
            if(persType == 1)            
             command = new SqlCommand("Select * From Admin where adminUserName='" + username + "' and adminPassword='" + password + "'", baglanti);
            else if (persType == 3)           
             command = new SqlCommand("Select * From VeriGirisAdmin where veriGirisAdminAd='" + username + "' and veriGirisAdminSifre='" + password + "'", baglanti);
            else
             command = new SqlCommand("Select * From SubeGirisAdmin where subeGirisAdminAd='" + username + "' and subeGirisAdminSifre='" + password + "'", baglanti);
            
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (persType == 1)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else if (persType == 2)
                {
                    SubeSorumlusuPanel subeSorumlusu = new SubeSorumlusuPanel();
                    subeSorumlusu.Show();
                    this.Hide();
                }
                else
                {
                    VeriBilimciPanel veriBilimciPanel = new VeriBilimciPanel();
                    veriBilimciPanel.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Hatalı Giriş!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            baglanti.Close();
            command.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nameTxt.Text;
            string password = passwordTxt.Text;
            loginAdmin(username, password,this.persType);
        }

    }
}
