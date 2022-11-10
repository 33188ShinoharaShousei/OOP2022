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
        List<MyColor> myColors = new List<MyColor>();
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加
            
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
            //MyColor newColor = new MyColor {
            //    Color = Color.FromRgb(byte.Parse(rValue.Text), byte.Parse(gValue.Text), byte.Parse(bValue.Text))
            //};
            //myColors.Add(newColor);
            //listBox.Items.Insert(0, $"R:{rValue.Text} G:{gValue.Text} B:{bValue.Text}");

            var stColor = getColorName(byte.Parse(rValue.Text), byte.Parse(gValue.Text), byte.Parse(bValue.Text));
            listBox.Items.Insert(0, stColor.Name ?? "R:" + stColor.Color.R + "G:" + stColor.Color.G + "B:" + stColor.Color.B);
            myColors.Insert(0, stColor);
        }
        private MyColor getColorName(byte r,byte g, byte b) { 
            return new MyColor { 
                Color = Color.FromRgb(r,g,b),
                Name = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == r &&
                                            c.Color.G == g &&
                                            c.Color.B == b)
                                .Select(c => c.Name).FirstOrDefault(),
           };
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            if (listBox.SelectedIndex == -1) return;
            //int sel = listBox.SelectedIndex;
            myColors.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (listBox.SelectedIndex == -1) return;

            rSlider.Value = myColors[listBox.SelectedIndex].Color.R;
            gSlider.Value = myColors[listBox.SelectedIndex].Color.G;
            bSlider.Value = myColors[listBox.SelectedIndex].Color.B;

            setColor();
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