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
    /*
     * Coisas a fazer:

     1 - Implementar um Tecla para retornar em todos os menus (Fazer por último)
     2 - Resolver o problema de rodar 2 methodos de uma vez (Fazer por último)

             *Fazendo

              1- Adaptadondo os métodos de CreateStudentAccount & DeleteStudentAccount para atualizar no Banco de Dados quando realizado

    */
    public class Program
    {
        static GenerateDefaultList generateDefaultList = new GenerateDefaultList();
        static LoginScreen loginScreen = new LoginScreen();
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=EscolaOnline;User ID=sa;Password=1q2w3e4r@#$";

            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectando...");

                var studentsList = connection.Query<StudentAccount>("SELECT [Id], [Name], [Password], [Age], [Class], [Course] FROM [Aluno]");
                var professorsList = connection.Query<ProfessorAccount>("SELECT [Id], [Name], [Password], [Ocupation], [Salary] FROM [Professor]");
                var adminsList = connection.Query<Admin>("SELECT [Id], [Name], [Password] FROM [Admin]");

                loginScreen.LoginScreenCall((List<StudentAccount>)studentsList, (List<ProfessorAccount>)professorsList, (List<Admin>)adminsList);
            }
        }
    }
}
