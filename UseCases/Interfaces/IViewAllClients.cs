using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllClients
    {
        IEnumerable<Client> Execute();
    }
}