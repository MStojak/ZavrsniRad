using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetWorkOrderById
    {
        WorkOrder Execute(int id);
    }
}