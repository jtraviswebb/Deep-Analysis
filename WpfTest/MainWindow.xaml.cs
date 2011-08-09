using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] urls = { "http://magiccards.info/scans/en/ne/128.jpg", "http://magiccards.info/scans/en/pc/5.jpg", "http://magiccards.info/scans/en/le/97.jpg",
                              "http://magiccards.info/scans/en/po2/11.jpg", "http://magiccards.info/scans/en/8e/307.jpg", "http://magiccards.info/scans/en/nph/28.jpg",
                              "http://magiccards.info/scans/en/ps/16.jpg", "http://magiccards.info/scans/en/6e/287.jpg", "http://magiccards.info/scans/en/pr/128.jpg" };

            foreach (string url in urls)
            {
                Image img = new Image();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(url, UriKind.Absolute);
                bitmap.EndInit();
                img.Source = bitmap;
                img.Width = 125;
                
                listView1.Items.Add(img);
            }
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.AddedItems);
        }
    }
}
