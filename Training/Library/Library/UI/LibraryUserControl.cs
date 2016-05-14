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
        bool isAdmin;
        
        public event EventHandler AllBooksClick;
        public event EventHandler AvalibleBooksClick;
        public event EventHandler TakenBooksClick;
        public bool IsAdmin {get { return isAdmin; }}
        Book selectedBook;

        public object BooksBindingSource
        {
            set { booksBindingSource.DataSource = value; }
        }

        public event EventHandler LibraryLoad;

        public LibraryUserControl()
        {
            InitializeComponent();
            DGVSelectionMode();
            helloLb.Text += LoginUserControl.Login;
            helloLb.Text += "!";
            DoubleBuffered = true;
            Presenter presenter = new Presenter(this);
            if (LoginUserControl.Admin)
            {
                removeBtn.Visible = true;
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }
        }

        private void toMenuBtn_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }

        private void toJournal_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Journal);
        }
        
        void HistoryVisible(bool flag)
        {
            historyPl.Visible = flag;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBookPl.Visible = true;
            returnBookPl.Visible = false;
        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            addBookPl.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            returnBookPl.Visible = false;

        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            returnBookPl.Visible = true;
            addBookPl.Visible = false;
        }

        private void LibraryUserControl_Load(object sender, EventArgs e)
        {
            if (LibraryLoad != null) { LibraryLoad(this, EventArgs.Empty); }
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

        private void DGVSelectionMode()
        {
            booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksTable.MultiSelect = false;
        }

        private void booksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBook = (Book)booksTable.CurrentRow.DataBoundItem;
            titleDiscrLb.Text = selectedBook.Title;
            authorDiscrLb.Text = selectedBook.authorDiscription;
            genreDiscrLb.Text = selectedBook.Id.ToString();
        }
    }
}
