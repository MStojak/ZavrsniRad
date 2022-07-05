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
    public class AddWorkOrder : IAddWorkOrder
    {
        IWorkOrderRepository workOrderRepository;

        public AddWorkOrder(IWorkOrderRepository workOrderRepository)
        {
            this.workOrderRepository = workOrderRepository;
        }

        public void Execute(WorkOrder workOrder)
        {
            workOrderRepository.Add(workOrder);
        }
    }
}
