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
        public Form1() {
            InitializeComponent();
        }
        public int areaCode;
        private void btWeathorGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areaCode}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            psOffices.Text = json.publishingOffice;
            data.Text = json.text;

        }
        
        private void Form1_Load(object sender, EventArgs e) {
            cbarea.Items.Add("宗谷地方");
            cbarea.Items.Add("上川・留萌地方");
            cbarea.Items.Add("網走・北見・紋別地方");
            cbarea.Items.Add("十勝地方");
            cbarea.Items.Add("釧路・根室地方");
            cbarea.Items.Add("胆振・日高地方");
            cbarea.Items.Add("石狩・空知・後志地方");
            cbarea.Items.Add("渡島・檜山地方");
            cbarea.Items.Add("青森県");
            cbarea.Items.Add("岩手県");
            cbarea.Items.Add("宮城県");
            cbarea.Items.Add("秋田県");
            cbarea.Items.Add("山形県");
            cbarea.Items.Add("福島県");
            cbarea.Items.Add("茨城県");
            cbarea.Items.Add("栃木県");
            cbarea.Items.Add("群馬県");
            cbarea.Items.Add("埼玉県");
            cbarea.Items.Add("千葉県");
            cbarea.Items.Add("東京都");
            cbarea.Items.Add("神奈川県");
            cbarea.Items.Add("山梨県");
            cbarea.Items.Add("長野県");
            cbarea.Items.Add("岐阜県");
            cbarea.Items.Add("静岡県");
            cbarea.Items.Add("愛知県");
            cbarea.Items.Add("三重県");
            cbarea.Items.Add("新潟県");
            cbarea.Items.Add("富山県");
            cbarea.Items.Add("石川県");
            cbarea.Items.Add("福井県");
            cbarea.Items.Add("滋賀県");
            cbarea.Items.Add("京都府");
            cbarea.Items.Add("大阪府");
            cbarea.Items.Add("兵庫県");
            cbarea.Items.Add("奈良県");
            cbarea.Items.Add("和歌山県");
            cbarea.Items.Add("鳥取県");
            cbarea.Items.Add("香川県");
            cbarea.Items.Add("愛媛県");
            cbarea.Items.Add("高知県");
            cbarea.Items.Add("山口県");
            cbarea.Items.Add("福岡県");
            cbarea.Items.Add("佐賀県");
            cbarea.Items.Add("長崎県");
            cbarea.Items.Add("熊本県");
            cbarea.Items.Add("大分県");
            cbarea.Items.Add("宮崎県");
            cbarea.Items.Add("奄美地方");
            cbarea.Items.Add("鹿児島県（奄美地方除く");
            cbarea.Items.Add("沖縄本島地方");
            cbarea.Items.Add("大東島地方");
            cbarea.Items.Add("宮古島地方");
            cbarea.Items.Add("八重山地方");
        }

        private void cbarea_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbarea.Text) {
                case "群馬県":
                    areaCode = 100000;
                    break;
                case "栃木県":
                    areaCode = 090000;
                    break;
                case "茨城県":
                    areaCode = 080000;
                    break;
                case "東京都":
                    areaCode = 130000;
                    break;
                case "千葉県":
                    areaCode = 120000;
                    break;
                case "神奈川県":
                    areaCode = 140000;
                    break;
                case "埼玉県":
                    areaCode = 110000;
                    break;
                case "宗谷地方":
                    areaCode = 011000;
                    break;
                case "上川・留萌地方":
                    areaCode = 012000;
                    break;
                case "網走・北見・紋別地方":
                    areaCode = 013000;
                    break;
                case "十勝地方":
                    areaCode = 014030;
                    break;
                case "釧路・根室地方":
                    areaCode = 014100;
                    break;
                case "胆振・日高地方":
                    areaCode = 015000;
                    break;
                case "石狩・空知・後志地方":
                    areaCode = 016000;
                    break;
                case "渡島・檜山地方":
                    areaCode = 017000;
                    break;
                case "青森県":
                    areaCode = 020000;
                    break;
                case "岩手県":
                    areaCode = 030000;
                    break;
                case "宮城県":
                    areaCode = 040000;
                    break;
                case "秋田県":
                    areaCode = 050000;
                    break;
                case "山形県":
                    areaCode = 060000;
                    break;
                case "福島県":
                    areaCode = 070000;
                    break;
                case "山梨県":
                    areaCode = 190000;
                    break;
                case "長野県":
                    areaCode = 200000;
                    break;
                case "岐阜県":
                    areaCode = 210000;
                    break;
                case "静岡県":
                    areaCode = 220000;
                    break;
                case "愛知県":
                    areaCode = 230000;
                    break;
                case "三重県":
                    areaCode = 240000;
                    break;
                case "新潟県":
                    areaCode = 150000;
                    break;
                case "富山県":
                    areaCode = 160000;
                    break;
                case "石川県":
                    areaCode = 170000;
                    break;
                case "福井県":
                    areaCode = 180000;
                    break;
                case "滋賀県":
                    areaCode = 250000;
                    break;
                case "京都府":
                    areaCode = 260000;
                    break;
                case "大阪府":
                    areaCode = 270000;
                    break;
                case "兵庫県":
                    areaCode = 280000;
                    break;
                case "奈良県":
                    areaCode = 290000;
                    break;
                case "和歌山県":
                    areaCode = 300000;
                    break;
                case "鳥取県":
                    areaCode = 310000;
                    break;
                case "島根県":
                    areaCode = 320000;
                    break;
                case "岡山県":
                    areaCode = 330000;
                    break;
                case "広島県":
                    areaCode = 340000;
                    break;
                case "徳島県":
                    areaCode = 360000;
                    break;
                case "香川県":
                    areaCode = 370000;
                    break;
                case "愛媛県":
                    areaCode = 380000;
                    break;
                case "高知県":
                    areaCode = 390000;
                    break;
                case "山口県":
                    areaCode = 350000;
                    break;
                case "福岡県":
                    areaCode = 400000;
                    break;
                case "佐賀県":
                    areaCode = 410000;
                    break;
                case "長崎県":
                    areaCode = 420000;
                    break;
                case "熊本県":
                    areaCode = 430000;
                    break;
                case "大分県":
                    areaCode = 440000;
                    break;
                case "宮崎県":
                    areaCode = 450000;
                    break;
                case "奄美地方":
                    areaCode = 460040;
                    break;
                case "鹿児島県（奄美地方除く）":
                    areaCode = 460100;
                    break;
                case "沖縄本島地方":
                    areaCode = 471000;
                    break;
                case "大東島地方":
                    areaCode = 472000;
                    break;
                case "宮古島地方":
                    areaCode = 473000;
                    break;
                case "八重山地方":
                    areaCode = 474000;
                    break;
            }
        }
    }
}
