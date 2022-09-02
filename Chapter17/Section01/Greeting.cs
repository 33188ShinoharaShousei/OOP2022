using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GreetingMorning : IGreeting{
        public  string GetMessege() {
            return "おはよう";
        }
    }

    class GreetingAfternoon : IGreeting {
        public  string GetMessege() {
            return "こんにちは";
        }
    }

    class GreetingEvening : IGreeting {
        public  string GetMessege() {
            return "こんばんは";
        }
    }
}
