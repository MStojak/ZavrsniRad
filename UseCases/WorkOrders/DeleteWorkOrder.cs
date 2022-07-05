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
    public class DeleteWorkOrder : IDeleteWorkOrder
    {
        IWorkOrderRepository workOrderRepository;

        public DeleteWorkOrder(IWorkOrderRepository workOrderRepository)
        {
            this.workOrderRepository = workOrderRepository;
        }

        public void Execute(int id)
        {
            workOrderRepository.Delete(id);
        }
    }
}
