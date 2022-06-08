using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaOuline.AccountsDto;

namespace EscolaOuline.Menus
{
    class RegistrationScreen
    {
        StudentRegistration studentRegistration = new StudentRegistration();
        public void RegistrationMenuCall()
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
            Console.WriteLine("                                 |        |          Voce é?          |        | |                              ");
            Console.WriteLine("                                 |        |___________________________|        | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |         1 - Aluno      2 - professor        | |                              ");
            Console.WriteLine("                                 |                                             | |                              ");
            Console.WriteLine("                                 |_____________________________________________| |                              ");
            Console.WriteLine(@"                                 \_____________________________________________\|                              ");
            Console.WriteLine();
            Console.Write("                                                  Resposta: ");

            string answer = Console.ReadLine();


            switch (answer)
            {
                case "1":
                    Console.Clear();
                    studentRegistration.RegisterStudentInSystem();
                    break;
                case "2":

                    break;
                default:
                    Console.Clear();
                    studentRegistration.RegisterStudentInSystem();
                    break;
            }

        }
    }
}

public class StudentRegistration
{
    //colocar o retorno como StudentAccount
    public void RegisterStudentInSystem()
    {
        var studentAccountList = new List<StudentAccount>();

        Console.WriteLine("                                  _______________________________________________                               ");
        Console.WriteLine("                                 |                                             | |                              ");
        Console.WriteLine("                                 |         ___________________________         | |                              ");
        Console.WriteLine("                                 |        |                           |        | |                              ");
        Console.WriteLine("                                 |        |  Preencha as informacoes  |        | |                              ");
        Console.WriteLine("                                 |        |___________________________|        | |                              ");
        Console.WriteLine("                                 |                                             | |                              ");
        Console.WriteLine("                                 |         Nome:                               | |                              ");
        Console.WriteLine("                                 |         Idade:                              | |                              ");
        Console.WriteLine("                                 |         Curso:                              | |                              ");
        Console.WriteLine("                                 |         Senha:                              | |                              ");
        Console.WriteLine("                                 |_____________________________________________| |                              ");
        Console.WriteLine(@"                                 \_____________________________________________\|                              ");

        string name = Console.ReadLine();
        string age = Console.ReadLine();
        string course = Console.ReadLine();
        string senha = Console.ReadLine();

        studentAccountList.Add(new StudentAccount()
        {
            UserName = name,
            Age = Int32.Parse(age),
            Curso = course,
            Password = senha,
        });
    }
}   
