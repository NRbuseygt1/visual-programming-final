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
    public partial class magaza : Form
    {
        public magaza()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=oyuncak;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            switch (bsehir.SelectedIndex)
            {
                case 0:
                        saat.Text = "HAFTA İÇİ: 07.00-22.00   HAFTA SONU: 07.00-23.00";
                        number.Text = "05375664748 - 05371125869";
                    badres.Text=(" Kocatepe, Forum İstanbul Alışveriş Merkezi Paşa Caddesi " +
                            "No:3 D:B1 22 - 24, 34045 Bayrampaşa/İstanbul");
                break;
                case 1:
                    saat.Text = "HAFTA İÇİ: 07.00-22.00   HAFTA SONU: 07.00-23.00";
                    number.Text = "05375664748 - 05371125869";
                    badres.Text=("Akkent Mahallesi, Eskişehir karayolu No: 1/4, Merkez Sk., 43030"); 

                break;
                case 2:
                    saat.Text = "HAFTA İÇİ: 07.00-22.00   HAFTA SONU: 07.00-23.00";
                    number.Text = "05375664748 - 05371125869";
                    badres.Text=("Karşıyaka, Orpin Pet.Ür.Trz.Inş.Nak.Paz.San.Tic.Ltd.Şti, Atatürk Blv." +
                        " No:388, 52200 Altınordu/Ordu");
                break;
                case 3:
                    saat.Text = "HAFTA İÇİ: 07.00-22.00   HAFTA SONU: 07.00-23.00";
                    number.Text = "05375664748 - 05371125869";
                    badres.Text=("Kent Plaza Bedir Mahallesi Ataseven Caddesi Kentplaza Alışveriş ve" +
                        " Yaşam Merkezi Selçuklu Caddesi" +
                        " No:23 D:Kat:2 No. 2, 42100 Selçuk/Konya");
                    break;
            }

                 string query = "INSERT INTO mgz(magazalar)values" +
                  "('" + bsehir.Text + "')";


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

        private void magaza_Load(object sender, EventArgs e)
        {

        }
    }
}
