using Dapper;
using EscolaOuline.AccountsDto;
using EscolaOuline.Menus;
using Microsoft.Data.SqlClient;
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
        static AdminScreen adminScreen = new AdminScreen();

        public void ListStudent(string Professorname, List<Student> studentAccounts, List<Admin> adminsList, List<Professor> professorAccounts, SqlConnection connection)
        {
            var alunos = connection.Query<Student>("SELECT [Id], [Name], [Age], [Class], [Course] FROM [Student]");

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("Lista de alunos:");
            Console.WriteLine("================");

            foreach (var aluno in alunos)
            {
                Console.WriteLine();
                Console.WriteLine($"{aluno.Name.ToUpper()}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"ID: {aluno.Id}");
                Console.WriteLine($"Nome: {aluno.Name}");
                Console.WriteLine($"Curso: {aluno.Course}");
                Console.WriteLine($"Turma: {aluno.Class}");
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();
            professorsMenu.ProfessorsMenuCall(Professorname, studentAccounts, professorAccounts, adminsList, connection);
        }

        //A FAZER
        public void CreateStudentAccount(string Professorname, List<Student> studentAccounts, List<Admin> adminsList, List<Professor> professorAccounts, SqlConnection connection)
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

            Student newStudent = new Student();
            newStudent.Id = Guid.NewGuid();
            newStudent.Name = nome;
            newStudent.Password = senha;
            newStudent.Age = 21;
            newStudent.Class = turma;
            newStudent.Course = curso;

            const string connectionString = "Server=localhost,1433;Database=EscolaOnline;User ID=sa;Password=1q2w3e4r@#$";

            var insertSql = @"INSERT INTO [Student] VALUES(

                    @Id, 
                    @Name,
                    @Password, 
                    @Age,
                    @Class,
                    @Course
                )";

            using (var Currentconnection = new SqlConnection(connectionString)) //Open connection
            {
                var rows = connection.Execute(insertSql, new 
                {
                    newStudent.Id,
                    newStudent.Name,
                    newStudent.Password,
                    newStudent.Age,
                    newStudent.Class,
                    newStudent.Course
                });

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{rows} Estudante(s) criado(s) com sucesso, Vá a aba LISTA DE ALUNOS para checar!");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para retornar...");
                Console.ReadLine();
            }

            adminScreen.AdminScreenCall(Professorname, studentAccounts, professorAccounts, adminsList, connection);
        }

        //A FAZER
        public void DeleteStudentAccount(string professorName, List<Student> studentAccounts, List<Admin> adminsList, List<Professor> professorAccounts, SqlConnection connection)
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

            string deleteStudentSql = "DELETE FROM [Student] WHERE [Name] = @Nome";


            Console.SetCursorPosition(49, 18);
            string nome = Console.ReadLine();
            Console.SetCursorPosition(50, 19);
            string senha = Console.ReadLine();
            Console.SetCursorPosition(50, 20);
            int turma = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(50, 21);
            string curso = Console.ReadLine();

            connection.Execute(deleteStudentSql, new {
                nome
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Aperte --> ENTER <-- para continuar");
            string confirmationOfDeletion = Console.ReadLine();

            adminScreen.AdminScreenCall(professorName, studentAccounts, professorAccounts, adminsList, connection);
        }


        //A FAZER
        public void ShowProfessorsList(string AdminName, List<Professor> professorAccounts, List<Student> studentAccounts, List<Admin> adminsList, SqlConnection connection)
        {
            var professores = connection.Query<Professor>("SELECT [Id], [Name], [Ocupation], [Salary] FROM [Professor]");

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Lista de Professores:");
            Console.WriteLine("=====================");

            foreach (var professor in professores)
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
            adminScreen.AdminScreenCall(AdminName, studentAccounts, professorAccounts, adminsList, connection);
        }


        //A FAZER
        public void CreateProfessorAccount(string AdminName, List<Student> studentAccounts, List<Admin> adminsList, List<Professor> professorAccounts, SqlConnection connection)
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
            double salario = Convert.ToDouble(Console.ReadLine());

            Professor professor = new Professor();
            professor.Id = Guid.NewGuid();
            professor.Name = nome;
            professor.Password = senha;
            professor.Ocupation = ocupacao;
            professor.Salary = salario;


            var insertProfessorSql = @"INSERT INTO [Professor] VALUES(

                    @Id, 
                    @Name,
                    @Password, 
                    @Ocupation,
                    @Salary
                )";

            var rows = connection.Execute(insertProfessorSql, new {
                professor.Id,
                professor.Name,
                professor.Password,
                professor.Ocupation,
                professor.Salary
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{rows} Professor(es) criado(s) com sucesso, Vá a aba LISTA DE PROFESSORES para checar!");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para retornar...");
            Console.ReadLine();

            adminScreen.AdminScreenCall(AdminName, studentAccounts, professorAccounts, adminsList, connection);
        }

        //A FAZER
        public void DeleteProfessorAccount(string AdminName, List<Student> studentAccounts, List<Admin> adminsList, List<Professor> professorAccounts, SqlConnection connection)
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

            string deleteStudentSql = "DELETE FROM [Professor] WHERE [Name] = @Nome";

            var rows = connection.Execute(deleteStudentSql, new
            {
                nome
            });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite a palavra --> DELETAR <-- para confirmar");
            string confirmationOfDeletion = Console.ReadLine();
            Console.WriteLine();

            adminScreen.AdminScreenCall(nome, studentAccounts, professorAccounts, adminsList, connection);
        }
    }
}
