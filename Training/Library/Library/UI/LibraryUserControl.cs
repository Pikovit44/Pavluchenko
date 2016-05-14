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

namespace Library.UI
{
    public partial class LibraryUserControl : BaseUserControl, ILibrary 
    {
        bool isAdmin;

        public event EventHandler LoadLibrary;
        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
        }

        public object BooksBindingSource
        {
            set { booksBindingSource.DataSource = value; }
        }

        public event EventHandler LibraryLoad;

        public LibraryUserControl()
        {
            InitializeComponent();
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
    }
}
