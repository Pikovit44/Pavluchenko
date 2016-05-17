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
        Book currentBook;
        bool flag;

        public Presenter(ILogin loginMenu)
        {
            this.loginMenu = loginMenu;
            Login = loginMenu.Login;
            loginMenu.SignIn += LoginMenu_SignIn;
            loginMenu.Registration += LoginMenu_Registration;
            servise = new Service();
        }

        public User CurrentUser { get { return currentUser; } }
        public Book CurrentBook { get { return CurrentBook; } }

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
            library.TableClick += Library_TableClick;
            books = servise.Books.GetAvalible().ToList();
            library.BooksBindingSource = AvalableBooksCount(books);
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
            book.History.Add(DateTime.Now, currentUser);
            library.InfoForReturn(book);
        }

        private void Library_TakeBook(object sender, EventArgs e)
        {
            if (library.OutputInfo == InfoType.Avalible)
            {
                List<Book> books = servise.Books.GetByTitleAndAuthor(library.SelectedBook.Title, library.SelectedBook.AuthorDiscription);
                library.CountOfBook = books.Count;//
                books = books.Where(a => a.AvalibleStatus == true).ToList();
                Book currentBook = books.First();
                currentBook.AvalibleStatus = false;
                servise.Users.AddBook(currentUser, currentBook);
                currentBook.History.Add(DateTime.Now, currentUser);
                library.InfoForHistoryTake(currentBook);
                library.CountOfAvalibleBook = books.Count();//
                library.AllBook = false;
                library.AvalibleBook = false;
                library.Reflesh();
            }
            if (library.OutputInfo == InfoType.All)
            {
                if (library.SelectedBook.AvalibleStatus == true )
                {
                    library.SelectedBook.AvalibleStatus = false;
                    servise.Users.AddBook(currentUser, library.SelectedBook);
                    library.SelectedBook.History.Add(DateTime.Now, currentUser);
                    library.Reflesh();
                    library.InfoForHistoryTake();
                    
                    library.AllBook = false;
                    library.AvalibleBook = false;
                }

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
            library.BooksBindingSource = AvalableBooksCount(books);
        }

        List<Book> AvalableBooksCount ( List<Book> books)
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

        private void Library_AllBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;
        }
    }
}
