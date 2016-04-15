namespace ProductsManagement.Domain.ValidationInterfaces
{
    public interface IValidationScenario
    {
        void AddRule(ISpecification specification);
        void RemoveRule(ISpecification specification);
        IValidationResult Validate();
    }
}