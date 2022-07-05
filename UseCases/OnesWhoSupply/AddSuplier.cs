using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;
using UseCases.Interfaces;

namespace UseCases.OnesWhoSupply
{
    public class AddSupplier : IAddSuplier
    {
        ISupplierRepository supplierRepository;
        public AddSupplier(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public void Execute(Supplier supplier)
        {
            supplierRepository.Add(supplier);
        }
    }
}
