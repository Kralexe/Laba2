using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLABA
{
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // here you take control
            
            if (!File.Exists(Path.GetTempPath() + "thrlist.xlsx"))
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("ВНИМАНИЕ! ФАЙЛА С УГРОЗАМИ НЕТУ НА ВАШЕМ КОМПУКТЕРЕ, ЗАГРУЗИТЬ?", "ПОДТВЕРЖДЕНИЕ ЗАГРУЗКИ", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    AppState.Download("thrlist.xlsx");
                }
                else
                {
                    Application.Current.Shutdown();
                }

            }
            
            Application.Current.Properties["List"] = AppState.Convert("thrlist.xlsx");

        }
    }
}
