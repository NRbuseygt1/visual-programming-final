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
    public partial class arababebek : Form
    {
        Baglan mysqlbaglan = new Baglan();
        public arababebek()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {





            try
            {
                mysqlbaglan.ac();
                string query = "INSERT INTO sepet(sepet,isim,fiyat)values" +
             "('" + comboBox1.SelectedIndex.ToString() + "','" + label9.Text + "','"+ label1.Text+"')";
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("FAVORİLERE EKLENDİ.!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kategoriyas ktgrys = new kategoriyas();
            ktgrys.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sepetim spt = new sepetim();
             spt.Show();
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
             "('" + comboBox3.SelectedIndex.ToString() + "','" + label11.Text + "','" + label3.Text + "')";
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
             "('" + comboBox4.SelectedIndex.ToString() + "','" + label12.Text + "','" + label4.Text + "')";
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
             "('" + comboBox8.SelectedIndex.ToString() + "','" + label16.Text + "','" + label8.Text + "')";
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
             "('" + comboBox7.SelectedIndex.ToString() + "','" + label15.Text + "','" + label7.Text + "')";
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
             "('" + comboBox6.SelectedIndex.ToString() + "','" + label14.Text + "','" + label6.Text + "')";
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
             "('" + comboBox5.SelectedIndex.ToString() + "','" + label13.Text + "','" + label5.Text + "')";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
