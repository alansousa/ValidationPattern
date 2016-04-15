namespace ProductsManagement.Domain.ValidationInterfaces
{
    public interface ISpecification
    {
        string Message { get; }
        bool IsValid();
    }
}