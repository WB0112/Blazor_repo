using System.ComponentModel.DataAnnotations;
namespace EmployeeOnboardingPortal.Models
{
    public class Employee
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Range(0, 30)]
        public int ExperienceYears { get; set; }

        [Required]
        public Address Address { get; set; } = new();

        public bool AcceptPolicy { get; set; }

        public string ResumeFileName { get; set; }
    }

}
