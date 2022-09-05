using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.AccountsDto
{
    [Table("[Professor]")]
    public class Professor
    {
        public Professor()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string Ocupation { get; set; }
        public double Salary { get; set; }
        public Contact Contato { get; set; }
    }
}
