using System;
using EscolaOuline.Menus;
using EscolaOuline.AccountsDto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EscolaOuline.Services;
using Microsoft.Data.SqlClient;
using Dapper;

namespace EscolaOuline
{
    public class Program
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static LoginScreen loginScreen = new LoginScreen();
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=EscolaOnlineConsoleDb;User ID=sa;Password=1q2w3e4r@#$";

            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectando...");

                //Testar o uso do GetAll students

                var studentsList = connection.Query<Student>("SELECT [Id], [Name], [PasswordHash], [Age], [ClassNumber], [Course] FROM [Student]");
                var professorsList = connection.Query<Professor>("SELECT [Id], [Name], [PasswordHash], [Ocupation], [Salary] FROM [Professor]");
                var adminsList = connection.Query<Admin>("SELECT [Id], [Name], [PasswordHash] FROM [Admin]");

                loginScreen.LoginScreenCall((List<Student>)studentsList, (List<Professor>)professorsList, (List<Admin>)adminsList, connection);
            }
        }
    }
}
