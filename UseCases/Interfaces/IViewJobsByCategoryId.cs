using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IViewJobsByCategoryId
    {
        IEnumerable<Job> Execute(int categoryId);
    }
}