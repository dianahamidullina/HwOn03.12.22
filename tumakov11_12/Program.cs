using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{


    internal class Program
    {
        //12.1
        static List<Book> SortBooksByName(List<Book> books)
        {
            return new List<Book>(collection: from book in books orderby book.Name select book);
        }
        static List<Book> SortBooksByAuthor(List<Book> books)
        {
            return new List<Book>(from book in books orderby book.Author select book);
        }
        static List<Book> SortBooksByPublisher(List<Book> books)
        {
            return new List<Book>(from book in books orderby book.Publisher select book);
        }
        static void Main(string[] args)
        {
            //11.1ClassWork
            Console.WriteLine("Now u trying opening the shet\n Please chhoose : sber / notsber");
            string type = Console.ReadLine();
            switch (type)
            {
                case "sber":
                    FactoryOfShet1 factoryOfShet1 = new FactoryOfShet1();
                    factoryOfShet1.CreateAccount();
                   // factoryOfShet1.RemoveAccount();
                    break;
                case "notsber":
                    FactoryOfShet2 factoryOfShet2 = new FactoryOfShet2();
                    factoryOfShet2.CreateAccount();
                  //  factoryOfShet2.RemoveAccount();
                    break;
            }
            //11.1HomeWork
            Console.WriteLine("TestCase 2");
            Creator.CreateBuild(height: 25, numberStoreys: 5, numberEntrance: 2, numberFlats: 10);
            Creator.CreateBuild(height: 50, numberStoreys: 10, numberEntrance: 3, numberFlats: 50);
            Creator.CreateBuild(height: 75, numberStoreys: 15, numberEntrance: 4, numberFlats: 100);
            Creator.CreateBuild(height: 100, numberStoreys: 20, numberEntrance: 5, numberFlats: 200);
            Creator.DeleteBuilding(137742);
            foreach (var item in Creator.GetCreatedBuildingsList())
            {
                item.Display();
                Console.WriteLine();
            }

            Console.ReadKey();
           //12.1
           
               
                Account account1 = new Account(TypeAccount.Текущий, 300);
                Account account2 = new Account(TypeAccount.Сберегательный, 400);
                Console.WriteLine($"HashCode = {account1.GetHashCode()}");
                Console.WriteLine($"acc1 != acc2 ({account1.Equals(account2)})");
                Console.WriteLine($"acc1 == acc2 ({account1 == account2})");
                Console.WriteLine(account2);
                Console.ReadLine();
                Console.Clear();
            //12.2-12.1HW
               
                Complex c1 = new Complex(10, 6);
                Complex c2 = new Complex(-55.4, 18);
                Complex c3 = new Complex(0, 0);
                Console.WriteLine("c3 = c1 + c2 - c1 * c2;");
                c3 = c1 + c2 - c1 * c2;
                Console.WriteLine($"c3 = {c3}");
                Console.WriteLine($"c1 == c2 ({c1 == c2})");
                Console.WriteLine($"c1 == 10 + 6i ({c1.Equals(new Complex(10, 6))})");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Домашнее задание 12.2");
                BoxBook boxBook = new BoxBook(
                    new Book(name: "sName", author: "CAuthor", publisher: "QPublisher"),
                    new Book(name: "BName", author: "ZAuthor", publisher: "WPublisher"),
                    new Book(name: "CName", author: "DAuthor", publisher: "EPublisher"),
                    new Book(name: "kName", author: "EAuthor", publisher: "APublisher"),
                    new Book(name: "FName", author: "OAuthor", publisher: "DPublisher"),
                    new Book(name: "SName", author: "GAuthor", publisher: "HPublisher"),
                    new Book(name: "EName", author: "JAuthor", publisher: "APublisher")
                );
                Console.WriteLine("Отсортированные книги по имени");
                foreach (var item in boxBook.GetSortedBooks(new BoxBook.DelegateSortingBook(SortBooksByName)))
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Отсортированные книги по автору");
                foreach (var item in boxBook.GetSortedBooks(new BoxBook.DelegateSortingBook(SortBooksByAuthor)))
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Отсортированные книги по издательству");
                foreach (var item in boxBook.GetSortedBooks(new BoxBook.DelegateSortingBook(SortBooksByPublisher)))
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();
            }

        }
    
}
    

    
 





