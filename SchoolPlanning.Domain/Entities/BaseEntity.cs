using System.ComponentModel.DataAnnotations;

namespace SchoolPlanning.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; } 
    }
}
