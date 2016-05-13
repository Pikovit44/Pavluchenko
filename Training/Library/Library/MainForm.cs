using Library.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public enum Scene
    {
        Login,
        Library,
        Journal
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SwitchScene(Scene.Login);
        }

        public void SwitchScene(Scene scene)
        {
            UserControl ctrl = null;
            switch (scene)
            {
                case Scene.Login:
                    ctrl = new LoginUserControl();
                    break;

                case Scene.Library:
                    ctrl = new LibraryUserControl();
                    break;
                case Scene.Journal:
                    ctrl = new JournalUserControl();
                    break;

                default:
                    break;
            }
            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);
            }
        }
    }
}
