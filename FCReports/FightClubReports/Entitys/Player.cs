using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightClubReports
{
    public class Player
    {
        
        string login;
        int password;
        DateTime dateOfRegistr;
        string email;
        bool isEmaillValid;
        List<Combat> gameData;

        public Player(int password, string login, string email)
        {
            this.password = password;
            this.login = login;
            this.email = email;
            dateOfRegistr = DateTime.Now;
        }

        public string Login
        {
            get { return login; }
        }

        public DateTime DateOfRegistr
        {
            get { return dateOfRegistr; }
        }

        public string Email
        {
            get { return email; }
        }




    }
}