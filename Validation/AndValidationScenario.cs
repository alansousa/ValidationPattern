using System.Linq;
using ProductsManagement.Domain.ValidationInterfaces;

namespace ProductsManagement.Domain.Validation
{
    public abstract class AndValidationScenario : ValidationScenario
        , IValidationScenario
    {
        public override IValidationResult Validate()
        {
            if (Specification.Any())
            {
                var specification = Specification.Where(x => !x.IsValid()).ToList();

                foreach (var item in specification)
                    ValidationResult.Add(item.Message);
            }

            return ValidationResult;
        }
    }
}