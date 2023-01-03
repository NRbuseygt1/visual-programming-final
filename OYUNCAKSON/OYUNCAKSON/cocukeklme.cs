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
    public partial class cocukeklme : Form
    {
        public cocukeklme()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            if(bisim.Text == "" || bdate.ToString()== "" || bcin.Text == "" || bkrktr.Text == "" || bilgi.Text == "")
            {
                MessageBox.Show("boş bırakmayınız !");
            }
            else
            {
                MessageBox.Show("ÇOCUK EKLENDİ.! ");
                MessageBox.Show("KATEGORİ VE YAŞ SEÇİNİZ ");
                kategoriyas ktgry = new kategoriyas();
                ktgry.Show();
                this.Hide();
            }



            string query = "INSERT INTO cocuklar(isim, date, cinsiyet, karakter, ilgi)values" +
         "('" + bisim.Text + "' , '" + bdate.Text.ToString() + "' , '" + bcin.Text.ToString() + "' ," +
         " '" + bkrktr.Text.ToString() + "' , '" + bilgi.Text.ToString() + "')";

           
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

        private void cocukeklme_Load(object sender, EventArgs e)
        {

        }

        private void cocukeklme_Load_1(object sender, EventArgs e)
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
