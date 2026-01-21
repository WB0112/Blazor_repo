using System.ComponentModel.DataAnnotations;
namespace HandsOnBlazorFormValidations
{
  

    public class CorporateEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value is string email && email.EndsWith("@corp.com"))
                return ValidationResult.Success;

            return new ValidationResult("Only corporate emails allowed");
        }
    }

}
