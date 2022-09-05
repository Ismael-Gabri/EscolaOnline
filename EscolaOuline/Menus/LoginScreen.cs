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
using Microsoft.Data.SqlClient;

namespace EscolaOuline.Menus
{
    public class LoginScreen
    {
        RegistrationScreen RegistrationScreen = new RegistrationScreen();
        UsersMenu usersMenu = new UsersMenu();
        GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        ProfessorsMenu professorsMenu = new ProfessorsMenu();
        AdminScreen adminScreen = new AdminScreen();

        public void LoginScreenCall(List<Student> studentAccountLists, List<Professor> professorsList, List<Admin> adminsList, SqlConnection connectionString)
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

            
            Console.WriteLine("                                  _______________________________________________                               ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         ___________________________         | |                              ");
            Console.WriteLine("                                 |        |                           |        | |                              ");
            Console.WriteLine("                                 |        |      Tela de Login        |        | |                              ");
            Console.WriteLine("                                 |        |___________________________|        | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         Username:                           | |                              ");
            Console.WriteLine("                                 |         Password:                           | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \______________________________________________\|                             ");
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                                                                     --> press F12 to register  ");

            //Generate Students and professors 

            CatchAndCheckLogin();

            //Methods -->

            void CatchAndCheckLogin()
            {
                Console.SetCursorPosition(53, 19);

                var userName = Console.ReadLine();

                Console.SetCursorPosition(53, 20);

                string password = Console.ReadLine();

                Console.SetCursorPosition(43, 27);

                //Validade login information and go to the correct menu -->

                foreach (Student student in studentAccountLists)
                {
                    if (userName == student.Name && password == student.PasswordHash)
                    {
                        usersMenu.UsersMenuCall(student.Name, studentAccountLists, professorsList, adminsList, connectionString);
                    }
                }

                foreach (Professor professor in professorsList)
                {
                    if (userName == professor.Name && password == professor.PasswordHash)
                    {
                        professorsMenu.ProfessorsMenuCall(professor.Name, studentAccountLists, professorsList, adminsList, connectionString);
                    }
                }

               foreach (Admin admin in adminsList)
                {
                    if (userName == admin.Name && password == admin.PasswordHash)
                    {
                        adminScreen.AdminScreenCall(admin.Name, studentAccountLists, professorsList,  adminsList, connectionString);
                    }
                }
            }

           /* void ToRegistrate()
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

            */
        }
    }
}
