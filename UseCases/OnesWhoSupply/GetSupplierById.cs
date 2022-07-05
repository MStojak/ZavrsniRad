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
    public class GetSupplierById : IGetSupplierById
    {
        ISupplierRepository supplierRepository;
        public GetSupplierById(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
        public Supplier Execute(int supplierId)
        {
            return supplierRepository.GetSupplierById(supplierId);
        }
    }
}
