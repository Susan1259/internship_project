using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class EmployeeVM
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Display(Name = "Employment Status")]
        [Required]
        public string? EmploymentStatus { get; set; }

        [Display(Name = "Job Title")]
        [Required]
        public string? JobTitle { get; set; }

    }
}

