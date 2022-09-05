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
        public List<Student> GenerateStudentLists()
        {
            var studentAccountList = new List<Student>();

            //Students List
            studentAccountList.Add(new Student()
            {
                Name = "Clebinho",
                PasswordHash = "Fortnite22",
                Course = "Ciencia da computacao",
                ClassNumber = 1003
            });
            studentAccountList.Add(new Student()
            {
                Name = "Marcia",
                PasswordHash = "Brigadeiro33",
                Course = "Engenharia",
                ClassNumber = 2002
            });
            studentAccountList.Add(new Student()
            {
                Name = "Pedro",
                Course = "Medicina",
                PasswordHash = "MedicinaPorDinheiro33",
                ClassNumber = 3002
            });

            return studentAccountList;
        }
        public List<Professor> GenerateProfessorsLists()
        {
            var ProfessorsList = new List<Professor>();

            //Professors List
            ProfessorsList.Add(new Professor()
            {
                Name = "Guilherme",
                PasswordHash = "ChurrascoComCoca22",
                Ocupation = "Math teacher",
                Salary = 1200.00
            });

            ProfessorsList.Add(new Professor()
            {
                Name = "Clebinho562",
                PasswordHash = "MbK20",
                Ocupation = "English teacher",
                Salary = 1200.00
            });
            ProfessorsList.Add(new Professor()
            {
                Name = "Marcus",
                PasswordHash = "UmaSenhaMuitoSegura55",
                Ocupation = "Biology teacher",
                Salary = 1200.00,
            });

            return ProfessorsList;
        }

        public List<Admin> GenerateAdminsList()
        {
            var adminsAccountsList = new List<Admin>();

            adminsAccountsList.Add(new Admin()
            {
                Name = "IsmaelGabri",
                PasswordHash = "z9)Fd6Ln_&D]6pVs",
            });

            return adminsAccountsList;
        }

    }
}
