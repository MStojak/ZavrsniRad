using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetAssignmentById
    {
        Assignment Execute(int id);
    }
}