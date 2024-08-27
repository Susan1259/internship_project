using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? EmploymentStatus { get; set; }

        [Required]
        public string? JobTitle { get; set; }
    }
}
