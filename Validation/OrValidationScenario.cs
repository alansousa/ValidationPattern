using System.Collections.Generic;
using System.Linq;
using ProductsManagement.Domain.ValidationInterfaces;

namespace ProductsManagement.Domain.Validation
{
    public class OrValidationScenario : ValidationScenario
        , IOrValidationScenario, IValidationScenario
    {
        public List<List<ISpecification>> SpecificationList { get; private set; }

        protected OrValidationScenario()
        {
            SpecificationList = new List<List<ISpecification>>();
        }

        public void AddRule(List<ISpecification> specifications)
        {
            SpecificationList.Add(specifications);
        }

        public void RemoveRule(List<ISpecification> specifications)
        {
            SpecificationList.Add(specifications);
        }

        public override IValidationResult Validate()
        {
            if (SpecificationList.Any())
            {
                foreach (var orSpecification in SpecificationList)
                {
                    if (orSpecification.Any())
                    {
                        var specification = orSpecification.Where(x => !x.IsValid()).ToList();

                        if (!specification.Any()) return new ValidationResult();

                        foreach (var item in specification)
                            ValidationResult.Add(item.Message);
                    }
                }
            }

            return ValidationResult;
        }
    }
}