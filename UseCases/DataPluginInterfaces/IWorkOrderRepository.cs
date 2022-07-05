using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface IWorkOrderRepository
    {
        IEnumerable<WorkOrder> GetAll();
        WorkOrder GetById(int id);
        void Update(WorkOrder workOrder);
        void Add(WorkOrder workOrder);
        void Delete(int id);
        IEnumerable<WorkOrder> GetAllNotDone();
    }
}
