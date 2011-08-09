using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using DeepAnalysis.Core;

namespace CustomSetEditor
{
    public partial class FormCustomSetEditor : Form
    {
        public FormCustomSetEditor()
        {
            InitializeComponent();
            using (TextReader reader = new StreamReader(@"C:\cards.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Database));
                Database db = (Database)serializer.Deserialize(reader);
                cardSearchView.CardDatabase = db;
                reader.Close();
            }

            cardSearchView.Enabled = true;
        }

        private void FormCustomSetEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
