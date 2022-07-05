using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetClientById
    {
        Client? Execute(int id);
    }
}