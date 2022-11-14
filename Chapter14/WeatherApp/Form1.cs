using Newtonsoft.Json;
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


namespace WeatherApp {
    public partial class Form1 : Form {
        //List<string> jsonlist = new List<string>();
        public Form1() {
            InitializeComponent();
              
        }

        private void btWeathorGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");

            var json = JsonConvert.DeserializeObject<Class1[]>(dString);

            comboBox1.Items.Add(json[0].timeSeries[0].areas[0].area.name);

            //jsonlist.Add(json.name);

            /*foreach (var b in jsonlist) {
                comboBox1.Items.Add(b);
            }*/
            

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}
