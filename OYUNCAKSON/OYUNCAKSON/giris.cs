
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

    public partial class giris : Form
    {
        Baglan mysqlbaglan = new Baglan();
        public giris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            kayitol kyt = new kayitol();
            kyt.Show();
            this.Hide();

        }

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminpaneli adm = new adminpaneli();
            adm.Show();
            this.Hide();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(bemail.Text=="" ||  bsifre.Text=="")
            {
                MessageBox.Show("boş bırakmayınız !");
            }
            else
            {
                MessageBox.Show("giriş yapıldı. Lütfen çocuk seçiniz. ");
                cocukeklme ekle = new cocukeklme();
                ekle.Show();
                this.Hide();
            }




            string query = "INSERT INTO giris(mail, sifre)values" +
            "('" + bemail.Text + "' , '" + bsifre.Text + "')";

            try
            {
                mysqlbaglan.ac();
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {

                MessageBox.Show(ek.Message);
            }
         
        }
    }
}

