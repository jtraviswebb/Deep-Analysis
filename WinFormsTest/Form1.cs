using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] urls = { "http://magiccards.info/scans/en/lw/1.jpg", "http://magiccards.info/scans/en/lw/2.jpg", "http://magiccards.info/scans/en/lw/3.jpg",
                              "http://magiccards.info/scans/en/lw/4.jpg", "http://magiccards.info/scans/en/lw/5.jpg", "http://magiccards.info/scans/en/lw/6.jpg",
                              "http://magiccards.info/scans/en/lw/7.jpg", "http://magiccards.info/scans/en/lw/8.jpg", "http://magiccards.info/scans/en/lw/9.jpg" };
            cardListView1.Items.Add(urls[0]);
            cardListView1.Items.Add(urls[1]);
            cardListView1.Items.Add(urls[2]);
            cardListView1.Items.Add(urls[3]);
            cardListView1.Items.Add(urls[4]);
            cardListView1.Items.Add(urls[5]);
            cardListView1.Items.Add(urls[6]);
            cardListView1.Items.Add(urls[7]);
            cardListView1.Items.Add(urls[8]);
        }
    }
}
