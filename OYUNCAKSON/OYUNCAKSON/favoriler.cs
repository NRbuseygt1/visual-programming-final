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
    public partial class favoriler : Form
    {
        public favoriler()
        {
            InitializeComponent();
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO fav(oyuncak)values" +
          "( '" + bfavlist.Text.ToString() + "')";

            try
            {
                mysqlbaglan.Open();

                MySqlCommand com = new MySqlCommand(query, mysqlbaglan);
                com.ExecuteNonQuery();
                MessageBox.Show("FAVORİLER EKLENDİ.! ");
                mysqlbaglan.Close();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }

        }

        private void favoriler_Load(object sender, EventArgs e)
        {

        }
    }
}
