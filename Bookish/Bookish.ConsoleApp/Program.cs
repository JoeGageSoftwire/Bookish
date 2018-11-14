using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Bookish.DataAccess;

namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourBooks = DataAccessor.GetBooks();

            foreach (var book in ourBooks)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nBook ID: " + book.Id.ToString());
                Console.WriteLine("Author Name: " + book.AuthorName);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("ISBN: " + book.ISBN + "\n");
                Console.WriteLine(new string('*', 20));
            }

            Console.ReadLine();
        }
    }
}
