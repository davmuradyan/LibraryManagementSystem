using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal class Category {
        internal readonly string categoryName;

        private string _categoryDescription;
        internal string categoryDescription {
            get { return _categoryDescription; }
            set {
                if (!(value == "")) {
                    _categoryDescription = value;
                } else { Console.WriteLine("Invalid input for category description"); }
            }
        }

        public Category(string categoryName, string categoryDescription) { 
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
        }
    }
}