using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.UI.Interfaces;
using Domain;

namespace Library.UI
{
    public enum InfoType
    {
        Avalible,
        All, 
        Taken
    }

    public partial class LibraryUserControl : BaseUserControl, ILibrary 
    {
        public event EventHandler AllBooksClick;
        public event EventHandler AvalibleBooksClick;
        public event EventHandler TakenBooksClick;
        public event EventHandler AddNewBook;
        public event EventHandler TakeBook;
        public event EventHandler OkReturnClick;
        public event EventHandler TableClick;

        Book selectedBook;
        Book newBook;
        int returnId;
        InfoType outputInfo;

        Presenter presenter;

        public InfoType OutputInfo
        {
            get { return outputInfo; }
        }

        public int ReturnId
        {
            get { return returnId; }
        }

        public Book NewBook
        {
            get { return newBook; }
        }

        public int CountOfBook
        {
            set { countDiscrLb.Text = value.ToString(); }
        }

        public int CountOfAvalibleBook
        {
            set { avalableDiscrLb.Text = value.ToString(); }
        }

        public bool AvalibleBook
        {
            set { avalableDiscrLb.Visible = value; }
        }

        public bool AllBook
        {
            set { countDiscrLb.Visible = value; }
        }


        public object BooksBindingSource
        {
            set { booksBindingSource1.DataSource = value; }
        }
        
        public Book SelectedBook
        {
            get { return selectedBook; }
        }

        public LibraryUserControl()
        {
            InitializeComponent();
            DGVSelectionMode();
            presenter = LoginUserControl.Presenter;
            SetUp();
            presenter.AddLibrary(this);
        }
        

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBookPl.Visible = true;
            returnBookPl.Visible = false;
        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            
            addBookPl.Visible = false;
            Author newAuthor = new Author(addAuthorsTb.Text);
            List<Author> authors = new List<Author>();
            authors.Add(newAuthor);
            newBook = new Book(addTitleTb.Text, newAuthor); //repository for authors (add book) 
            if (AddNewBook != null) { AddNewBook(this, EventArgs.Empty); }
            Reflesh();
            addTitleTb.Text = string.Empty;
            addAuthorsTb.Text = string.Empty;
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            returnBookCb.Items.Clear();
            if (TakeBook != null) { TakeBook(this, EventArgs.Empty); }
            User user = presenter.CurrentUser;
            List<string> cBitems = new List<string>();

            for (int i = 0; i < user.Books.Count; i++)
            {
                returnBookCb.Items.Add("Id" + user.Books[i].Id.ToString() + " " + user.Books[i].Title);
            }

            
            returnBookCb.Text = string.Empty;
            authorDiscrLb.Text = string.Empty;
            titleDiscrLb.Text = string.Empty;


        }



        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            returnBookPl.Visible = true;
            addBookPl.Visible = false; // refact!
            
        }

        private void okReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (returnBookCb.Items.Count != 0)
            {
                string bookInfo = returnBookCb.Text;
                int s = bookInfo.IndexOf("d"); // 1
                int f = bookInfo.IndexOf(" ");// 3
                string currentId = bookInfo.Substring(s + 1, f - s); // ref!
                returnId = int.Parse(currentId);
                if (OkReturnClick != null) { OkReturnClick(this, EventArgs.Empty); }
                returnBookCb.Items.Remove(bookInfo);
                
            }

            if (returnBookCb.Items.Count == 0)
            {
                returnBookCb.Text = "Empty";
            }

            returnBookPl.Visible = false;
            Reflesh();
        }

        private void CancelReturnBookBtn_Click(object sender, EventArgs e)
        {
            returnBookPl.Visible = false;
        }
        
        #region Table
        private void allBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            outputInfo = InfoType.All;
            if (AllBooksClick != null) { AllBooksClick(this, EventArgs.Empty); }
        }

        private void avalableBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            ownerLb.Visible = false;
            outputInfo = InfoType.Avalible;
            if (AvalibleBooksClick != null) { AvalibleBooksClick(this, EventArgs.Empty); }
        }

        private void takenBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            outputInfo = InfoType.Taken;
            if (TakenBooksClick != null) { TakenBooksClick(this, EventArgs.Empty); }

        }
        
        private void booksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            countDiscrLb.Visible = true;
            avalableDiscrLb.Visible = true;
            authorDiscrLb.Visible = true;
            titleDiscrLb.Visible = true;
            selectedBook = (Book)booksTable.CurrentRow.DataBoundItem;
            if ((outputInfo == InfoType.All || outputInfo == InfoType.Taken) && selectedBook.AvalibleStatus == false)
            {
                ownerLb.Visible = true;
                ownerDiscrLb.Visible = true;
                ownerDiscrLb.Text = selectedBook.History.Last().Value.Login;
            }
            else
            {
                ownerLb.Visible = false;
                ownerDiscrLb.Visible = false;
            }

            titleDiscrLb.Text = selectedBook.Title;
            authorDiscrLb.Text = selectedBook.AuthorDiscription;
            if(TableClick != null) { TableClick(this, EventArgs.Empty); }
        }
        #endregion

        #region Methods

        public void Reflesh()
        {
            if (allBooksRb.Checked)
            {
                if (AllBooksClick != null) { AllBooksClick(this, EventArgs.Empty); };
            }

            if (avalableBooksRb.Checked)
            {
                if (AvalibleBooksClick != null) { AvalibleBooksClick(this, EventArgs.Empty); }
            };
            if (takenBooksRb.Checked)
            {
                if (TakenBooksClick != null) { TakenBooksClick(this, EventArgs.Empty); }
            };
        }

        public void InfoForHistoryTake()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0}(Id {1}) was taken at {2} by {3}",  selectedBook.Title, selectedBook.Id, selectedBook.History.Last().Key, selectedBook.History.Last().Value);
            builder.ToString();
            historyRtb.Text += builder;
            historyRtb.AppendText("\n");
        }

        public void InfoForHistoryTake(Book book)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0}(Id {1}) was taken at {2} by {3}", book.Title, book.Id, book.History.Last().Key, book.History.Last().Value);
            builder.ToString();
            historyRtb.Text += builder;
            historyRtb.AppendText("\n");
        }

        public void InfoForReturn(Book book)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0}(Id {1}) was returned at {2} by {3}", book.Title, book.Id, book.History.Last().Key, selectedBook.History.Last().Value);
            builder.ToString();
            historyRtb.Text += builder;
            historyRtb.AppendText("\n");
        }

        private void DiscribVisilbe()
        {
            authorDiscrLb.Visible = false;
            titleDiscrLb.Visible = false;
            countDiscrLb.Visible = false;
            avalableDiscrLb.Visible = false;
            ownerDiscrLb.Visible = false;
        }
        private void SetUp()
        {
            avalableBooksRb.Checked = true;
            helloLb.Text += presenter.CurrentUser.Login; // 
            helloLb.Text += "!";
            DoubleBuffered = true;
        }

        void HistoryVisible(bool flag)
        {
            historyPl.Visible = flag;
        }

        private void DGVSelectionMode()
        {
            booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksTable.MultiSelect = false;
        }
        #endregion

        #region Navigation
        private void toMenuBtn_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }

        private void toJournal_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Journal);
        }
        #endregion
        

        private void historyBtn_Click(object sender, EventArgs e)
        {
            if (historyPl.Visible)
            {
                historyPl.Visible = false;
            }
            else
            {
                historyPl.Visible = true;
            }
        }
        
    }
}
