using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IEditWorkOrder
    {
        void Execute(WorkOrder workOrder);
    }
}