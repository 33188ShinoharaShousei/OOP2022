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

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }


        private void pbPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text))/*String.empty*/ {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                TelNumber = tbNumberBox.Text,
                Registration = DateTime.Now,
                Picture = pbPicture.Image,
                ListGroup = GetCheckBoxGroup(),
                KindNumber = GetKindNumberTypes(),

            };
            listPerson.Add(newPerson);

            EnabledCheck();

            setCbCompany(cbCompany.Text);

        }

        //コンボボックスに会社名を登録する（重複なし）
        private void setCbCompany(string company) {

            if (!cbCompany.Items.Contains(company)) {
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            tbNumberBox.Text = listPerson[index].TelNumber;
            DtpRegist.Value = listPerson[index].Registration;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();

            foreach (var group in listPerson[index].ListGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }

            foreach (var group in listPerson[index].KindNumber) {
                switch (group) {
                    case Person.KindNumberType.自宅:
                        rbHome.Checked = true;
                        break;
                    case Person.KindNumberType.携帯:
                        rbMobile.Checked = true;
                        break;
                    case Person.KindNumberType.その他:
                        break;
                    default:
                        break;
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].TelNumber = tbNumberBox.Text;
            listPerson[dgvPersons.CurrentRow.Index].KindNumber = GetKindNumberTypes();
            listPerson[dgvPersons.CurrentRow.Index].Registration = DateTime.Now;
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            listPerson[dgvPersons.CurrentRow.Index].ListGroup = GetCheckBoxGroup();
            dgvPersons.Refresh();//データグリッドビュー更新
        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void btDelete_Click(object sender, EventArgs e) {
            EnabledCheck();

            if (dgvPersons.CurrentRow == null) return;
            int index = dgvPersons.CurrentRow.Index;
            listPerson.RemoveAt(index);
            
        }
        
        private void tbName_TextChanged(object sender, EventArgs e) {
            if (tbName.Text.Length == 0) {
                btAddPerson.Enabled = false;
                btUpdate.Enabled = false;
            }
            if (tbName.Text.Length != 0) {
                btAddPerson.Enabled = true;
            }
        }

        private void EnabledCheck() {

            btUpdate.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open,FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setCbCompany(item);//存在する会社を登録
                }
            }
            EnabledCheck();
        }


        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.KindNumberType> GetKindNumberTypes() {
            var kindNumber = new List<Person.KindNumberType>();
            if (rbHome.Checked) {
                kindNumber.Add(Person.KindNumberType.自宅);
            }
            if (rbMobile.Checked) {
                kindNumber.Add(Person.KindNumberType.携帯);
            }
            return kindNumber;
        }

        
    }
}


