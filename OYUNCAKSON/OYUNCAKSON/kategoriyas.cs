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
    public partial class kategoriyas : Form
    {
        public kategoriyas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            
          
            string query = "INSERT INTO kategoriys(kategori, yas)values" +
          "( '" + bkategori.Text.ToString() + "' , '" + byas.Text.ToString() + "')";


            try 
            {
                mysqlbaglan.Open();

                MySqlCommand com = new MySqlCommand(query, mysqlbaglan);
                com.ExecuteNonQuery();
                MessageBox.Show("EN UYGUN OYUNCAK SEÇENEKLERİ ARANIYOR.! ");
                mysqlbaglan.Close();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }

            switch (bkategori.SelectedIndex)
            {
                case 0:
                    bahce bah = new bahce();
                    bah.Show();
                    this.Hide();
                break;
                case 1:
                    muzık mzk = new muzık();
                    mzk.Show();
                    this.Hide();
               break;
                case 2:
                    arababebek rbk = new arababebek();
                    rbk.Show();
                    this.Hide();
                break;


            }

        }

        private void kategoriyas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cocukeklme cckekle = new cocukeklme();
            cckekle.Show();
            this.Hide();
        }
    }
}
