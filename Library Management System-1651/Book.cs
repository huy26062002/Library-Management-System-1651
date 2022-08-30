using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Book
    {
        private int bookId;
        private string bookName;
        private string bookCategory;
        private string bookAuthorName;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookCategory
        {
            get { return bookCategory; }
            set { bookCategory = value; }
        }
        public string BookAuthorName
        {
            get { return bookAuthorName; }
            set { bookAuthorName = value; }
        }

        public Book(int bookId, string bookName, string bookCategory, string bookAuthorName)
        {
            BookId = bookId;
            BookName = bookName;
            BookCategory = bookCategory;
            BookAuthorName = bookAuthorName;
        }

        public override string ToString()
        {
            return $" Book Id: {BookId}\n"
                    + $" Book name: {BookName}\n"
                    + $" Author: {BookAuthorName}\n"
                    + $" Category: {BookCategory}\n";
        }
    }
}

