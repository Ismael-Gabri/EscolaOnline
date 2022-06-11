using EscolaOuline.AccountsDto;
using EscolaOuline.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.Services
{
    public class AccountServices
    {
        static UsersMenu usersMenu = new UsersMenu();
        ProfessorsMenu professorsMenu = new ProfessorsMenu();

        //change the return type to StudentAccount
        public void ShowStudentInformation(string name, List<StudentAccount> studentsList, List<ProfessorAccount> professorAccounts, List<Admin> adminsList)
        {
            foreach(StudentAccount studentAccount in studentsList)
            {
                if(studentAccount.UserName == name)
                {
                    Console.WriteLine();
                    Console.WriteLine("Suas informacoes:");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"ID: {studentAccount.Id}");
                    Console.WriteLine($"Nome: {studentAccount.UserName}");
                    Console.WriteLine($"Turma: {studentAccount.Turma}");
                    Console.WriteLine($"Senha: {studentAccount.Password}");
                    Console.WriteLine($"Curso: {studentAccount.Curso}");
                    Console.WriteLine("-----------------------------");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para retornar");
                    Console.ReadLine();
                    usersMenu.UsersMenuCall(name, studentsList, professorAccounts, adminsList);
                }
            }
        }

        public void ShowProfessorInformation(string name, List<ProfessorAccount> professorsList, List<StudentAccount> studentAccounts, List<Admin> adminsList)
        {
            Console.Clear();
            foreach (ProfessorAccount professorAccount in professorsList)
            {
                if (professorAccount.Name == name)
                {
                    Console.WriteLine();
                    Console.WriteLine("Suas informacoes:");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"ID: {professorAccount.Id}");
                    Console.WriteLine($"Nome: {professorAccount.Name}");
                    Console.WriteLine($"Ocupacao: {professorAccount.Ocupation}");
                    Console.WriteLine($"Senha: {professorAccount.Password}");
                    Console.WriteLine($"Salário: {professorAccount.Salary}");
                    Console.WriteLine("-----------------------------");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para retornar");
                    Console.ReadLine();
                    professorsMenu.ProfessorsMenuCall(name, studentAccounts, adminsList);
                }
            }
        }
    }
}
