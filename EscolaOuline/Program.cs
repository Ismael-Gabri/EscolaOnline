using System;
using EscolaOuline.Menus;
using EscolaOuline.AccountsDto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EscolaOuline.Services;

namespace EscolaOuline
{
    public class Program
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static LoginScreen loginScreen = new LoginScreen();
        static void Main(string[] args)
        {
            var studentAccountLists = generateDefaultList.GenerateStudentLists();
            var professorsList = generateDefaultList.GenerateProfessorsLists();

            loginScreen.LoginScreenCall(studentAccountLists, professorsList);
        }
    }
}
