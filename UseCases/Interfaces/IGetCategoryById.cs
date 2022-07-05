using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IGetCategoryById
    {
        Category Execute(int categoryId);
    }
}