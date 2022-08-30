using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class SubBook : Book
    {
        public SubBook(int bookId, string bookName, string bookCategory, string bookAuthorName, string language)
           : base(bookId, bookName, bookCategory, bookAuthorName)
        {
            BookName += (" - " + language);
        }
    }
}

