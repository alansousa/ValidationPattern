using System;

namespace ProductsManagement.Domain.Validation
{
    public class ExceptionResult : ValidationResult
    {
        public ExceptionResult(Exception ex)
        {
            Add(ex.Message);
            _valid = false;
        }

        public ExceptionResult(NullReferenceException ex)
        {
            Add(ex.Message);
            _valid = false;
        }

        public ExceptionResult(string ex)
        {
            Add(ex);
            _valid = false;
        }
    }
}