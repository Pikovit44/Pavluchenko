using Domain;
using Library.Data.Repository;
using Library.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI
{
    public class Presenter
    {
        Service servise;
        List<Book> books;
        ILibrary library;
        ILogin loginMenu;
        User currentUser;

        public Presenter(ILogin loginMenu)
        {
            this.loginMenu = loginMenu;
            Login = loginMenu.Login;
            loginMenu.SignIn += LoginMenu_SignIn;
            loginMenu.Registration += LoginMenu_Registration;
            servise = new Service();
        }

        public User CurrentUser { get { return currentUser; } }

        private void LoginMenu_Registration(object sender, EventArgs e)
        {
            bool error = IsEmailOrUserExist(loginMenu.Login, loginMenu.Email);
            if (!error)
            {
                currentUser = servise.Users.Create(loginMenu.Login, loginMenu.Email, loginMenu.Admin);
            }
        }

        bool IsEmailOrUserExist(string login, string email)
        {
            bool log = servise.Users.IsUserExist(login);
            bool em = servise.Users.IsEmailExist(email);
            loginMenu.LoginEmailError(log, em);
            return (log && em);
        }

        private void LoginMenu_SignIn(object sender, EventArgs e)
        {
            bool log = servise.Users.IsUserExist(loginMenu.Login);
            if (log )
            {
                currentUser = servise.Users.GetByLogin(loginMenu.Login);
            }
        }

        public string Login { get; private set; }

        public void AddLibrary(ILibrary library)
        {
            this.library = library;
            library.AllBooksClick += Library_AllBooksClick;
            library.AvalibleBooksClick += Library_AvalibleBooksClick;
            library.TakenBooksClick += Library_TakenBooksClick;
            library.AddNewBook += Library_AddNewBook;
            library.TakeBook += Library_TakeBook;
            library.OkReturnClick += Library_OkReturnClick;
            books = servise.Books.GetAvalible().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_OkReturnClick(object sender, EventArgs e)
        {
            servise.Books.ChangeStatus(library.ReturnId);
            servise.Users.RemoveBook(currentUser, library.ReturnId);
            Book book = servise.Books.GetById(library.ReturnId);
            book.History.Add(DateTime.Now, currentUser);
            library.InfoForReturn(book);
        }

        private void Library_TakeBook(object sender, EventArgs e)
        {
            if (library.SelectedBook.AvalibleStatus == true)
            {
                library.SelectedBook.AvalibleStatus = false;
                servise.Users.AddBook(currentUser, library.SelectedBook);
                library.SelectedBook.History.Add(DateTime.Now, currentUser);
                library.Reflesh();
                library.InfoForHistoryTake();
            }
            
        }

        private void Library_AddNewBook(object sender, EventArgs e)
        {
            servise.Books.Create(library.NewBook);
            servise.Save();
        }

        private void Library_TakenBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetTaken().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_AvalibleBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAvalible().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_AllBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;
        }
    }
}
