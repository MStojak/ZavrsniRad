using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllSuppliers
    {
        IEnumerable<Supplier> Execute();
    }
}