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
    public class AccountServices
    {
        static UsersMenu usersMenu = new UsersMenu();
        ProfessorsMenu professorsMenu = new ProfessorsMenu();

        //change the return type to StudentAccount
        public void ShowStudentInformation(string name, List<Student> studentsList, List<Professor> professorAccounts, List<Admin> adminsList, SqlConnection connectionString)
        {
            foreach(Student studentAccount in studentsList)
            {
                if(studentAccount.Name == name)
                {
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine("Suas informacoes:");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"ID: {studentAccount.Id}");
                    Console.WriteLine($"Nome: {studentAccount.Name}");
                    Console.WriteLine($"Turma: {studentAccount.Class}");
                    Console.WriteLine($"Senha: {studentAccount.Password}");
                    Console.WriteLine($"Curso: {studentAccount.Course}");
                    Console.WriteLine("-----------------------------");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para retornar");
                    Console.ReadLine();
                    usersMenu.UsersMenuCall(name, studentsList, professorAccounts, adminsList, connectionString);
                }
            }
        }

        public void ShowProfessorInformation(string name, List<Professor> professorsList, List<Student> studentAccounts, List<Admin> adminsList, SqlConnection connectionString )
        {
            Console.Clear();
            foreach (Professor professorAccount in professorsList)
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
                    professorsMenu.ProfessorsMenuCall(name, studentAccounts, professorsList, adminsList, connectionString);
                }
            }
        }
    }
}

