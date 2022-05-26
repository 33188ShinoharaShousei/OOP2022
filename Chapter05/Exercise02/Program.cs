using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            int number;
            var inputString = Console.ReadLine();
            if (int.TryParse(inputString, out number)) {
                Console.WriteLine(number.ToString("#,0"));
            } else {
                Console.WriteLine("変換できませんでした。");
            }
        }
    }
}
