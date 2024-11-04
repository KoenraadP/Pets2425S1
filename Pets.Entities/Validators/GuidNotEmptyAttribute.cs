using System;
using System.ComponentModel.DataAnnotations;

namespace Pets.Entities.Validators
{
    public class GuidNotEmptyAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is Guid guid && guid == Guid.Empty)
            {
                return new ValidationResult(ErrorMessage ?? "The Guid cannot be empty.");
            }

            return ValidationResult.Success;
        }
    }
}