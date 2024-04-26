using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Domain.Entities
{
    [Table(nameof(Employee), Schema = "Entity")]
    public class Employee: BaseEntity
    {
        public int SchoolId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public string Role { get; set; }

        public string CPF { get; set; }

        public School School { get; set; }

    }
}
