using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.AccountsDto
{
    class StudentAccount
    {
        public StudentAccount(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Turma { get; set; }
        public string Curso { get; set; }
        public double Mensalidade { get; set; }
        public Contact Contact { get; set; }
    }
}
