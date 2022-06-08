using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EscolaOuline.Services;
using EscolaOuline.AccountsDto;

namespace EscolaOuline.Menus
{
    class UsersMenu
    {
        static AccountServices accountServices = new AccountServices();
        static LoginScreen loginScreen = new LoginScreen();
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        public void UsersMenuCall(string user, List<StudentAccount> studentAccounts, List<ProfessorAccount> professorAccounts)
        {
       

            Console.Clear();

            string title = @"
                                                                                                    
                                                                           
  /$$$$$$   /$$$$$$$ /$$$$$$   /$$   /$$  /$$$$$$$  /$$$$$$  /$$$$$$$  /$$$$$$    /$$$$$$ 
 /$$__  $$ /$$_____/|_  $$_/  | $$  | $$ /$$__  $$ |____  $$| $$__  $$|_  $$_/   /$$__  $$
| $$$$$$$$|  $$$$$$   | $$    | $$  | $$| $$  | $$  /$$$$$$$| $$  \ $$  | $$    | $$$$$$$$
| $$_____/ \____  $$  | $$ /$$| $$  | $$| $$  | $$ /$$__  $$| $$  | $$  | $$ /$$| $$_____/
|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$/|  $$$$$$$|  $$$$$$$| $$  | $$  |  $$$$/|  $$$$$$$
 \_______/|_______/    \___/   \______/  \_______/ \_______/|__/  |__/   \___/   \_______/

                                     ";

            Console.WriteLine(title);


            Console.WriteLine($"Bem-vindo a sua conta {user}! O que deseja realizar?");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("[1] - Minhas informacoes ");
            Console.WriteLine("[2] - Meus cursos ");
            Console.WriteLine("[3] - Secretaria ");
            Console.WriteLine();
            Console.WriteLine("[4] - Sair da conta");
            Console.WriteLine();

            Console.Write("Resposta: ");


            int answer;

            if(int.TryParse(Console.ReadLine(), out answer))
            {
                if(answer > 4 || answer < 1)
                {
                    Console.WriteLine("[!] Escolha Apenas uma das opções disponíveis [!]");
                    Thread.Sleep(3000);
                    UsersMenuCall(user, studentAccounts, professorAccounts);
                }
                else
                {
                    switch (answer)
                    {
                        case 1:
                            accountServices.ShowStudentInformation(user, studentAccounts, professorAccounts);
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:
                            Console.SetCursorPosition(53, 19);
                            loginScreen.LoginScreenCall(studentAccounts, professorAccounts);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("[!] Digite apenas números [!]");
            }
        }
    }
}
