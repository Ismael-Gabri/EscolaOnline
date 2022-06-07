using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaOuline.AccountsDto;
using EscolaOuline;
using EscolaOuline.Menus;
using System.Threading;


namespace EscolaOuline.Menus
{
    public class LoginScreen
    {
        RegistrationScreen RegistrationScreen = new RegistrationScreen();
        UsersMenu usersMenu = new UsersMenu();
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

            //Create local Accounts

            var ProfessorsList = new List<ProfessorAccount>();
            var studentAccountList = new List<StudentAccount>();

            //Professors List
            ProfessorsList.Add(new ProfessorAccount(1)
            {
                User = "Guilherme",
                Password = "ChurrascoComCoca22",
                Ocupation = "Math teacher",
                Salary = 1200.00
            });

            ProfessorsList.Add(new ProfessorAccount(2)
            {
                User = "Clebinho562",
                Password = "MbK20",
                Ocupation = "English teacher",
                Salary = 1200.00
            });
            ProfessorsList.Add(new ProfessorAccount(3)
            {
                User = "BoloComSorvete",
                Password = "NumSeiCara06",
                Ocupation = "Biology teacher",
                Salary = 1200.00,
            });

            //Admin Acess
            ProfessorsList.Add(new ProfessorAccount(000)
            {
                User = "IsmaelGabri",
                Password = "z9)Fd6Ln_&D]6pVs",
                Ocupation = "Math teacher",
                Salary = 1200.00,
            });

            //Students List
            studentAccountList.Add(new StudentAccount(1)
            {
                UserName = "Clebinho",
                Password = "Fortnite22",
                Curso = "Ciencia da computacao",
                Turma = 1003
            }); 
            studentAccountList.Add(new StudentAccount(2)
            {
                UserName = "Marcia",
                Password = "Brigadeiro33",
                Curso = "Engenharia",
                Turma = 2002
            });
            studentAccountList.Add(new StudentAccount(3)
            {
                UserName = "Pedro",
                Curso = "Medicina",
                Password = "AcendeOlanca44",
                Turma = 3002
            });

            CatchAndCheckLogin();




            //Methods -->

            void CatchAndCheckLogin()
            {
                Console.SetCursorPosition(53, 19);

                var userName = Console.ReadLine();

                Console.SetCursorPosition(53, 20);

                string password = Console.ReadLine();

                Console.SetCursorPosition(43, 27);
                //Validade login information -->

                foreach (StudentAccount student in studentAccountList)
                {
                    if (userName == student.UserName && password == student.Password)
                    {
                        usersMenu.UsersMenuCall(student.UserName);
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
