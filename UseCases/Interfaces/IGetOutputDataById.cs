using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetOutputDataById
    {
        OutputData Execute(int id);
    }
}