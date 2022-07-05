using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;
using UseCases.Interfaces;

namespace UseCases.WorkOrders
{
    public class GetWorkOrderById : IGetWorkOrderById
    {
        IWorkOrderRepository workOrderRepository;

        public GetWorkOrderById(IWorkOrderRepository workOrderRepository)
        {
            this.workOrderRepository = workOrderRepository;
        }

        public WorkOrder Execute(int id)
        {
            return workOrderRepository.GetById(id);
        }
    }
}
