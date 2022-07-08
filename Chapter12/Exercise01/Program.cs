using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {

    class Program {
        static void Main() {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10)
            };

            var emps = new  {
                Emp = emp
            };
            //シリアル化
            using (var writer = XmlWriter.Create("novel.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            //逆シリアル化
            //using (var reader = XmlReader.Create("novel.xml")) {
            //    var serializer = new XmlSerializer(typeof(Emp));
            //    var emp = serializer.Deserialize(reader) as Emp;
            //    Console.WriteLine(emp);
            //}
        }

            private static void Exercise1_2(string v) {
            }

            private static void Exercise1_3(string v) {
            }

            private static void Exercise1_4(string v) {
            }
        }
    }

