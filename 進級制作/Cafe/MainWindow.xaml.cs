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


namespace Cafe {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }
        private void btnSaveFile_Click(object sender, RoutedEventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //if (saveFileDialog.ShowDialog() == true)
                //File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }
        string GetJsonTextFromSearchWord(string word) {
            string query = System.Web.HttpUtility.UrlEncode(word);
            string url = String.Format("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=[APIキー]&lat=33.590543&lng=130.420096&range=2&order=1&format=json", "8b007c053531c36e", query);

            System.Net.HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            System.Net.HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            System.IO.Stream stream = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string jsonText = sr.ReadToEnd();
            sr.Close();
            stream.Close();
            res.Close();

            // JsonTextを解析して結果を取得する
            //MapInfo MapInfo = JsonSerializer.Deserialize<MapInfo>(jsonText);

            return jsonText;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Area area = new Area();
            area.Show();
        }
    }
}

