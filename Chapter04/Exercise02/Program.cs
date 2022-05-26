using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            //4-2-1
            var ymCollection = new YearMonth[] {
                new YearMonth(2012,8),
                new YearMonth(2015,1),
                new YearMonth(794,5),
                new YearMonth(1998,2),
                new YearMonth(1995,5),
        };

            //4-2-2
            Exercise2_2(ymCollection);
            Console.WriteLine("----------");

            //4-2-4
            Exercise2_4(ymCollection);
            Console.WriteLine("----------");

            //4-2-5
            Exercise2_5(ymCollection);
            Console.WriteLine("----------");

            Exercise2_6(ymCollection);

            

            //var ym = new YearMonth(2022, 5);

            //var check = ym.Is21Century;
            //var test = ym.AddOneMonth();

            //Console.WriteLine(ym);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            //①月で昇順　②偶数年のみ昇順に出力 ③閏年のみを出力　④すべての年から12月に一番近い月を出力
            //foreach (var ym in ymCollection.OrderBy(ym => ym.Month)) {
            //foreach (var ym in ymCollection.Where(ym => ym.Year % 2 == 0).OrderBy(ym => ym.Month)) {
            //foreach (var ym in ymCollection.Where(ym => ym.Year % 4 == 0).OrderBy(ym => ym.Month)) {
                foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) { 
                    Console.WriteLine(ym);
            }
                var date = ymCollection.Max(ym => ym.Month);
                    Console.WriteLine(date);
        }

        //4-2-3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection)
                Console.WriteLine(ym);
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);

            if (yearmonth != null) {
                Console.WriteLine(yearmonth);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth());
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
