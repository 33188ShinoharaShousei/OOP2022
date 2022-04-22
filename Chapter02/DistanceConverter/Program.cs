using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {

        //static FeetConverter fc = new FeetConverter();
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom")
            { //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            }
            else
            { //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 10);
            }
        }

        private static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = fc.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            for (int meter = 1; meter <= 10; meter++)
            {
                double feet = fc.FromToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
