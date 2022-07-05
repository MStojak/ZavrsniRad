using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.OnesWhoSupply
{
    public class DeleteSupplier : IDeleteSupplier
    {
        ISupplierRepository supplierRepository;
        public DeleteSupplier(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public void Execute(int supplierId)
        {
            supplierRepository.Delete(supplierId);
        }
    }
}
