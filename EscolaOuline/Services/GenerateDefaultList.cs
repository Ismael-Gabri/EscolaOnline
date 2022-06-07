using EscolaOuline.AccountsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.Services
{
    class GenerateDefaultList
    {
        public List<StudentAccount> GenerateStudentLists()
        {
            var studentAccountList = new List<StudentAccount>();

            //Students List
            studentAccountList.Add(new StudentAccount(1)
            {
                UserName = "Clebinho",
                Password = "Fortnite22",
                Curso = "Ciencia da computacao",
                Turma = 1003
            });
            studentAccountList.Add(new StudentAccount(2)
            {
                UserName = "Marcia",
                Password = "Brigadeiro33",
                Curso = "Engenharia",
                Turma = 2002
            });
            studentAccountList.Add(new StudentAccount(3)
            {
                UserName = "Pedro",
                Curso = "Medicina",
                Password = "AcendeOlanca44",
                Turma = 3002
            });

            return studentAccountList;
        }
        public List<ProfessorAccount> GenerateProfessorsLists()
        {
            var ProfessorsList = new List<ProfessorAccount>();

            //Professors List
            ProfessorsList.Add(new ProfessorAccount(1)
            {
                Name = "Guilherme",
                Password = "ChurrascoComCoca22",
                Ocupation = "Math teacher",
                Salary = 1200.00
            });

            ProfessorsList.Add(new ProfessorAccount(2)
            {
                Name = "Clebinho562",
                Password = "MbK20",
                Ocupation = "English teacher",
                Salary = 1200.00
            });
            ProfessorsList.Add(new ProfessorAccount(3)
            {
                Name = "BoloComSorvete",
                Password = "NumSeiCara06",
                Ocupation = "Biology teacher",
                Salary = 1200.00,
            });

            //Admin Acess
            ProfessorsList.Add(new ProfessorAccount(000)
            {
                Name = "IsmaelGabri",
                Password = "z9)Fd6Ln_&D]6pVs",
                Ocupation = "Math teacher",
                Salary = 1200.00,
            });

            return ProfessorsList;
        }

    }
}
