using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetSupplierById
    {
        Supplier Execute(int supplierId);
    }
}