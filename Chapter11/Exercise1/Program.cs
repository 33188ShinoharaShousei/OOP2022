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

            //これは確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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
                                .Select(x => new { 
                                    Firstplayed = x.Element("firstplayed").Value,
                                    Name = x.Element("name").Attribute("kanji").Value
                                })
                                .OrderBy(x => int.Parse(x.Firstplayed));
                foreach (var sample in Sample) {
                    Console.WriteLine("{0}({1})", sample.Name,sample.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("Sample.xml");
            var Sample = xdoc.Root.Elements()
                                .Select(x => new {
                                    Teammembers = x.Element("teammembers").Value,
                                    Name = x.Element("name").Value//.Attribute("kanji").Value
                                })
                                .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            Console.WriteLine("{0}({1}人)",Sample.Name,Sample.Teammembers);
                //Console.WriteLine(Sample.FirstOrDefault().Name);
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement(newfile,
                    new XElement("name", "サッカー", new XAttribute("kanji", "ア式蹴球")),
                    new XElement("teammembers", 11),
                    new XElement("firstplayed", 1863)
                    );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }
    }
}
