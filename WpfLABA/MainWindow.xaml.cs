using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using WpfLABA.ViewModels;

namespace WpfLABA
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


        private void ShortView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ShortViewModel();
        }

        private void FullView_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new FullViewModel();
        }

        private void Refresh_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RefreshModel();
        }
        private void Close_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            String url = "https://bdu.fstec.ru/documents/files/thrlist.xlsx";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
                File.Copy(System.IO.Path.GetTempPath() + "thrlist.xlsx", saveFileDialog.FileName);
        }

    }
}
