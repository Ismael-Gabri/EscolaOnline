using EscolaOuline.AccountsDto;
using EscolaOuline.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.Services
{
    class AccountServices
    {
        static UsersMenu usersMenu = new UsersMenu();
        //change the return type to StudentAccount
        public void ShowStudentInformation(string name, List<StudentAccount> studentsList)
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
                    usersMenu.UsersMenuCall(name);
                }
            }
        }
    }
}
