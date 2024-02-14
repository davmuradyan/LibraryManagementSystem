using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal class Book : LibraryAbstracts {
        internal readonly string title;
        internal readonly List<Author> authors;
        internal readonly List<Category> category;

        private int _year;
        internal int year {get { return _year; } 

            set {
                if (value >=0)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } 
        }

        private float _price;
        internal float price {
            get { return _price; }
            set {
                if (value >= 0) {
                    _price = value;
                } else {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        internal Book(string title, List<Author> authors, List<Category> category, int year, float price) {
            this.title = title;
            this.authors = authors;
            this.category = category;
            this.year = year;
            this.price = price;
            
        }
    }
}
