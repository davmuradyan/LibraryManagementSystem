using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal class Author : LibraryAbstracts {


        private string _name;
        private string _biography;
        internal string name { get {return _name; }
            set {
                if (!(value == ""))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid input for author's name");
                }
            }
        }

        internal string biography { get { return _biography; }
            set {
                if (!(value == ""))
                {
                    _biography = value;
                }
                else
                {
                    Console.WriteLine("Invalid input for author's biography");
                }
            }
        }
        public Author(string name, string biography, Library myLibrary) {
            this.name = name;
            this.biography = biography;
            myLibrary.authorList.Add(this);
            id = myLibrary.authorList.Count;
            myLibrary.authorId.Add(id, this);
        }
    }
}
