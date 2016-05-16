using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.Interfaces
{
    public interface ILogin
    {
        bool Admin { get ; } 
        string Login { get; }
        string Email { get; }
        event EventHandler SignIn;
        event EventHandler Registration;
        void LoginEmailError(bool log, bool em);
    }
}
