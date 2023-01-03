using MySql.Data.MySqlClient;

namespace OYUNCAKSON
{ 
    internal class Baglan
    {
        public MySqlConnection baglan;
        public Baglan()
        {

            baglan = new MySqlConnection("server=localhost;database=oyuncak;uid=root;password=''");

        }
        public void ac()
        {

            baglan.Open();
           
        }
        public void kapa() 
        { baglan.Close(); }
    }
}