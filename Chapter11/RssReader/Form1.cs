using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<string> linkList = new List<string>();
        List<string> titleList = new List<string>();
        private IEnumerable<string> xTitle, xLink;

        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {
            using (var ws = new WebClient()) {

                lbRssTitle_Clear();

                var stream = ws.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (String)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (String)x.Element("link"));

                foreach (var date in xTitle) {
                    lbRssTitle.Items.Add(date);
                }
                setCbRssUrl(cbRssUrl.Text);
                }
            }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            var index = lbRssTitle.SelectedIndex; //選択した箇所のインデックスを取得（0～　）
            var url = xLink.ElementAt(index);
            wvBrowser.Source = new Uri(url);
        }

        private void btForward_Click(object sender, EventArgs e) {
            wvBrowser.GoForward();
        }

        private void bt_Click(object sender, EventArgs e) {
            wvBrowser.GoBack();
        }

        private void setCbRssUrl(string url) {

            if (!cbRssUrl.Items.Contains(url)) {
                cbRssUrl.Items.Add(url);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }

        private void lbRssTitle_Clear() {
            lbRssTitle.Items.Clear();
            wvBrowser.Refresh();
        }
    }
}
