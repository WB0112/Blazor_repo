using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorFormValidations.Models
{
    public class EmployeeModel
    {
        [Required]
        public string Name { get; set; }

        [CorporateEmail]
        public string Email { get; set; }
    }

}
