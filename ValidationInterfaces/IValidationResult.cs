using System.Collections.Generic;

namespace ProductsManagement.Domain.ValidationInterfaces
{
    public interface IValidationResult
    {
        object ReturnObject { get; set; }

        bool Valid { get; }
        IList<string> Messages { get; }

        void Add(string message);
        void Remove(string message);
        void IsValid(bool validate);
    }

}