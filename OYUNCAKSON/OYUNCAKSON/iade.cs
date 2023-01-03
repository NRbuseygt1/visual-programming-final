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
    public partial class iade : Form
    {
        public iade()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO iaade(bilgi,neden)values" +
             "('" + bbilgi.Text + "' + '" + bneden.Text + "')";


            try
            {
                mysqlbaglan.Open();

                MySqlCommand com = new MySqlCommand(query, mysqlbaglan);
                com.ExecuteNonQuery();
                MessageBox.Show("İADE TALEBİ OLUŞTURULDU.!");
                mysqlbaglan.Close();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }
    }
}
