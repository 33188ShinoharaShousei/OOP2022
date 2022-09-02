using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Framework {
    public abstract class ConverterBase {

        public abstract bool IsMyUnit(string name);
        //
        protected abstract double Ratio { get; }

        //
        public abstract string UnitName { get; }

        //
        public double FromMeter(double meter) {
            return meter / Ratio;
        }

        //
        public double Tometer(double feet) {
            return feet * Ratio;
        }
    }
}
