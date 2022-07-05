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
    public class ViewAllSuppliers : IViewAllSuppliers
    {
        ISupplierRepository supplierRepository;
        public ViewAllSuppliers(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public IEnumerable<Supplier> Execute()
        {
            return supplierRepository.GetAll();
        }
    }
}
