using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllWorkOrders
    {
        IEnumerable<WorkOrder> Execute();
    }
}