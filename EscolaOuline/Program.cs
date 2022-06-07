using System;
using EscolaOuline.Menus;
using EscolaOuline.AccountsDto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EscolaOuline
{
    public class Program
    {
        static LoginScreen loginScreen = new LoginScreen();
        static void Main(string[] args)
        {
            loginScreen.LoginScreenCall();
        }
    }
}
