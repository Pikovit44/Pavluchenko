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
    public partial class LibraryUserControl : BaseUserControl, ILibrary 
    {
        public event EventHandler AllBooksClick;
        public event EventHandler AvalibleBooksClick;
        public event EventHandler TakenBooksClick;
        public event EventHandler AddNewBook;
        Book selectedBook;
        Book newBook;

        public Book NewBook
        {
            get { return newBook; }
        }

        public object BooksBindingSource
        {
            set { booksBindingSource1.DataSource = value; }
        }
        

        public LibraryUserControl()
        {
            InitializeComponent();
            DGVSelectionMode();
            SetUp();
            Presenter presenter = new Presenter(this);
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

        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            returnBookPl.Visible = true;
            addBookPl.Visible = false; // refact!
            Author awd = new Author("awdawd");
            Book book = new Book("ex", awd);
            
            string comboItem = book.Id.ToString();
            comboItem += book.Title;
            returnBookCb.Items.Add(comboItem);
        }
        

        private void allBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            if (AllBooksClick != null) { AllBooksClick(this, EventArgs.Empty); }
        }

        private void avalableBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            if (AvalibleBooksClick != null) { AvalibleBooksClick(this, EventArgs.Empty); }
        }

        private void takenBooksRb_CheckedChanged(object sender, EventArgs e)
        {
            if (TakenBooksClick != null) { TakenBooksClick(this, EventArgs.Empty); }
        }

        

        private void booksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBook = (Book)booksTable.CurrentRow.DataBoundItem;
            titleDiscrLb.Text = selectedBook.Title;
            authorDiscrLb.Text = selectedBook.authorDiscription;
        }

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

        private void SetUp()
        {
            helloLb.Text += LoginUserControl.Login; // 
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
