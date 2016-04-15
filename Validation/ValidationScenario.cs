using System.Collections.Generic;
using System.Linq;
using ProductsManagement.Domain.ValidationInterfaces;

namespace ProductsManagement.Domain.Validation
{
    public abstract class ValidationScenario
    {
        protected readonly IValidationResult ValidationResult;
        private readonly IList<ISpecification> _specifications;

        public IList<ISpecification> Specification
        {
            get { return _specifications; } 
        }

        protected ValidationScenario()
        {
            _specifications = new List<ISpecification>();
            ValidationResult = new ValidationResult();
        }

        public virtual void AddRule(ISpecification specification)
        {
            _specifications.Add(specification);
        }

        public virtual void RemoveRule(ISpecification specification)
        {
            if(_specifications.Any())
                _specifications.Remove(specification);
        }

        public virtual IValidationResult Validate()
        {
            foreach (var specification in _specifications)
            {
                if(specification.IsValid()) continue;

                ValidationResult.Add(specification.Message);
            }

            return ValidationResult;
        }
    }
}