using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var books = Library.Books
                .OrderByDescending(b => b.Price).First();
            Console.WriteLine($"{books.PublishedYear},{books.CategoryId},{books.Price},{books.Title}");


        }

        private static void Exercise1_3() {
            var books = Library.Books
                .OrderBy(b => b.PublishedYear)
                .GroupBy(b => b.PublishedYear)
                .Select(book => new {
                    Year = book.Key,
                    Count = book.Count()
                });
            foreach (var x in books) {
                Console.WriteLine($"{x.Year}年　{x.Count}冊");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price)
                .Join(Library.Categories,
                        book => book.CategoryId,
                        categpory => categpory.Id,
                        (book, category) => new {
                            PublishedYear = book.PublishedYear,
                            Price = book.Price,
                            Title = book.Title,
                            Name = category.Name
                        });
            foreach (var b in books) {
                Console.WriteLine($"{b.PublishedYear}年 {b.Price}円 {b.Title}({b.Name})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                        book => book.CategoryId,
                        category => category.Id,
                        (book, category) => category.Name)
                .Distinct();
            foreach (var name in books) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var z = Library.Categories

                .GroupJoin(Library.Books,
                           c => c.Id,
                           b => b.CategoryId,
                           (c, books) => new {
                               Category = c.Name,
                               Books = books
                           });
                /*OrderBy();*/

            //.Join(Library.Books,
            //      book => book.Id,
            //      category => category.CategoryId,
            //      (book, category) => new {
            //          Title = book.Name,
            //          Name = category.Title
            //      });
            foreach (var g in z) {
                Console.WriteLine("#"+g.Category);
                foreach (var book in g.Books) {
                    Console.WriteLine($"    {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
