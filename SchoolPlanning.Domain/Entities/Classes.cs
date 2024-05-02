using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Domain.Entities
{
    [Table(nameof(Classes), Schema = "Entity")]
    public class Classes : BaseEntity
    {
        public string SchoolGrade { get; set; }

        public int Year { get; set; }

        public Employee Employee { get; set; }
    }
}
