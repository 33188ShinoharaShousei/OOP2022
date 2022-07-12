using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listPerson = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
        }
        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbRecorder.Text))/*String.empty*/ {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            CarReport newPerson = new CarReport {
                Auther = cbRecorder.Text,
                //Date = dtpDate.Text,
                //Maker = 
                CarName = cbCN.Text,
                Report = tbReport.Text,
                Picture = pictureBox1.Image,
                //ListGroup = GetCheckBoxGroup(),

            };
            listPerson.Add(newPerson);

        }
    }
}
