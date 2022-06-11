using System;
using EscolaOuline.Menus;
using EscolaOuline.AccountsDto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EscolaOuline.Services;

namespace EscolaOuline
{
    //Coisas a Fazer:

    // 1 - Implementar um Tecla para retornar em todos os menus
    // 2 - Resolver o problema de rodar 2 methodos de uma vez
    // 3 - Criar o Menu Admin
    public class Program
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static LoginScreen loginScreen = new LoginScreen();
        static void Main(string[] args)
        {
            
            var studentAccountLists = generateDefaultList.GenerateStudentLists();
            var professorsList = generateDefaultList.GenerateProfessorsLists();
            var adminsList = generateDefaultList.GenerateAdminsList();

            loginScreen.LoginScreenCall(studentAccountLists, professorsList, adminsList);
        }
    }
}
