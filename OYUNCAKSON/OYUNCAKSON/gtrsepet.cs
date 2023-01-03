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
    public partial class gtrsepet : Form
    {
        public gtrsepet()
        {
            InitializeComponent();
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void gtrsepet_Load(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            MySqlDataAdapter dad = new MySqlDataAdapter("Select * from getirsepet", mysqlbaglan);
            DataTable dt = new DataTable();
            dad.Fill(dt);
            tablo.DataSource = dt;
            mysqlbaglan.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
