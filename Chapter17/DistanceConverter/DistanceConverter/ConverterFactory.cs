using DistanceConverter.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class ConverterFactory {
        //
        private static ConverterBase[] _converters = new ConverterBase[] {
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
            new MileConverter(),
            new kilometerConverter(),
        };

        public static ConverterBase GetConverter(string name) {
            return _converters.FirstOrDefault(x => x.IsMyUnit(name));
        }

        public static ConverterBase GetInstance(string unit) {
            return _converters.FirstOrDefault(x => x.IsMyUnit(unit));
        }
    }
}
