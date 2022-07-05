using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EscolaOuline.Services;
using EscolaOuline.Menus;
using EscolaOuline.AccountsDto;
using Microsoft.Data.SqlClient;

namespace EscolaOuline.Menus
{
    class AdminScreen
    {

        public void AdminScreenCall(string name, List<Student> studentAccounts, List<Professor> professorAccounts, List<Admin> adminsList, SqlConnection connectionString)
        {
             GenerateDefaultList generateDefaultList = new GenerateDefaultList();
             AccountServices accountServices = new AccountServices();
             AccountManagement accountManagement = new AccountManagement();
             LoginScreen loginScreen = new LoginScreen();
             ProfessorsMenu professorsMenu = new ProfessorsMenu();

            Console.Clear();

            var profesorsAccountList = generateDefaultList.GenerateProfessorsLists();

            string title = @"
                                                                                                    
                                                                           
  /$$$$$$        /$$               /$$          
 /$$__  $$      | $$              |__/          
| $$  \ $$  /$$$$$$$ /$$$$$$/$$$$  /$$ /$$$$$$$ 
| $$$$$$$$ /$$__  $$| $$_  $$_  $$| $$| $$__  $$
| $$__  $$| $$  | $$| $$ \ $$ \ $$| $$| $$  \ $$
| $$  | $$| $$  | $$| $$ | $$ | $$| $$| $$  | $$
| $$  | $$|  $$$$$$$| $$ | $$ | $$| $$| $$  | $$
|__/  |__/ \_______/|__/ |__/ |__/|__/|__/  |__/                                                   

                                     ";

            Console.WriteLine(title);


            Console.WriteLine($"Bem-vindo a sua conta Admin {name}! O que deseja realizar?");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.WriteLine("[1] - Lista de Alunos ");
            Console.WriteLine("[2] - Adicionar um aluno");
            Console.WriteLine("[3] - Remover um aluno");
            Console.WriteLine();
            Console.WriteLine("[4] - Lista de Professores");
            Console.WriteLine("[5] - Adicionar um professor");
            Console.WriteLine("[6] - Remover um professor");

            Console.WriteLine();
            Console.WriteLine("[7] - Sair da conta");
            Console.WriteLine();

            Console.Write("Resposta: ");


            int answer;

            if (int.TryParse(Console.ReadLine(), out answer))
            {
                if (answer > 7 || answer < 1)
                {
                    Console.WriteLine("[!] Escolha Apenas uma das opções disponíveis [!]");
                    Thread.Sleep(3000);
                    professorsMenu.ProfessorsMenuCall(name, studentAccounts, professorAccounts, adminsList, connectionString);
                }
                else
                {
                    switch (answer)
                    {
                        case 1:
                            accountManagement.ListStudent(name, studentAccounts, adminsList, professorAccounts, connectionString); //usar metodo override
                            break;
                        case 2:
                            accountManagement.CreateStudentAccount(name, studentAccounts, adminsList, professorAccounts, connectionString); //usar metodo override
                            break;
                        case 3:
                            accountManagement.DeleteStudentAccount(name, studentAccounts, adminsList, professorAccounts, connectionString); //usar metodo override
                            break;
                        case 4:
                            accountManagement.ShowProfessorsList(name, professorAccounts, studentAccounts, adminsList, connectionString);  //usar metodo override
                            break;
                        case 5:
                            accountManagement.CreateProfessorAccount(name, studentAccounts, adminsList, professorAccounts, connectionString);
                            break;
                        case 6:
                            accountManagement.DeleteProfessorAccount(name, studentAccounts, adminsList, professorAccounts, connectionString);
                            break;
                        case 7:
                            Console.SetCursorPosition(53, 19);
                            loginScreen.LoginScreenCall(studentAccounts, profesorsAccountList, adminsList, connectionString);
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
