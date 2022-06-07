using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.AccountsDto
{
    class ProfessorAccount
    {
        public ProfessorAccount(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Ocupation { get; set; }
        public double Salary { get; set; }
        public Contact Contato { get; set; }
    }
}
