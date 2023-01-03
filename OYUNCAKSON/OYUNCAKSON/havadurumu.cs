﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OYUNCAKSON
{
    public partial class hava_durumu : Form
    {
        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public hava_durumu()
        {
            InitializeComponent();
        }

        private void hava_durumu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_durumu_link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string ili = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string maks_sicaklik = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ili;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = maks_sicaklik;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
