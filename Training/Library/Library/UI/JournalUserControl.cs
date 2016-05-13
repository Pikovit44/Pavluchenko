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
    public partial class JournalUserControl : BaseUserControl
    {
        public JournalUserControl()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void toLibraryBtn_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Library);
        }

        private void toMainMenuLb_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Login);
        }
    }
}
