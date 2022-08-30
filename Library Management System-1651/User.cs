using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class User
    {
        private int userId;
        private string userName;
        private string userEmail;
        private int borrowBookId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public int BorrowBookId
        {
            get { return borrowBookId; }
            set { borrowBookId = value; }
        }

        public User(int id, string name, string email, int bookId)
        {
            UserId = id;
            UserName = name;
            UserEmail = email;
            BorrowBookId = bookId;
        }
    }
}