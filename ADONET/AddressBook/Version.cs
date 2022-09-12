using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Version : Form {
        public Version() {
            InitializeComponent();
        }

        private void Version_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var var = asm.GetName().Version;
            string version = var.Major + "." + var.Major + "." + var.Build;
            lbVersion.Text = version;
        }
    }
}
