using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class SupplierRepository : ISupplierRepository
    {
        private List<Supplier> suppliers;

        public SupplierRepository()
        {
            suppliers = new List<Supplier>()
            {
                new Supplier { Id = 0, Name = "Silvija Šesto", OIB = "00000000001", Mail = "silvija.sesto@gmail.com", MobilePhone = "0910000000", Location = "Zrinjevac" },
                new Supplier { Id = 1, Name = "Zoran Pongrašić", OIB = "00000000002", Mail = "zoran.pongrašić@gmail.com", MobilePhone = "0910000001", Location = "Ivana Brlić Mažuranić 1" },
                new Supplier { Id = 2, Name = "Ljevak", OIB = "00000000003", Mail = "ljevak@gmail.com", MobilePhone = "0910000002", Location = "Prečko 21" }
            };
        }
        public void Add(Supplier supplier)
        {
            if (suppliers.Any(x => x.Name.Equals(supplier.Name, StringComparison.OrdinalIgnoreCase) && x.OIB.Equals(supplier.OIB, StringComparison.OrdinalIgnoreCase)))
                return;
            var id = -1;
            if (suppliers.Count != 0)
                id = suppliers.Max(x => x.Id);
            supplier.Id = id + 1;
            suppliers.Add(supplier);
        }

        public void Delete(int supplierId)
        {
            suppliers?.Remove(GetSupplierById(supplierId));
        }

        public IEnumerable<Supplier> GetAll()
        {
            return suppliers;
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return suppliers?.FirstOrDefault(x => x.Id == supplierId);
        }

        public void Update(Supplier supplier)
        {
            var supplierToUpdate = GetSupplierById(supplier.Id);

            if (supplierToUpdate != null)
            {
                supplierToUpdate.Name = supplier.Name;
                supplierToUpdate.OIB = supplier.OIB;
                supplierToUpdate.Mail = supplier.Mail;
                supplierToUpdate.MobilePhone = supplier.MobilePhone;
                supplierToUpdate.Location = supplier.Location;
            }
        }
    }
}
