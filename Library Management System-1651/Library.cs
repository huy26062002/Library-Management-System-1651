using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{

    class Library
    {
        private List<Book> bookList;
        private List<User> userList;

        public Library()
        {
            bookList = new List<Book>();
            userList = new List<User>();
        }

        //Password and Menu 
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.Write(" Enter your password: ");
            string password = Console.ReadLine();

            if (password == "librarian")
            {
                bool auth = true;
                while (auth)
                {
                    Console.WriteLine(" ---------Library Management System---------");
                    Console.WriteLine(" Welcome, {0}", password);
                    Console.WriteLine(" 1) Add new Books");
                    Console.WriteLine(" 2) Delete Book");
                    Console.WriteLine(" 3) Search Book");
                    Console.WriteLine(" 4) Borrow Book");
                    Console.WriteLine(" 5) Close");
                    Console.Write(" Choose your option from menu: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine(" 1) For normal book");
                        Console.WriteLine(" 2) For vietsub book");
                        Console.Write(" Enter your choice: ");
                        option = int.Parse(Console.ReadLine());
                        if (option == 2)
                            library.AddVietsub();
                        else
                            library.AddBook();
                    }
                    else if (option == 2)
                    {
                        library.DeleteBook();
                    }
                    else if (option == 3)
                    {
                        library.SearchBook();
                    }
                    else if (option == 4)
                    {
                        library.BorrowBook();
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine(" Thank you");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid option\n Please try again");
                    }
                }
            }
            else if (password == "user")
            {
                bool auth = true;
                while (auth)
                {
                    Console.WriteLine("\n---------Library Management System---------");
                    Console.WriteLine(" Welcome, {0}", password);
                    Console.WriteLine(" 1) Search Book");
                    Console.WriteLine(" 2) Borrow Book");
                    Console.WriteLine(" 3) Close");
                    Console.Write(" Choose your option from menu: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        library.SearchBook();
                    }
                    else if (option == 2)
                    {
                        library.BorrowBook();
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine(" Thank you");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid option\n Please try again");
                    }
                }
            }
            else
            {
                Console.WriteLine(" Invalid password");
            }
            Console.ReadLine();
        }
        //ID
        public int InputBookId()
        {
            Console.Write(" ID: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        //Name
        public string InputBookName()
        {

            Console.Write(" Name: ");
            string bookName = Console.ReadLine();
            return bookName;
        }
        //Author
        public string InputBookAuthorName()
        {
            Console.Write(" Author: ");
            string bookAuthorName = Console.ReadLine();
            return bookAuthorName;
        }
        //Category
        public string InputBookCategory()
        {

            Console.Write(" Category: ");
            string bookCategory = Console.ReadLine();
            return bookCategory;
        }


        //Add book 
        public void AddBook()
        {
            Book book = new Book(
                InputBookId(),
                InputBookName(),
                InputBookAuthorName(),
                InputBookCategory()
            );
            bookList.Add(book);
        }

        //Vietsub
        public void AddVietsub()
        {
            SubBook book = new SubBook(
                InputBookId(),
                InputBookName(),
                InputBookAuthorName(),
                InputBookCategory(),
                " Vietsub"
            );
            bookList.Add(book);
        }

        //Delete book 
        public void DeleteBook()
        {
            Console.Write(" Enter Book Id to be deleted: ");
            int del = int.Parse(Console.ReadLine());

            foreach (Book book in bookList)
            {
                if (book.BookId == del)
                {
                    bookList.RemoveAt(del);
                    Console.WriteLine(" Book Id ({0}) has been deleted", del);
                    return;
                }
            }
            Console.WriteLine(" Invalid Book Id");
        }

        //Search book
        public void SearchBook()
        {
            Console.Write(" Search by Id: ");
            int find = int.Parse(Console.ReadLine());

            foreach (Book book in bookList)
            {
                if (book.BookId == find)
                {
                    Console.WriteLine(book);
                    return;
                }
            }

            Console.WriteLine(" Book Id ({0}) is not found", find);
        }

        //Borrow book
        public void BorrowBook()
        {
            int userId = userList.Count + 1;
            Console.Write(" User Id: {0} \n", userId);
            Console.Write(" Name: ");
            string userName = Console.ReadLine();
            Console.Write(" Email: ");
            string userEmail = Console.ReadLine();
            Console.Write(" Book Id: ");
            int borrowBookId = int.Parse(Console.ReadLine());

            bool findResult = false;
            foreach (Book book in bookList)
            {
                if (book.BookId == borrowBookId)
                {
                    findResult = true;
                }
            }

            if (findResult)
            {
                User user = new User(userId, userName, userEmail, borrowBookId);
                userList.Add(user);
                Console.WriteLine(" Borrow success");
            }
            else
            {
                Console.WriteLine(" Can't find. Please try again");
            }
        }
    }
}