using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IViewCategories
    {
        IEnumerable<Category> Execute();
    }
}