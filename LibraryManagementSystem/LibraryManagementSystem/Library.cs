using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal class Library : LibraryAbstracts {

        public readonly string Name;
        public readonly string City;

        internal List<Author> authorList = new List<Author>();

        internal List<Category> categories = new List<Category>();
        //int = id
        internal Dictionary<int, Author> authorId = new Dictionary<int, Author>();

        //queue for books
        internal Queue<Book> bookQueue = new Queue<Book>();

        //bool = isAvaiable
        internal Dictionary<Book, bool> bookDictionary = new Dictionary<Book, bool>();
        
        internal List<Book> bookList = new List<Book>();

        public Library(string name, string city) {
            Name = name;
            City = city;
        }
    }
}
