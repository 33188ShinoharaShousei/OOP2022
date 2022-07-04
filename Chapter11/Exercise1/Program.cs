using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load("Sample.xml");
            var Sample = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    Teammembers = (String)x.Element("teammembers"),
                                });
            foreach (var sample in Sample) {
                Console.WriteLine("{0} {1}", sample.Name, sample.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load("Sample.xml");
            var Sample = xdoc.Root.Elements()
                                .OrderByDescending(x => (String)(x.Element("name").Attribute("firstplayed")));
            foreach (var sample in Sample) {
                var xfirstplayed = sample.Element("firstplayed");
                var xname = sample.Element("name");
                Console.WriteLine("{0}({1})", xname.Value,xfirstplayed.Value);
            }
        }

        private static void Exercise1_3(string file) {

        }

        private static void Exercise1_4(string file, string newfile) {
        }
    }
}
