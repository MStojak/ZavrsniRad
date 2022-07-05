using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllNotDoneWorkOrders
    {
        IEnumerable<WorkOrder> Execute();
    }
}