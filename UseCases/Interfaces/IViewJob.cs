using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IViewJob
    {
        IEnumerable<Job> Execute();
    }
}