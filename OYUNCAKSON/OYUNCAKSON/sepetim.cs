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
    public partial class sepetim : Form
    {
        public sepetim()
        {
            InitializeComponent();
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO sepet(sepet)values" +
          "( '" + sepetlist.Text.ToString() + "')";

            try
            {
                mysqlbaglan.Open();

                MySqlCommand com = new MySqlCommand(query, mysqlbaglan);
                com.ExecuteNonQuery();
                MessageBox.Show("ÜRÜNLER SEPETE EKLENDİ.! ");
                mysqlbaglan.Close();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sepetim_Load(object sender, EventArgs e)
        {
            sepetlist.Items.Clear();
                mysqlbaglan.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM sepet", mysqlbaglan);
                MySqlDataReader read = sorgu.ExecuteReader();
                while(read.Read())
                {
                    sepetlist.Items.Add(read["isim"].ToString()+ " - " + read["fiyat"].ToString()+"-  Adet :"+ read["sepet"].ToString());
                }
                read.Close();
                mysqlbaglan.Close();
                

            
        }
    }
}
