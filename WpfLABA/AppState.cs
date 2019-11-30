using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;

namespace WpfLABA
{
    class AppState
    {
        public static void Download(string s)
        {
            WebClient client = new WebClient();
            String url = "https://bdu.fstec.ru/documents/files/thrlist.xlsx";
            var fullPath = Path.GetTempPath();
            client.DownloadFile(url, fullPath + s);
        }
        public static List<Threats> Convert(string s)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(Path.GetTempPath() + s, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                {
                    FilterRow = rowReader => rowReader.Depth > 1
                }
            });
            DataTable dt = result.Tables[0];
            List<Threats> li = new List<Threats>();
            foreach (DataRow i in dt.Rows)
            {
                Threats threat = new Threats();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    threat[j] = i[j];
                }
                li.Add(threat);
            }
            stream.Close();
            return li;
        }
    }
}
