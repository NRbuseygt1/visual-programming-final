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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            if (bname.Text != "" || bsurname.Text != "" || bemail.Text != "" || btelefon.Text != "" || bsifre.Text != "")
            {
                MessageBox.Show("KAYIT OLUŞTURULDU. ");
                cocukeklme ekle = new cocukeklme();
                ekle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("boş bırakmayınız !");
            }

           

            


            string query = "INSERT INTO bilgiler(name, surname, email, telefon, sifre)values" +
             "('" + bname.Text + "' , '" + bsurname.Text + "' , '" + bemail.Text + "' ," +
             " '" + btelefon.Text + "' , '" + bsifre.Text + "')";

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

        private void kayitol_Load(object sender, EventArgs e)
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
