using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IAddWorkOrder
    {
        void Execute(WorkOrder workOrder);
    }
}