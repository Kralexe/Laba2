using System;
using System.Collections.Generic;
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
using WpfLABA.ViewModels;

namespace WpfLABA.Views
{
    /// <summary>
    /// Interaction logic for FullView.xaml
    /// </summary>
    public partial class FullView : UserControl
    {
        MainViewModel _main = new MainViewModel();
        public FullView()
        {
            InitializeComponent();
            DataContext = _main;
        }
    }
}
