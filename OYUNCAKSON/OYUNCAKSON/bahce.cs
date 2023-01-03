using MySql.Data.MySqlClient;
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
    public partial class bahce : Form
    {
        Baglan mysqlbaglan = new Baglan();
        public bahce()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "";
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + adet.SelectedIndex.ToString() + "','" + label9.Text + "','" + fyt.Text + "')";
                MySqlCommand com = new MySqlCommand(query, mysqlbaglan.baglan);
                com.ExecuteNonQuery();
                MessageBox.Show("Sepete Eklendi.");
                mysqlbaglan.kapa();
            }
            catch (Exception ek)
            {
                MessageBox.Show(ek.Message);
            }

            sepetim sptm = new sepetim();
            sptm.Show();
            this.Hide();

            
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kategoriyas ktgrys = new kategoriyas();
            ktgrys.Show();
            this.Hide();
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

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label11.Text + "','" + label2.Text + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label12.Text + "','" + label2.Text + "')";
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
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label15.Text + "','" + label2.Text + "')";
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
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label14.Text + "','" + label2.Text + "')";
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
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label13.Text + "','" + label2.Text + "')";
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
             "('" + comboBox2.SelectedIndex.ToString() + "','" + label10.Text + "','" + label1.Text + "')";
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
