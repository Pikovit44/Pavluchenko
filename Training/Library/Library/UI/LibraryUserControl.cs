using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class LibraryUserControl : BaseUserControl
    {
        public LibraryUserControl()
        {
            InitializeComponent();
            DoubleBuffered = true;
            if (LoginUserControl.Admin)
            {
                removeBtn.Visible = true;
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnBookPl_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
