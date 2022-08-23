using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    
    public partial class Form1 : Form {
        Settings settings = new Settings();
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void PiOpen_Click(object sender, EventArgs e) {
            if (ofdOpenDialog.ShowDialog() == DialogResult.OK) {
                piopen.Image = Image.FromFile(ofdOpenDialog.FileName);
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbRecorder.Text))/*String.empty*/ {
                MessageBox.Show("記録者が入力されていません");
                return;
            }
            if (String.IsNullOrWhiteSpace(cbCN.Text))/*String.empty*/ {
                MessageBox.Show("車名が入力されていません");
                return;
            }

            CarReport newCar = new CarReport {
                Auther = cbRecorder.Text,
                Date = dtpDate.Value,
                CarName = cbCN.Text,
                Report = tbReport.Text,
                Picture = pbCar.Image,
                Maker = GetMakerTypes(),

            };
            listCarReport.Add(newCar);

            EnabledCheck();

            setCbRecorder(cbRecorder.Text);
            setCbCN(cbCN.Text);
        }
        //コンボボックスに記録者を登録する（重複なし）
        private void setCbRecorder(string Auther) {

            if (!cbRecorder.Items.Contains(Auther)) {
                cbRecorder.Items.Add(Auther);
            }
        }

        //コンボボックスに記録者を登録する（重複なし）
        private void setCbCN(string CarName) {

            if (!cbCN.Items.Contains(CarName)) {
                cbCN.Items.Add(CarName);
            }
        }

        private void piDelete_Click(object sender, EventArgs e) {
            pbCar.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvCarReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;

            int index = dgvCarReport.CurrentRow.Index;
            cbRecorder.Text = listCarReport[index].Auther;
            dtpDate.Value = listCarReport[index].Date;
            cbCN.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbCar.Image = listCarReport[index].Picture;


            foreach (var group in listCarReport[index].Maker) {
                switch (group) {
                    case CarReport.MakerGroup.トヨタ:
                        rbToyota.Checked = true;
                        break;
                    case CarReport.MakerGroup.日産:
                        rbNissan.Checked = true;
                        break;
                    case CarReport.MakerGroup.ホンダ:
                        rbHonda.Checked = true;
                        break;
                    case CarReport.MakerGroup.スバル:
                        rbSubaru.Checked = true;
                        break;
                    case CarReport.MakerGroup.外国車:
                        rbForeign.Checked = true;
                        break;
                    case CarReport.MakerGroup.その他:
                        rbother.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btcorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbRecorder.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Date = DateTime.Now;
            listCarReport[dgvCarReport.CurrentRow.Index].CarName = cbCN.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbCar.Image;
            listCarReport[dgvCarReport.CurrentRow.Index].Maker = GetMakerTypes();
            dgvCarReport.Refresh();//データグリッドビュー更新
        }




        private List<CarReport.MakerGroup> GetMakerTypes() {
            var Maker = new List<CarReport.MakerGroup>();
            if (rbToyota.Checked) {
                Maker.Add(CarReport.MakerGroup.トヨタ);
            }
            if (rbNissan.Checked) {
                Maker.Add(CarReport.MakerGroup.日産);
            }
            if (rbHonda.Checked) {
                Maker.Add(CarReport.MakerGroup.ホンダ);
            }
            if (rbSubaru.Checked) {
                Maker.Add(CarReport.MakerGroup.スバル);
            }
            if (rbForeign.Checked) {
                Maker.Add(CarReport.MakerGroup.外国車);
            }
            if (rbother.Checked) {
                Maker.Add(CarReport.MakerGroup.その他);
            }
            return Maker;
        }

        private void btDelete_Click(object sender, EventArgs e) {

            if (dgvCarReport.CurrentRow == null) return;
            int index = dgvCarReport.CurrentRow.Index;
            listCarReport.RemoveAt(index);

        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Open_Click(object sender, EventArgs e) {

            if (ofdOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbRecorder.Items.Clear();
                foreach (var item in listCarReport.Select(p => p.Auther)) {
                    setCbRecorder(item);//存在する会社を登録
                }
                cbCN.Items.Clear();
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbCN(item);//存在する会社を登録
                }
            }
            EnabledCheck();
        }

        private void EnabledCheck() {
            btcorrect.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            using (var color = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(color, settings);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
            EnabledCheck();
        }

        private void ColorSetting_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog1.Color;
                settings.MainFormColor = colorDialog1.Color.ToArgb();
            }
        }

        private void btend_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}

