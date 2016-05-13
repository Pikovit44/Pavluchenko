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
    public partial class LoginUserControl : BaseUserControl
    {
        static bool admin;

        public LoginUserControl()
        {
            admin = false;
            InitializeComponent();
            DoubleBuffered = true;
        }

        public static bool Admin { get { return admin; }  }

        void SetUp()
        {
            
        }

        private void signUpLb_CheckedChanged(object sender, EventArgs e)
        {
            SignUpVisible(signUpCb.Checked);
            regLoginTb.Focus();
        }

        void SignUpVisible(bool flag)
        {
            regLoginLb.Visible = flag;
            regLoginTb.Visible = flag;
            regEmailLb.Visible = flag;
            regPasswordTb.Visible = flag;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Library);
        }

        private void adminCb_CheckedChanged(object sender, EventArgs e)
        {
            admin = adminCb.Checked;
        }
    }
}
