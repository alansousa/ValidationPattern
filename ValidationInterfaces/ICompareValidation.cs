
namespace ProductsManagement.Domain.ValidationInterfaces
{
    public interface ICompareValidation<TEntity> where TEntity : class
    {
        bool IsEqual(TEntity obj);
    }
}
