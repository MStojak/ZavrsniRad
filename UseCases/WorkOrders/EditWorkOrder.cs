using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.WorkOrders
{
    public class EditWorkOrder : IEditWorkOrder
    {
        IWorkOrderRepository workOrderRepository;

        public EditWorkOrder(IWorkOrderRepository workOrderRepository)
        {
            this.workOrderRepository = workOrderRepository;
        }

        public void Execute(WorkOrder workOrder)
        {
            workOrderRepository.Update(workOrder);
        }
    }
}
