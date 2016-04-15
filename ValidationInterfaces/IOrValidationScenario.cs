using System.Collections.Generic;

namespace ProductsManagement.Domain.ValidationInterfaces
{
    public interface IOrValidationScenario
    {
        void AddRule(List<ISpecification> specification);
        void RemoveRule(List<ISpecification> specification);
        IValidationResult Validate();
    }
}