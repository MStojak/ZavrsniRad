using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllAssignments
    {
        IEnumerable<Assignment> Execute();
    }
}