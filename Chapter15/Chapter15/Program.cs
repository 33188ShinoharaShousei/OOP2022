using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            var years = new List<int>();
            int year;

            Console.WriteLine("出力したい西暦を入力してください(終了：-1)");

            //Console.ReadLine();
            year = int.Parse(Console.ReadLine());
            while (year != -1) {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }


            Console.Write("昇順：1　降順：2：");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) {

                var books = Library.Books.Where(b => years.Contains(b.PublishedYear)).OrderBy(b => b.PublishedYear);

                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }
            if (n == 2) {
                var books = Library.Books.Where(b => years.Contains(b.PublishedYear)).OrderByDescending(b => b.PublishedYear);

                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine();
            //var groups = Library.Books
            //    .Where(b => years.Contains(b.PublishedYear))
            //    .GroupBy(b => b.PublishedYear)
            //    .OrderBy(g => g.Key);
            var selected = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                .OrderByDescending(b => b.PublishedYear)
                .ThenBy(b => b.CategoryId)
                .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                         (book, category) => new {
                             Title = book.Title,
                             Category = category.Name,
                             PublishedYear = book.PublishedYear,
                             Price = book.Price
                         }
            );

            foreach (var book in selected
                .OrderByDescending(x=>x.PublishedYear)
                .ThenBy(x=>x.Category)) 
                
            {                     
                Console.WriteLine($"{book.PublishedYear},{book.Title},{book.Category},{book.Price}円");
            }
            Console.WriteLine($"金額の合計{selected.Sum(b => b.Price)}");
        }
    }
}

