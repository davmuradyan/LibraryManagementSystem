using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal class Program {
        static void Main(string[] args) {
            Library hayLib = new Library("HayLib", "Yerevan");

            Author me = new Author("David Muradyan", "20 years old", hayLib);
            Author you = new Author("hdask ajkds", "ndsna", hayLib);

            Category fantastique = new Category("Fantastique", "Gooood one");

            List<Author> autors = new List<Author>();
            autors.Add(me);
            autors.Add(you);
            List<Category> categories = new List<Category>();
            categories.Add(fantastique);

            BookOperations.AddBook("Pigs", autors, categories, 2024, 5670, hayLib);
            BookOperations.AddBook("Lala", autors, categories, 2024, 5670, hayLib);
            BookOperations.AddBook("Nara", autors, categories, 2024, 5670, hayLib);

            BookOperations.DisplayBooks(hayLib);

            Console.ReadKey();

            BookOperations.DisplayBooks(hayLib);

            Console.ReadKey();

            ///+Add rentBook in Display function
            ///+Also add removeBook in Display
            ///++Add queue for returning books
            ///Add BookReturn function
        }
    }
}