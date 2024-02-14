using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    static internal class BookOperations {
        static internal void AddBook(string title, List<Author> authors, List<Category> category, int year, float price, Library myLibrary) {
            Book book = new Book(title, authors, category, year, price);

            myLibrary.bookDictionary.Add(book, true);
            myLibrary.bookList.Add(book);
            book.id = myLibrary.bookList.Count;
        }

        static internal void RemoveBook(Book book, Library Library)
        {
            Library.bookDictionary.Remove(book);

            Library.bookList.Remove(book);
        }

        static internal void DisplayBooks(Library Library) {
            int booksInLibrary;
            if (Library.bookDictionary.Count != 0)
                {
                booksInLibrary = 1;

                foreach (var key in Library.bookDictionary.Keys)
                    {
                    if (Library.bookDictionary[key] == true)
                        {
                        int i = 0;

                        Console.Write("[" + booksInLibrary + "]" + key.title + " by ");

                        foreach (var author in key.authors)
                        {
                            Console.Write(author.name + "|");
                            i++;
                        }
                        booksInLibrary++;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("If you want to rent any book, enter R" +
                    "\nIf you want remove any book, enter D\n" +
                    "Other inputs are invalid.");

                string input = Console.ReadLine();

                if (input == "R" || input == "r")
                {
                    Console.WriteLine("Which book do you want to rent?\n" +
                        "Enter the number of the book.");

                    int whichBook = Convert.ToInt16(Console.ReadLine());

                    if (Library.bookList.Count <= booksInLibrary - 1)
                    {
                        Library.bookQueue.Enqueue(Library.bookList[whichBook - 1]);
                        RentBook(Library.bookList[whichBook - 1], Library, whichBook);
                        Console.WriteLine("Book is rented!");
                    }
                } else if (input == "D" || input == "d")
                {
                    Console.WriteLine("Which book do you want to remove?\n" +
                        "Enter the number of the book.");

                    int whichBook = Convert.ToInt16(Console.ReadLine());

                    if (Library.bookList.Count <= booksInLibrary - 1)
                    {
                        
                        RemoveBook(Library.bookList[whichBook - 1], Library);
                        Console.WriteLine("Book is removed!");
                    }
                }
            } else {
                Console.WriteLine("There are no books yet");
            }
        }

        static internal void RentBook(Book book, Library Library, int whichBook) {
            int queueLength = Library.bookQueue.Count;
            Queue<Book> nq = new Queue<Book>();

            for (int i = 0; i < queueLength; i++) {
                Book bk = Library.bookQueue.Dequeue();

                if (!(bk == Library.bookList[whichBook - 1])) {
                    nq.Enqueue(book);
                }
            }

            for (int i = 0; i < nq.Count; i++) {
                Library.bookQueue.Enqueue((Book)nq.Dequeue());
            }

            Library.bookDictionary[book] = false;
        }
    }
}
