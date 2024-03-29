﻿using EscolaOuline.AccountsDto;
using EscolaOuline.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EscolaOuline.Menus
{
    class ProfessorsMenu
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static AccountServices accountServices = new AccountServices();
        static AccountManagement accountManagement = new AccountManagement();
        static LoginScreen loginScreen = new LoginScreen();
        public void ProfessorsMenuCall(string name, List<Student> studentAccounts, List<Professor> professorAccounts, List<Admin> adminsList, SqlConnection connectionString)
        {
            Console.Clear();

            string title = @"
                                                                                                    
                                                                           
                                /$$$$$$                                                
                               /$$__  $$                                               
  /$$$$$$   /$$$$$$   /$$$$$$ | $$  \__//$$$$$$   /$$$$$$$ /$$$$$$$  /$$$$$$   /$$$$$$ 
 /$$__  $$ /$$__  $$ /$$__  $$| $$$$   /$$__  $$ /$$_____//$$_____/ /$$__  $$ /$$__  $$
| $$  \ $$| $$  \__/| $$  \ $$| $$_/  | $$$$$$$$|  $$$$$$|  $$$$$$ | $$  \ $$| $$  \__/
| $$  | $$| $$      | $$  | $$| $$    | $$_____/ \____  $$\____  $$| $$  | $$| $$      
| $$$$$$$/| $$      |  $$$$$$/| $$    |  $$$$$$$ /$$$$$$$//$$$$$$$/|  $$$$$$/| $$      
| $$____/ |__/       \______/ |__/     \_______/|_______/|_______/  \______/ |__/      
| $$                                                                                   
| $$                                                                                   
|__/                                                                                   

                                     ";

            Console.WriteLine(title);


            Console.WriteLine($"Bem-vindo a sua conta professor {name}! O que deseja realizar?");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("[1] - Minhas informacoes ");
            Console.WriteLine("[2] - Meus Alunos ");
            Console.WriteLine("[3] - Adicionar um aluno");
            Console.WriteLine("[4] - Remover um aluno");
            Console.WriteLine();
            Console.WriteLine("[5] - Sair da conta");
            Console.WriteLine();

            Console.Write("Resposta: ");


            int answer;

            if (int.TryParse(Console.ReadLine(), out answer))
            {
                if (answer > 5 || answer < 1)
                {
                    Console.WriteLine("[!] Escolha Apenas uma das opções disponíveis [!]");
                    Thread.Sleep(3000);
                    ProfessorsMenuCall(name, studentAccounts, professorAccounts,adminsList, connectionString);
                }
                else
                {
                    switch (answer)
                    {
                        case 1:
                            accountServices.ShowProfessorInformation(name, professorAccounts, studentAccounts, adminsList, connectionString);
                            break;
                        case 2:
                            accountManagement.ListStudent(name, studentAccounts, adminsList, professorAccounts, connectionString);
                            break;
                        case 3:
                            accountManagement.CreateStudentAccount(name, studentAccounts, adminsList, professorAccounts, connectionString);
                            break;
                        case 4:
                            accountManagement.DeleteStudentAccount(name, studentAccounts, adminsList, professorAccounts, connectionString);
                            break;
                        case 5:
                            Console.SetCursorPosition(53, 19);
                            loginScreen.LoginScreenCall(studentAccounts, professorAccounts, adminsList, connectionString);
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
