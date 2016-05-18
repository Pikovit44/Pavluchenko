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
    public partial class JournalUserControl : BaseUserControl, IJournal 
    {
        Presenter presenter;
        Letter selectedLetter;

        public JournalUserControl()
        {
            presenter = LoginUserControl.Presenter;
            InitializeComponent();
            DoubleBuffered = true;
            lettersBindingSource.DataSource = presenter.GetLetters().ToList();
            DGVSelectionMode();
        }

        private void lettersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLetter = (Letter)lettersTable.CurrentRow.DataBoundItem;
            LettersRtB.Text = selectedLetter.Text;
        }

        private void toLibraryBtn_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Library);
        }

        private void toMainMenuLb_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }

        private void DGVSelectionMode()
        {
            lettersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lettersTable.MultiSelect = false;
        }
        
    }
}
