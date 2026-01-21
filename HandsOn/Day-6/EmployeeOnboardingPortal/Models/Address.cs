using System.ComponentModel.DataAnnotations;
namespace EmployeeOnboardingPortal.Models
{
    public class Address
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }

}
