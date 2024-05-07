using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Domain.Entities
{
    [Table(nameof(School), Schema = "Entity")]
    public class School : BaseEntity
    {
        public  string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public string ZipCode { get; set; }

        public string CNPJ { get; set; }

        public bool Active { get; set; }

    }
}
