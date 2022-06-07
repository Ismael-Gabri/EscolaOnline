using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaOuline.AccountsDto;
using EscolaOuline;
using EscolaOuline.Menus;
using System.Threading;
using EscolaOuline.Services;

namespace EscolaOuline.Menus
{
    public class LoginScreen
    {
        RegistrationScreen RegistrationScreen = new RegistrationScreen();
        UsersMenu usersMenu = new UsersMenu();
        GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        ProfessorsMenu professorsMenu = new ProfessorsMenu();

        public void LoginScreenCall()
        {
            Console.Clear();

            string title = @"
     $$$$$$$$\                               $$\                                     $$\ $$\                     
     $$  _____|                              $$ |                                    $$ |\__|                    
     $$ |       $$$$$$$\  $$$$$$$\  $$$$$$\  $$ | $$$$$$\         $$$$$$\  $$\   $$\ $$ |$$\ $$$$$$$\   $$$$$$\  
     $$$$$\    $$  _____|$$  _____|$$  __$$\ $$ | \____$$\       $$  __$$\ $$ |  $$ |$$ |$$ |$$  __$$\ $$  __$$\ 
     $$  __|   \$$$$$$\  $$ /      $$ /  $$ |$$ | $$$$$$$ |      $$ /  $$ |$$ |  $$ |$$ |$$ |$$ |  $$ |$$$$$$$$ |
     $$ |       \____$$\ $$ |      $$ |  $$ |$$ |$$  __$$ |      $$ |  $$ |$$ |  $$ |$$ |$$ |$$ |  $$ |$$   ____|
     $$$$$$$$\ $$$$$$$  |\$$$$$$$\ \$$$$$$  |$$ |\$$$$$$$ |      \$$$$$$  |\$$$$$$  |$$ |$$ |$$ |  $$ |\$$$$$$$\ 
     \________|\_______/  \_______| \______/ \__| \_______|       \______/  \______/ \__|\__|\__|  \__| \_______|

";

            Console.WriteLine(title);

            bool loginScreenActive = true;

            
            Console.WriteLine("                                  _______________________________________________                           ");
            Console.WriteLine("                                 |                                             | |                           ");
            Console.WriteLine("                                 |         ___________________________         | |                             ");
            Console.WriteLine("                                 |        |                           |        | |                              ");
            Console.WriteLine("                                 |        |      Tela de Login        |        | |                              ");
            Console.WriteLine("                                 |        |___________________________|        | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         Username:                           | |                             ");
            Console.WriteLine("                                 |         Password:                           | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \______________________________________________\|                                                                           ");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("                                                                                     --> press F12 to register                        ");

            //Generate Students and professors 

            var studentAccountLists = generateDefaultList.GenerateStudentLists();
            var professorsList = generateDefaultList.GenerateProfessorsLists();

            CatchAndCheckLogin();

            //Methods -->

            void CatchAndCheckLogin()
            {
                Console.SetCursorPosition(53, 19);

                var userName = Console.ReadLine();

                Console.SetCursorPosition(53, 20);

                string password = Console.ReadLine();

                Console.SetCursorPosition(43, 27);

                //Validade login information and go to menu if correct -->

                foreach (StudentAccount student in studentAccountLists)
                {
                    if (userName == student.UserName && password == student.Password)
                    {
                        usersMenu.UsersMenuCall(student.UserName);
                    }
                }

                foreach (ProfessorAccount professor in professorsList)
                {
                    if (userName == professor.Name && password == professor.Password)
                    {
                        professorsMenu.ProfessorsMenuCall(professor.Name);
                    }
                }
            }

            void ToRegistrate()
            {
                do
                {
                    var userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.F12)
                    {
                        loginScreenActive = false;
                        Console.Clear();
                        RegistrationScreen.RegistrationMenuCall();
                    }
                }
                while (loginScreenActive);
            }
        }
    }
}
