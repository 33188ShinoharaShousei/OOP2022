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
        public Form1() {
            InitializeComponent();
        }
        
        List<string> linkList = new List<string>();
        List<string> titleList = new List<string>();
        private void btRssGet_Click(object sender, EventArgs e) {
            using (var ws = new WebClient()) {

                var stream = new WebClient().OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(x => (String)x.Element("title"));
                
                foreach (var date in xTitle) {
                    lbRssTitle.Items.Add(date);
                }
                foreach (var date in linkList) {
                    linkList.Add(date);
                }              
            }         
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            int index = lbRssTitle.SelectedIndex; //選択した箇所のインデックスを取得（0～　）
            wbBrowser.Navigate(linkList[0]);
        }
    }
}
