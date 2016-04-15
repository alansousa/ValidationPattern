using System.Collections.Generic;
using System.Linq;
using ProductsManagement.Domain.ValidationInterfaces;

namespace ProductsManagement.Domain.Validation
{
    public class ValidationResult : IValidationResult
    {
        protected bool _valid;
        private readonly IList<string> _messages;

        public object ReturnObject { get; set; }

        public ValidationResult()
        {
            _messages = new List<string>();
            _valid = true;
        }
        
        public bool Valid
        {
            get { return _valid; }
        }

        public IList<string> Messages
        {
            get { return _messages; }
        }

        public void Add(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
                _messages.Add(message);

            if (_messages.Any())
                IsValid(false);
        }

        public void Remove(string message)
        {
            if (!string.IsNullOrWhiteSpace(message) && _messages.Any())
                _messages.Remove(message);

            if (!_messages.Any())
                IsValid(true);
        }

        public void IsValid(bool validate)
        {
            _valid = validate;
        }
    }
}
