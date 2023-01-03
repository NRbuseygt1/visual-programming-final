using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace OYUNCAKSON
{
    public partial class adminpaneli : Form
    {
        public adminpaneli()
        {
            InitializeComponent();
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            string isim, şifre;
            isim = bisim.Text;
            şifre = bsifre.Text;
            if(isim == "busenur" && şifre == "5252")
            {
                MessageBox.Show("Giriş yapıldı");
                cocukeklme ekle = new cocukeklme();
                ekle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
            
            string query = "INSERT INTO admin(isim, sifre)values" +
            "('" + bisim.Text + "' , '" + bsifre.Text + "')";

            try
            {
                mysqlbaglan.Open();

                MySqlCommand com = new MySqlCommand(query, mysqlbaglan);
                com.ExecuteNonQuery();
                mysqlbaglan.Close();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }

            
        }

        private void adminpaneli_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.Show();
            this.Hide();
        }
    }
}
