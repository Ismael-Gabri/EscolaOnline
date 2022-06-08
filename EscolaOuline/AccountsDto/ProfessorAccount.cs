using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.AccountsDto
{
    public class ProfessorAccount
    {
        public ProfessorAccount()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string Ocupation { get; set; }
        public double Salary { get; set; }
        public Contact Contato { get; set; }
    }
}
