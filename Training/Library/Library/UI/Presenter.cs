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
        bool flag;
        string text;
        string topik;
        StringBuilder builderForLetter;

        public Presenter()
        {
            servise = new Service();
            Letters = string.Empty;
        }

        #region Properties
        public User CurrentUser
        {
            get { return currentUser; }
        }

        public Book CurrentBook
        {
            get { return CurrentBook; }
        }

        public string Letters { get; set; }

        public List<Letter> GetLetters()
        {
            return servise.Users.GetAllLettersByUser(currentUser);
        }

        public string Login { get; private set; }

        #endregion

        #region Events

        private void LoginMenu_Registration(object sender, EventArgs e)
        {
            bool error = IsEmailOrUserExist(loginMenu.Login, loginMenu.Email);
            if (!error)
            {
                currentUser = servise.Users.Create(loginMenu.Login, loginMenu.Email, loginMenu.Admin);
            }
        }

        private void LoginMenu_SignIn(object sender, EventArgs e)
        {
            bool log = servise.Users.IsUserExist(loginMenu.Login);
            if (log)
            {
                currentUser = servise.Users.GetByLogin(loginMenu.Login);
            }
        }

        private void Library_RemoveBook(object sender, EventArgs e)
        {
            servise.Books.Delete(library.SelectedBook);
            servise.Save();
        }

        private void Library_HistoryForBooks(object sender, EventArgs e)
        {
            library.BooksActions = servise.Actions.GetAllActionsByBooks(library.SelectedBook);
        }

        private void Library_HistoryForBook(object sender, EventArgs e)
        {
            library.BooksActions = servise.Actions.GetAllActionsByBook(library.SelectedBook);

        }

        private void Library_LastOwner(object sender, EventArgs e)
        {
            library.Owner = servise.Actions.GetLastOwnerLoginByBook(library.SelectedBook);
        }

        private void Library_TakeBook(object sender, EventArgs e)
        {
            if (library.OutputInfo == InfoType.Avalible)
            {
                List<Book> books = servise.Books.GetByTitleAndAuthor(library.SelectedBook.Title, library.SelectedBook.AuthorDiscription);
                library.CountOfBook = books.Count;
                books = books.Where(a => a.AvalibleStatus == true).ToList();
                Book currentBook = books.First();
                currentBook.AvalibleStatus = false;
                servise.Users.AddBook(currentUser, currentBook);
                Domain.Action action = new Domain.Action(DateTime.Now, currentUser, currentBook, true);
                servise.Actions.Create(action);

                builderForLetter = new StringBuilder();
                builderForLetter.AppendFormat("Dear {0}, you have taken the book [ID{1}] {2} just now. \nBest Regards, Library.\n{3}",
                                                CurrentUser.Login, currentBook.Id, currentBook.Title, DateTime.Now);
                topik = "Take";
                text = builderForLetter.ToString();
                Letter letter = new Letter(topik, text, DateTime.Now);
                CurrentUser.Email.AddLetter(letter);
                servise.Save();

                library.CountOfAvalibleBook = books.Count();//
                library.AllBook = false;
                library.AvalibleBook = false;
            }

            if (library.OutputInfo == InfoType.All)
            {
                if (library.SelectedBook.AvalibleStatus == true)
                {
                    library.SelectedBook.AvalibleStatus = false;
                    servise.Users.AddBook(currentUser, library.SelectedBook);
                    Domain.Action action = new Domain.Action(DateTime.Now, currentUser, library.SelectedBook, true);
                    servise.Actions.Create(action);
                    
                    builderForLetter = new StringBuilder();
                    builderForLetter.AppendFormat("Dear {0}, you have taken the book [ID{1}] {2} just now. \nBest Regards, Library.\n{3}",
                                                    CurrentUser.Login, library.SelectedBook.Id, library.SelectedBook.Title, DateTime.Now);
                    topik = "Take";
                    text = builderForLetter.ToString();
                    Letter letter = new Letter(topik, text, DateTime.Now);
                    CurrentUser.Email.AddLetter(letter);
                    servise.Save();
                    library.AllBook = false;
                    library.AvalibleBook = false;
                }
            }

        }

        private void Library_TableClick(object sender, EventArgs e)
        {
            List<Book> books = servise.Books.GetByTitleAndAuthor(library.SelectedBook.Title, library.SelectedBook.AuthorDiscription);
            library.CountOfBook = books.Count;
            List<Book> avalible = books.Where(s => s.AvalibleStatus == true).ToList();
            library.CountOfAvalibleBook = avalible.Count;
        }

        private void Library_OkReturnClick(object sender, EventArgs e)
        {
            servise.Books.ChangeStatus(library.ReturnId);
            servise.Users.RemoveBook(currentUser, library.ReturnId);
            Book book = servise.Books.GetById(library.ReturnId);
            Domain.Action action = new Domain.Action(DateTime.Now, currentUser, book, false);
            servise.Actions.Create(action);

            builderForLetter = new StringBuilder();
            builderForLetter.AppendFormat("Dear {0}, you have returned the book [ID{1}] {2} just now. \nBest Regards, Library.\n{3}",
            CurrentUser.Login, book.Id, book.Title, DateTime.Now);
            topik = "Return";
            text = builderForLetter.ToString();
            Letter letter = new Letter(topik, text, DateTime.Now);
            CurrentUser.Email.AddLetter(letter);
            servise.Save();
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
            library.BooksBindingSource = AvalableBooksCount(books);
        }

        private void Library_AllBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;
        }
        #endregion

        #region Methods

        #region Public methods
        public void AddLoginMenu(ILogin loginMenu)
        {
            this.loginMenu = loginMenu;
            Login = loginMenu.Login;
            loginMenu.SignIn += LoginMenu_SignIn;
            loginMenu.Registration += LoginMenu_Registration;
        }

        public void AddLibrary(ILibrary library)
        {
            this.library = library;
            library.AllBooksClick += Library_AllBooksClick;
            library.AvalibleBooksClick += Library_AvalibleBooksClick;
            library.TakenBooksClick += Library_TakenBooksClick;
            library.AddNewBook += Library_AddNewBook;
            library.TakeBook += Library_TakeBook;
            library.OkReturnClick += Library_OkReturnClick;
            library.TableClick += Library_TableClick;
            library.LastOwner += Library_LastOwner;
            library.HistoryForBook += Library_HistoryForBook;
            library.HistoryForBooks += Library_HistoryForBooks;
            library.RemoveBook += Library_RemoveBook;
            books = servise.Books.GetAvalible().ToList();
            library.BooksBindingSource = AvalableBooksCount(books);
        }
        #endregion

        bool IsEmailOrUserExist(string login, string email)
        {
            bool log = servise.Users.IsUserExist(login);
            bool em = servise.Users.IsEmailExist(email);
            loginMenu.LoginEmailError(log, em);
            return (log && em);
        }

        List<Book> AvalableBooksCount(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                for (int k = 0; k < books.Count - i; k++)
                {
                    if ((i != k) && (books[i].Title == books[k].Title))
                    {
                        flag = false;
                        for (int j = 0; j < books[i].Authors.Count; j++)
                        {
                            if (books[i].Authors[j].FullName.ToCharArray() == books[k].Authors[j].FullName.ToCharArray())
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }

                        if (flag == false)
                        {
                            books.Remove(books[k]);
                        }
                    }
                }
            }
            return books;
        }
        #endregion
    }
}
