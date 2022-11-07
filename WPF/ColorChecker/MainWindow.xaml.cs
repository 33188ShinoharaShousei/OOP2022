using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加
            List<MyColor> myColors = new List<MyColor>();
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            ColorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }



        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            //var name = mycolor.Name;
            rValue.Text = Convert.ToString(color.R, 10);
            gValue.Text = Convert.ToString(color.G, 10);
            bValue.Text = Convert.ToString(color.B, 10);
            setColor();
        }

        private void Stock_Click(object sender, RoutedEventArgs e) {
            /*MyColor myColor = new MyColor {
                Color = Color.FromRgb()
            };*/
            listBox.Items.Insert(0,$"R:{rValue.Text} G:{gValue.Text} B:{bValue.Text}");
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            if (listBox.SelectedIndex == -1) return;
            int sel = listBox.SelectedIndex;
            listBox.Items.RemoveAt(sel);
        }
    }


    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}