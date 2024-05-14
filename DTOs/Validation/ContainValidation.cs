using System.ComponentModel.DataAnnotations;

namespace Validation
{
    public class ContainValidationAttribute :ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string val = value.ToString();
            if (val.Contains("@"))
            {
               return ValidationResult.Success;
            }
            else
            {

                return new ValidationResult("Should Contain @");
            }
        }
    }
}
