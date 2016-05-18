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
        public event EventHandler LastOwner;
        public event EventHandler HistoryForBook;
        public event EventHandler HistoryForBooks;
        public event EventHandler RemoveBook;

        string owner;
        Book selectedBook;
        List<Domain.Action> booksActions;
        Book newBook;
        int returnId;
        InfoType outputInfo;
        Presenter presenter;

        public LibraryUserControl()
        {
            InitializeComponent();
            DGVSelectionMode();
            presenter = LoginUserControl.Presenter;
            SetUp();
            presenter.AddLibrary(this);
        }


        #region Properties
        public List<Domain.Action> BooksActions
        {
            set { booksActions = value; }
        }

        public string Owner
        {
            set { owner = value; }
        }
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

        #endregion

        #region Events

        #region Table
        private void allBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            historyRtb.Text = string.Empty;
            outputInfo = InfoType.All;
            if (AllBooksClick != null) { AllBooksClick(this, EventArgs.Empty); }
        }

        private void avalableBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            historyRtb.Text = string.Empty;
            ownerLb.Visible = false;
            outputInfo = InfoType.Avalible;
            if (AvalibleBooksClick != null) { AvalibleBooksClick(this, EventArgs.Empty); }
        }

        private void takenBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            DiscribVisilbe();
            historyRtb.Text = string.Empty;
            outputInfo = InfoType.Taken;
            if (TakenBooksClick != null) { TakenBooksClick(this, EventArgs.Empty); }

        }

        private void booksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            returnBookPl.Visible = false;
            historyRtb.Text = string.Empty;

            authorDiscrLb.Visible = true;
            titleDiscrLb.Visible = true;
            countDiscrLb.Visible = true;
            avalableDiscrLb.Visible = true;

            selectedBook = (Book)booksTable.CurrentRow.DataBoundItem;

            if (outputInfo == InfoType.All || outputInfo == InfoType.Taken)
            {
                ownerLb.Visible = true;
                ownerDiscrLb.Visible = true;
                if (selectedBook.AvalibleStatus == false)
                {
                    if (LastOwner != null) { LastOwner(this, EventArgs.Empty); }
                    ownerDiscrLb.Text = owner;
                }
                else
                {
                    ownerLb.Visible = false;
                    ownerDiscrLb.Visible = false;
                }

                if (HistoryForBook != null) { HistoryForBook(this, EventArgs.Empty); }

            }
            else
            {
                if (HistoryForBooks != null) { HistoryForBooks(this, EventArgs.Empty); }
            }

            StringBuilder builder = new StringBuilder();
            foreach (var action in booksActions)
            {
                if (action.Status == true)
                {
                    builder.AppendFormat("[{0}] {1}(id{2}) was taken by {3}\n", action.Date, action.Book.Title, action.Book.Id, action.User.Login);
                }
                else
                {
                    builder.AppendFormat("[{0}] {1}(id{2}) was returned by {3}\n", action.Date, action.Book.Title, action.Book.Id, action.User.Login);
                }
            }

            historyRtb.Text = builder.ToString();

            titleDiscrLb.Text = selectedBook.Title;
            authorDiscrLb.Text = selectedBook.AuthorDiscription;
            if (TableClick != null) { TableClick(this, EventArgs.Empty); }
        }
        #endregion

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBookPl.Visible = true;
            returnBookPl.Visible = false;
        }

        private void addNewBookOk_Click(object sender, EventArgs e)
        {
            addBookPl.Visible = false;
            Author newAuthor = new Author(addAuthorsTb.Text);
            List<Author> authors = new List<Author>();
            authors.Add(newAuthor);
            newBook = new Book(addTitleTb.Text, newAuthor);
            if (AddNewBook != null) { AddNewBook(this, EventArgs.Empty); }
            Reflesh();
            addTitleTb.Text = string.Empty;
            addAuthorsTb.Text = string.Empty;
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            if (selectedBook.AvalibleStatus == true)
            {
                if (TakeBook != null) { TakeBook(this, EventArgs.Empty); }
            }
            else
            {
                MessageBox.Show("This book is already taken", "Take error", MessageBoxButtons.OK);
                countDiscrLb.Text = string.Empty;
                avalableDiscrLb.Text = string.Empty;
                ownerDiscrLb.Text = string.Empty;
            }

            

            returnBookCb.Text = string.Empty;
            authorDiscrLb.Text = string.Empty;
            titleDiscrLb.Text = string.Empty;
            Reflesh();
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            returnBookCb.Items.Clear();
            User user = presenter.CurrentUser;
            List<string> cBitems = new List<string>();
            for (int i = 0; i < user.Books.Count; i++)
            {
                returnBookCb.Items.Add("Id" + user.Books[i].Id.ToString() + " " + user.Books[i].Title);
            }
            returnBookPl.Visible = true;
            addBookPl.Visible = false;
        }

        private void okReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (returnBookCb.Items.Count != 0)
            {
                //take Id
                string bookInfo = returnBookCb.Text;
                int s = bookInfo.IndexOf("d");
                int f = bookInfo.IndexOf(" ");
                string currentId = bookInfo.Substring(s + 1, f - s);

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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedBook.AvalibleStatus == true)
            {
                if (RemoveBook != null) { RemoveBook(this, EventArgs.Empty); }
                DiscribVisilbe();
                Reflesh();
            }
            else
            {
                MessageBox.Show("You can't delete this book", "Delete error", MessageBoxButtons.OK);
            }
        }

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

            if (presenter.CurrentUser.Administrator == true)
            {
                removeBtn.Visible = true;
            }

            else
            {
                removeBtn.Visible = false;
            }

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
    }
}
