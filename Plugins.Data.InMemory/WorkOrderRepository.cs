using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;

namespace Plugins.Data.InMemory
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        private List<WorkOrder> workOrders;

        public WorkOrderRepository()
        {
            workOrders = new List<WorkOrder>()
            {
                new WorkOrder { Id = 0, ClientId = 0, AssignmentId = 0, BookName = "Ptićica", TotalNumberOfBooks = 200, NumberOfBooksInPackage = 10, DeliveryDate = DateTime.Now, IsDone = false },
                new WorkOrder { Id = 1, ClientId = 1, AssignmentId = 1, BookName = "Book", TotalNumberOfBooks = 50, NumberOfBooksInPackage = 5, DeliveryDate = DateTime.Now, IsDone = false}
            };
        }
        public void Add(WorkOrder workOrder)
        {
            if(workOrders.Any(x => x.BookName.Equals(workOrder.BookName, StringComparison.OrdinalIgnoreCase)))
                return;
            workOrder.Id = GetMinimalId() + 1;
            workOrders.Add(workOrder);
        }

        public void Delete(int id)
        {
            workOrders?.Remove(GetById(id));
        }

        public IEnumerable<WorkOrder> GetAll()
        {
            return workOrders;
        }

        public IEnumerable<WorkOrder> GetAllNotDone()
        {
            return workOrders.Where(x => x.IsDone == false);
        }

        public WorkOrder GetById(int id)
        {
            return workOrders?.FirstOrDefault(x => x.Id == id);
        }

        public void Update(WorkOrder workOrder)
        {
            var workOrderToUpdate = GetById(workOrder.Id);

            if (workOrderToUpdate != null)
            {
                workOrderToUpdate.ClientId = workOrder.ClientId;
                workOrderToUpdate.AssignmentId = workOrder.AssignmentId;
                workOrderToUpdate.BookName = workOrder.BookName;
                workOrderToUpdate.TotalNumberOfBooks = workOrder.TotalNumberOfBooks;
                workOrderToUpdate.NumberOfBooksInPackage = workOrder.NumberOfBooksInPackage;
                workOrderToUpdate.DeliveryDate = workOrder.DeliveryDate;
                workOrderToUpdate.IsDone = workOrder.IsDone;
            }
        }

        private int GetMinimalId()
        {
            var id = -1;
            if (workOrders.Count != 0)
                id = workOrders.Max(x => x.Id);
            return id == -1 ? 0 : id;
        }
    }
}
