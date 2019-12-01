using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
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

namespace WpfLABA.Views
{
    /// <summary>
    /// Interaction logic for Refresh.xaml
    /// </summary>
    public partial class Refresh : UserControl
    {
        public Refresh()
        {
            InitializeComponent();
            List<Threats> li = (List<Threats>)Application.Current.Properties["List"];
            List<Threats> lili = AppState.Convert("thrliste.xlsx");
            int count = 0;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i][0].GetHashCode() != lili[i][0].GetHashCode() || li[i][1].GetHashCode() != lili[i][1].GetHashCode() || li[i][2].GetHashCode() != lili[i][2].GetHashCode() || li[i][3].GetHashCode() != lili[i][3].GetHashCode())
                {
                    count++;
                }
                
            }
            if (count==0)
            {
                TextBlock printTextBlock666 = new TextBlock();
                printTextBlock666.Text = "НИЧЕГО НЕ ПОМЕНЯЛОСЬ";
                StackPanell.Children.Add(printTextBlock666);
            }
            else
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i][0].GetHashCode() != lili[i][0].GetHashCode() || li[i][1].GetHashCode() != lili[i][1].GetHashCode() || li[i][2].GetHashCode() != lili[i][2].GetHashCode() || li[i][3].GetHashCode() != lili[i][3].GetHashCode())
                    {
                        TextBlock printTextBlock = new TextBlock();
                        printTextBlock.Text = "БЫЛО";
                        StackPanell.Children.Add(printTextBlock);
                        for (int j = 0; j < 5; j++)
                        {
                            TextBlock printTextBlock1 = new TextBlock();
                            printTextBlock1.Text = Convert.ToString(li[i][j]);
                            StackPanell.Children.Add(printTextBlock1);
                        }
                        TextBlock printTextBlock2 = new TextBlock();
                        printTextBlock2.Text = "СТАЛО";
                        StackPanell.Children.Add(printTextBlock2);
                        for (int j = 0; j < 5; j++)
                        {

                            TextBlock printTextBlock3 = new TextBlock();
                            printTextBlock3.Text = Convert.ToString(lili[i][j]);
                            StackPanell.Children.Add(printTextBlock3);
                        }
                    }
                }
                Application.Current.Properties["List"] = lili;
                File.Delete(System.IO.Path.GetTempPath() + "thrlist.xlsx");
                File.Move(System.IO.Path.GetTempPath() + "thrliste.xlsx", System.IO.Path.GetTempPath() + "thrlist.xlsx");
            }
            File.Delete(System.IO.Path.GetTempPath() + "thrliste.xlsx");
        }
    }
}
