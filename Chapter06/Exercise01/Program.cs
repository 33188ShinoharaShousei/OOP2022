using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            //最大値
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            //最後から2つの要素取り出し
            foreach(var n in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(n);
            }

            /*for (int i = numbers.Length - 2; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }*/

        }

        private static void Exercise1_3(int[] numbers) {
            //数値を文字列へ変換
            var Strings = numbers.Select(n => n.ToString()).ToArray();
            foreach (var n in Strings) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            //小さい順に並べて先頭の3つを出力
            foreach (var n in numbers.OrderBy(n => n).Take(3)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            //重複を排除し10より大きい数がいくつあるか
            var n = numbers.Distinct().Count(s => s > 10);
                Console.WriteLine(n);
        }
    }
}
