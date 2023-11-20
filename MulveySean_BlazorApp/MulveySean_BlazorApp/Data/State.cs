using System;
namespace MulveySean_BlazorApp.Data
{
    public class State
    {
        public List<Book> bookList { get; set; } = new List<Book>();
        public List<User> userList { get; set; } = new List<User>();
        public List<Book> borrowedList { get; set; } = new List<Book>();
    }
}

