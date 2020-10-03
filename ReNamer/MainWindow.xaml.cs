using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ReNamer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string text;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                s = File.ReadAllText(openFileDialog.FileName);

            this.text = s;
        }

        private void ReName_Click(object sender, RoutedEventArgs e)
        {
            string name = OriginName.Text.Trim();
            string pattern = name.Substring(0, name.Length - 1) + "[аяиыеуюо]й?м?[\\s?!\\.,-_]";
            MatchCollection matches = Regex.Matches(text,  pattern);
            int i = 1;
        }
    }
}
