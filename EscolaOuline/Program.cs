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
              
     Eu de amanha, resolver o problema da criacao de estudantes no metodo dos professores
                
     1 - Consertando Bugs na tela

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

                //Testar o uso do GetAll students

                var studentsList = connection.Query<Student>("SELECT [Id], [Name], [Password], [Age], [Class], [Course] FROM [Student]");
                var professorsList = connection.Query<Professor>("SELECT [Id], [Name], [Password], [Ocupation], [Salary] FROM [Professor]");
                var adminsList = connection.Query<Admin>("SELECT [Id], [Name], [Password] FROM [Admin]");

                loginScreen.LoginScreenCall((List<Student>)studentsList, (List<Professor>)professorsList, (List<Admin>)adminsList, connection);
            }
        }
    }
}
