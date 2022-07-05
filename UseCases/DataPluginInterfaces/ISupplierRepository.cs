using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface ISupplierRepository
    {
        void Add(Supplier supplier);
        Supplier GetSupplierById(int supplierId);
        IEnumerable<Supplier> GetAll();
        void Update(Supplier supplier);
        void Delete(int supplierId);
    }
}
