using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeepAnalysis.Core;
using System.Net;

namespace DeepAnalysis.Gui.WinForms
{
    public partial class CardView : UserControl
    {
        private Card card;

        public CardView()
        {
            InitializeComponent();
            Populate();
        }

        public Card Card
        {
            get { return card; }
            set
            {
                card = value;
                Populate();
            }
        }

        private void Populate()
        {
            textBoxName.Text = string.Empty;
            textBoxManaCost.Text = string.Empty;
            textBoxType.Text = string.Empty;
            textBoxOracleText.Text = string.Empty;
            listBoxPrintings.Items.Clear();
            pictureBoxPrintImage.Image = null;

            if (Card != null)
            {
                textBoxName.Text = Card.Text;
                textBoxManaCost.Text = Card.Cost.ToString();
                textBoxType.Text = Card.Typeline;
                textBoxOracleText.Text = Card.Text.Replace("\n", "\r\n");
                listBoxPrintings.Items.AddRange((from printing in Card.Printings select printing.Edition.Name).ToArray());
                listBoxPrintings.SelectedIndex = 0;
            }
        }

        private void listBoxPrintings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Card != null && listBoxPrintings.SelectedItem != null)
            {
                string url = Card.Printings[listBoxPrintings.SelectedIndex].ImageUrl;
                pictureBoxPrintImage.Image = Bitmap.FromStream(HttpWebRequest.Create(url).GetResponse().GetResponseStream());
            }
        }
    }
}
