using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var inputString = Console.ReadLine();
            int number;　//整数値を入れる変数を用意
            //P126
            if (int.TryParse(inputString, out number)) {
                Console.WriteLine("{0:#,#}",number); //整数への変換成功
            } else {
                Console.WriteLine("変換できませんでした。");　//変換失敗
            }
        }
    }
}
