using System.ComponentModel.DataAnnotations;

namespace API.Models.Validation
{
    public class RaValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Console.WriteLine(value + "Sendo validado");
            if (value == null || !value.ToString().StartsWith("RA") || value.ToString().Length != 8)
            {
                Console.WriteLine(" Não é válido " + value);
                return new ValidationResult("RA inválido");
            }

            for (int i = 2; i < 8; i++)
            {
                char digit = value.ToString()[i];
                if (!Char.IsDigit(digit))
                {
                    return new ValidationResult("RA inválido");
                }
            }

            return ValidationResult.Success;
        }
    }
}
