using EscolaOuline.AccountsDto;
using EscolaOuline.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.Services
{
    class AccountManagement
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static ProfessorsMenu professorsMenu = new ProfessorsMenu();
        //Professor Menu features -->
        public void ShowStudentsList(string Professorname, List<StudentAccount> studentAccounts)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("Lista de alunos:");
            Console.WriteLine("================");

            foreach (StudentAccount student in studentAccounts)
            {
                Console.WriteLine();
                Console.WriteLine($"{student.UserName.ToUpper()}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Nome: {student.UserName}");
                Console.WriteLine($"Ocupacao: {student.Curso}");
                Console.WriteLine($"Turma: {student.Turma}");
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar");
            Console.ReadLine();
            professorsMenu.ProfessorsMenuCall(Professorname, studentAccounts);
        }

        public void CreateStudentAccount(string Professorname, List<StudentAccount> studentAccounts)
        {

            Console.Clear();

            Console.SetCursorPosition(3, 0);

            string title = @"
                      $$$$$$$\                      $$\             $$\                         
                     $$  __$$\                     \__|            $$ |                        
                     $$ |  $$ | $$$$$$\   $$$$$$\  $$\  $$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  
                     $$$$$$$  |$$  __$$\ $$  __$$\ $$ |$$  _____|\_$$  _|  $$  __$$\ $$  __$$\ 
                     $$  __$$< $$$$$$$$ |$$ /  $$ |$$ |\$$$$$$\    $$ |    $$$$$$$$ |$$ |  \__|
                     $$ |  $$ |$$   ____|$$ |  $$ |$$ | \____$$\   $$ |$$\ $$   ____|$$ |      
                     $$ |  $$ |\$$$$$$$\ \$$$$$$$ |$$ |$$$$$$$  |  \$$$$  |\$$$$$$$\ $$ |      
                     \__|  \__| \_______| \____$$ |\__|\_______/    \____/  \_______|\__|      
                                         $$\   $$ |                                            
                                          \$$$$$$  |                                            
                                           \______/                                             

                                     ";

            Console.WriteLine(title);


            Console.WriteLine("                                  _______________________________________________                               ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         ___________________________         | |                              ");
            Console.WriteLine("                                 |        |                           |        | |                              ");
            Console.WriteLine("                                 |        |    Preencha os campos     |        | |                              ");
            Console.WriteLine("                                 |        |___________________________|        | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         Nome:                               | |                              ");
            Console.WriteLine("                                 |         Senha:                              | |                              ");
            Console.WriteLine("                                 |         Turma:                              | |                              ");
            Console.WriteLine("                                 |         Curso:                              | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \_____________________________________________\|                              ");
            Console.WriteLine();


            Console.SetCursorPosition(49, 21);
            string nome = Console.ReadLine();
            Console.SetCursorPosition(50, 22);
            string senha = Console.ReadLine();
            Console.SetCursorPosition(50, 23);
            int turma = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(50, 24);
            string curso = Console.ReadLine();

            studentAccounts.Add(new StudentAccount()
            {
                UserName = nome,
                Password = senha,
                Turma = turma,
                Curso = curso
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Estudante criado com sucesso, Vá a aba MEUS ALUNOS para checar!");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();

            professorsMenu.ProfessorsMenuCall(Professorname, studentAccounts);
        }

        public void DeleteStudentAccount()
        {

        }
    }
}
