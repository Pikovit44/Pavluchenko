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
    public partial class LoginUserControl : BaseUserControl, ILogin 
    {
        bool admin;
        string login;
        string email;
        static Presenter presenter;

        public LoginUserControl()
        {
            presenter = new Presenter(this); 
            admin = false;
            InitializeComponent();
            DoubleBuffered = true;
        }

        public bool Admin { get { return admin; }  }
        public static Presenter Presenter { get { return presenter; } }
        public string Login { get { return login; } }
        public string Email { get { return email; } }
        public event EventHandler SignIn;
        public event EventHandler Registration;

        void SetUp()
        {
            
        }

        private void signUpLb_CheckedChanged(object sender, EventArgs e)
        {
            SignUpVisible(signUpCb.Checked);
            regLoginTb.Focus();
        }

        public void LoginEmailError(bool log, bool em)
        {
            if (log) { MessageBox.Show("User with this login is already exists", "Login error", MessageBoxButtons.OK); }
            if (em) { MessageBox.Show("User with this email is already exists", "Login error", MessageBoxButtons.OK); }
        }

        void SignUpVisible(bool flag)
        {
            regLoginLb.Visible = flag;
            regLoginTb.Visible = flag;
            regEmailLb.Visible = flag;
            regEmailTb.Visible = flag;
            adminCb.Visible = flag;
            loginTb.Visible = !flag;
            loginTb.Text = string.Empty;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (signUpCb.Checked)
            {
                login = regLoginTb.Text;
                email = regEmailTb.Text;
                if (Registration != null) { Registration(this, EventArgs.Empty); }
            }
            else
            {
                login = loginTb.Text;
                if (SignIn != null) { SignIn(this, EventArgs.Empty); }
            }

            if (presenter.CurrentUser != null)
            {
                SwitchScene(Scene.Library);
            }
            else
            {
                MessageBox.Show("User with this login is not found", "Login error", MessageBoxButtons.OK);
            }
            
        }

        private void adminCb_CheckedChanged(object sender, EventArgs e)
        {
            admin = adminCb.Checked;
        }
    }
}
