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
    public class EditSupplier : IEditSupplier
    {
        ISupplierRepository supplierRepository;
        public EditSupplier(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public void Execute(Supplier supplier)
        {
            supplierRepository.Update(supplier);
        }
    }
}
