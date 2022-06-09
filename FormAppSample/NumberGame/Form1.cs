using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        Random rand = new Random();
        int num;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            getRandom();
        }

        private void bt1_Click(object sender, EventArgs e) {
            if (num == int.Parse(tb1.Text)) {
                tb2.Text = "成功";
                tb3.Text = "";
            } 
            else if (int.Parse(tb1.Text) > num ) {
                tb2.Text = "失敗";
                tb3.Text = tb1.Text + "より小さい";
            }
            else if (int.Parse(tb1.Text) < num ) {
                tb2.Text = "失敗";
                tb3.Text = tb1.Text + "より大きい";
            }

        }

        private void tb4_TextChanged(object sender, EventArgs e) {
            getRandom();
        }

        private void getRandom() {
            num = rand.Next(1, int.Parse(tb4.Text));
            //this.Text = num.ToString();
        }
    }
}
