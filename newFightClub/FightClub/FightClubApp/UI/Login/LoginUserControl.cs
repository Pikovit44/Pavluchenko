using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp;
using System.Windows.Forms;

namespace FightClubApp.UI.Login
{
    public partial class LoginUserControl : BaseUserControl 
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void toFightMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Fight);
        }

        private void records_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Raiting);
        }
    }
}
