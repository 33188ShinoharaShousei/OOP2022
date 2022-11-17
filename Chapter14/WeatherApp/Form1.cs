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
using WetherApp;

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
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/common/const/area.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //switch (json) {
            //    case _010100:
                    
            //        break;


            //}


        }
        
        private void Form1_Load(object sender, EventArgs e) {
            comboBox1.Items.Add("宗谷地方");
            comboBox1.Items.Add("上川・留萌地方");
            comboBox1.Items.Add("網走・北見・紋別地方");
            comboBox1.Items.Add("十勝地方");
            comboBox1.Items.Add("釧路・根室地方");
            comboBox1.Items.Add("胆振・日高地方");
            comboBox1.Items.Add("石狩・空知・後志地方");
            comboBox1.Items.Add("渡島・檜山地方");
            comboBox1.Items.Add("青森県");
            comboBox1.Items.Add("岩手県");
            comboBox1.Items.Add("宮城県");
            comboBox1.Items.Add("秋田県");
            comboBox1.Items.Add("山形県");
            comboBox1.Items.Add("福島県");
            comboBox1.Items.Add("茨城県");
            comboBox1.Items.Add("栃木県");
            comboBox1.Items.Add("群馬県");
            comboBox1.Items.Add("埼玉県");
            comboBox1.Items.Add("千葉県");
            comboBox1.Items.Add("東京都");
            comboBox1.Items.Add("神奈川県");
            comboBox1.Items.Add("山梨県");
            comboBox1.Items.Add("長野県");
            comboBox1.Items.Add("岐阜県");
            comboBox1.Items.Add("静岡県");
            comboBox1.Items.Add("愛知県");
            comboBox1.Items.Add("三重県");
            comboBox1.Items.Add("新潟県");
            comboBox1.Items.Add("富山県");
            comboBox1.Items.Add("石川県");
            comboBox1.Items.Add("福井県");
            comboBox1.Items.Add("滋賀県");
            comboBox1.Items.Add("京都府");
            comboBox1.Items.Add("大阪府");
            comboBox1.Items.Add("兵庫県");
            comboBox1.Items.Add("奈良県");
            comboBox1.Items.Add("和歌山県");
            comboBox1.Items.Add("鳥取県");
            comboBox1.Items.Add("香川県");
            comboBox1.Items.Add("愛媛県");
            comboBox1.Items.Add("高知県");
            comboBox1.Items.Add("山口県");
            comboBox1.Items.Add("福岡県");
            comboBox1.Items.Add("佐賀県");
            comboBox1.Items.Add("長崎県");
            comboBox1.Items.Add("熊本県");
            comboBox1.Items.Add("大分県");
            comboBox1.Items.Add("宮崎県");
            comboBox1.Items.Add("奄美地方");
            comboBox1.Items.Add("鹿児島県（奄美地方除く");
            comboBox1.Items.Add("沖縄本島地方");
            comboBox1.Items.Add("大東島地方");
            comboBox1.Items.Add("宮古島地方");
            comboBox1.Items.Add("八重山地方");
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            //textBox2.Text = 
        }
    }
}
