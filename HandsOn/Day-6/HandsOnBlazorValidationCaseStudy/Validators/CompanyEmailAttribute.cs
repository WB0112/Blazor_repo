using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorValidationCaseStudy.Validators
{
    public class CompanyEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value is string email && email.EndsWith("@corp.com"))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Only corporate email (@corp.com) is allowed");
        }
    }
}
