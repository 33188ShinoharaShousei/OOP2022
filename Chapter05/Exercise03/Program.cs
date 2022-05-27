using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("---------------");

            Exercise3_2(text);
            Console.WriteLine("---------------");

            Exercise3_3(text);
            Console.WriteLine("---------------");

            Exercise3_4(text);
            Console.WriteLine("---------------");

            Exercise3_5(text);
            Console.WriteLine("---------------");
        }

        private static void Exercise3_1(string text) {
            var count = text.Count(t => t == ' ');
            Console.WriteLine("空白数：{0}", count);
        }

        private static void Exercise3_2(string text) {
            var before = text;
            var after = before.Replace("big", "small");
            Console.WriteLine(after);
        }

        private static void Exercise3_3(string text) {
            var words = text.Split(' ').Count();
            Console.WriteLine("単語数：{0}", words);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where( w => w.Length <= 4);
            foreach (var w in words) {
                Console.WriteLine(w);
            }
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var w in words) {
                sb.Append(w);
            }
            var u = sb.ToString();
            Console.WriteLine(u);
        }
    }
}
