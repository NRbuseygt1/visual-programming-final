using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUNCAKSON
{
    public partial class muzık : Form
    {

       // private object mysqlbaglan;
        Baglan mysqlbaglan = new Baglan();

        public muzık()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
         // MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label10.Text + "','" + label2.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void muzık_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            kategoriyas ktgrys = new kategoriyas();
            ktgrys.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
               
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label10.Text + "','" + label2.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','" + label1.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','" + label1.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','" + label1.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','" + label1.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','" + label1.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sepetim spt = new sepetim();
            spt.Show();
        }
    }
}
