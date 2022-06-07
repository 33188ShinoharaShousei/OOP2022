using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (int.Parse(tbnum2.Text) != 0) {
                tbans.Text = (int.Parse(tbnum1.Text) / int.Parse(tbnum2.Text)).ToString();
                tbMod.Text = (int.Parse(tbnum1.Text) % int.Parse(tbnum2.Text)).ToString();
            } else {
                MessageBox.Show("正しい値を入力してください。",
                "error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

    }
}

