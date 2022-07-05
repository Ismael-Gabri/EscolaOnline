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
                Password = "Fortnite22",
                Course = "Ciencia da computacao",
                Class = 1003
            });
            studentAccountList.Add(new Student()
            {
                Name = "Marcia",
                Password = "Brigadeiro33",
                Course = "Engenharia",
                Class = 2002
            });
            studentAccountList.Add(new Student()
            {
                Name = "Pedro",
                Course = "Medicina",
                Password = "MedicinaPorDinheiro33",
                Class = 3002
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
                Password = "ChurrascoComCoca22",
                Ocupation = "Math teacher",
                Salary = 1200.00
            });

            ProfessorsList.Add(new Professor()
            {
                Name = "Clebinho562",
                Password = "MbK20",
                Ocupation = "English teacher",
                Salary = 1200.00
            });
            ProfessorsList.Add(new Professor()
            {
                Name = "Marcus",
                Password = "UmaSenhaMuitoSegura55",
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
                Password = "z9)Fd6Ln_&D]6pVs",
            });

            return adminsAccountsList;
        }

    }
}
