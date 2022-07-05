using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.WorkOrders
{
    public class ViewAllNotDoneWorkOrders : IViewAllNotDoneWorkOrders
    {
        IWorkOrderRepository workOrderRepository;

        public ViewAllNotDoneWorkOrders(IWorkOrderRepository workOrderRepository)
        {
            this.workOrderRepository = workOrderRepository;
        }

        public IEnumerable<WorkOrder> Execute()
        {
            return workOrderRepository.GetAllNotDone();
        }
    }
}
