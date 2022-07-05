using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaOuline.AccountsDto
{
    [Table("[Student]")]
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int Class { get; set; }
        public string Course { get; set; }
        public Contact Contact { get; set; }
    }
}
