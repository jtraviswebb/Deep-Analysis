using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeepAnalysis.Cube;
using DeepAnalysis.Core;

namespace DeepAnalysis.Gui.WinForms
{
    public partial class CubeView : UserControl
    {
        private CubeEntry entry;
        private Database cardDatabase;

        public CubeView()
        {
            InitializeComponent();
            comboBoxEntryStatus.DataSource = Enum.GetValues(typeof(CubeEntry.EntryStatus));
        }

        public Database CardDatabase
        {
            get { return cardDatabase; }
            set { cardDatabase = value; }
        }

        public CubeEntry Entry
        {
            get { return entry; }
            set { entry = value; }
        }

        private void comboBoxEntryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entry.Status = (CubeEntry.EntryStatus)comboBoxEntryStatus.SelectedValue; 
        }
    }
}
