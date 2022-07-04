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
        static AdminScreen adminScreen = new AdminScreen()
;        //Professor Menu features -->
        public void ShowStudentsList(string Professorname, List<StudentAccount> studentAccounts, List<Admin> adminsList, List<ProfessorAccount> professorAccounts)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("Lista de alunos:");
            Console.WriteLine("================");

            foreach (StudentAccount student in studentAccounts)
            {
                Console.WriteLine();
                Console.WriteLine($"{student.Name.ToUpper()}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Nome: {student.Name}");
                Console.WriteLine($"Curso: {student.Course}");
                Console.WriteLine($"Turma: {student.Class}");
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();
            professorsMenu.ProfessorsMenuCall(Professorname, studentAccounts, professorAccounts, adminsList);
        }

        public void CreateStudentAccount(string Professorname, List<StudentAccount> studentAccounts, List<Admin> adminsList, List<ProfessorAccount> professorAccounts)
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
                Name = nome,
                Password = senha,
                Class = turma,
                Course = curso
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Estudante criado com sucesso, Vá a aba LISTA DE ALUNOS para checar!");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();

            adminScreen.AdminScreenCall(Professorname, studentAccounts, professorAccounts, adminsList);
        }

        public void DeleteStudentAccount(string professorName, List<StudentAccount> studentAccounts, List<Admin> adminsList, List<ProfessorAccount> professorAccounts)
        {
            Console.Clear();

            Console.SetCursorPosition(3, 0);

            string title = @"
                             /$$$$$$$           /$$             /$$                        
                            | $$__  $$          | $$            | $$                        
                            | $$  \ $$  /$$$$$$ | $$  /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ 
                            | $$  | $$ /$$__  $$| $$ /$$__  $$|_  $$_/   |____  $$ /$$__  $$
                            | $$  | $$| $$$$$$$$| $$| $$$$$$$$  | $$      /$$$$$$$| $$  \__/
                            | $$  | $$| $$_____/| $$| $$_____/  | $$ /$$ /$$__  $$| $$      
                            | $$$$$$$/|  $$$$$$$| $$|  $$$$$$$  |  $$$$/|  $$$$$$$| $$      
                            |_______/  \_______/|__/ \_______/   \___/   \_______/|__/      

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
            Console.WriteLine();
            Console.WriteLine("                                                                                              <---- Retornar F12");


            Console.SetCursorPosition(49, 18);
            string nome = Console.ReadLine();
            Console.SetCursorPosition(50, 19);
            string senha = Console.ReadLine();
            Console.SetCursorPosition(50, 20);
            int turma = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(50, 21);
            string curso = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite a palavra --> DELETAR <-- para confirmar");
            string confirmationOfDeletion = Console.ReadLine();

            foreach (StudentAccount student in studentAccounts)
            {
                if (student.Name == nome && student.Password == senha && student.Class == turma && student.Course == curso)
                {
                    Console.WriteLine();
                    studentAccounts.Remove(student);
                    Console.WriteLine("Aluno removido com sucesso");

                    Console.WriteLine("Pressione ENTER para retornar ao menu...");
                    Console.ReadLine();

                    adminScreen.AdminScreenCall(professorName, studentAccounts, professorAccounts, adminsList);
                }
            }
        }

        public void ShowProfessorsList(string AdminName, List<ProfessorAccount> professorAccounts, List<StudentAccount> studentAccounts, List<Admin> adminsList)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("Lista de alunos:");
            Console.WriteLine("================");

            foreach (ProfessorAccount professor in professorAccounts)
            {
                Console.WriteLine();
                Console.WriteLine($"{professor.Name.ToUpper()}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"ID: {professor.Id}");
                Console.WriteLine($"Nome: {professor.Name}");
                Console.WriteLine($"Ocupacao: {professor.Ocupation}");
                Console.WriteLine($"Salário: {professor.Salary}");
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();
            adminScreen.AdminScreenCall(AdminName, studentAccounts, professorAccounts, adminsList);
        }

        public void CreateProfessorAccount(string AdminName, List<StudentAccount> studentAccounts, List<Admin> adminsList, List<ProfessorAccount> professorAccounts)
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
            Console.WriteLine("                                 |         Ocupacao:                           | |                              ");
            Console.WriteLine("                                 |         Salario:                            | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \_____________________________________________\|                              ");
            Console.WriteLine();


            Console.SetCursorPosition(49, 21);
            string nome = Console.ReadLine();
            Console.SetCursorPosition(50, 22);
            string senha = Console.ReadLine();
            Console.SetCursorPosition(53, 23);
            string ocupacao = Console.ReadLine();
            Console.SetCursorPosition(52, 24);
            double Salario = Convert.ToDouble(Console.ReadLine());

            professorAccounts.Add(new ProfessorAccount()
            {
                Name = nome,
                Password = senha,
                Ocupation = ocupacao,
                Salary = Salario
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Professor criado com sucesso, Vá a aba LISTA DE PROFESSORES para checar!");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();

            adminScreen.AdminScreenCall(AdminName, studentAccounts, professorAccounts, adminsList);
        }

        public void DeleteProfessorAccount(string AdminName, List<StudentAccount> studentAccounts, List<Admin> adminsList, List<ProfessorAccount> professorAccounts)
        {
            Console.Clear();

            Console.SetCursorPosition(3, 0);

            string title = @"
                             /$$$$$$$           /$$             /$$                        
                            | $$__  $$          | $$            | $$                        
                            | $$  \ $$  /$$$$$$ | $$  /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ 
                            | $$  | $$ /$$__  $$| $$ /$$__  $$|_  $$_/   |____  $$ /$$__  $$
                            | $$  | $$| $$$$$$$$| $$| $$$$$$$$  | $$      /$$$$$$$| $$  \__/
                            | $$  | $$| $$_____/| $$| $$_____/  | $$ /$$ /$$__  $$| $$      
                            | $$$$$$$/|  $$$$$$$| $$|  $$$$$$$  |  $$$$/|  $$$$$$$| $$      
                            |_______/  \_______/|__/ \_______/   \___/   \_______/|__/      

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
            Console.WriteLine("                                 |         Ocupacao:                           | |                              ");
            Console.WriteLine("                                 |         Salario:                            | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \_____________________________________________\|                              ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                                                              <---- Retornar F12");


            Console.SetCursorPosition(49, 18);
            string nome = Console.ReadLine();
            Console.SetCursorPosition(50, 19);
            string senha = Console.ReadLine();
            Console.SetCursorPosition(53, 20);
            string ocupacao = Console.ReadLine();
            Console.SetCursorPosition(52, 21);
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite a palavra --> DELETAR <-- para confirmar");
            string confirmationOfDeletion = Console.ReadLine();
            Console.WriteLine();

            foreach (ProfessorAccount professor in professorAccounts)
            {
                if (professor.Name == nome && professor.Password == senha && professor.Ocupation == ocupacao && professor.Salary == salario)
                {
                    professorAccounts.Remove(professor);
                    Console.WriteLine("Professor removido com sucesso");

                    Console.WriteLine("Pressione ENTER para retornar ao menu...");
                    Console.ReadLine();

                    adminScreen.AdminScreenCall(nome, studentAccounts, professorAccounts, adminsList);
                }
            }
        }
    }
}
