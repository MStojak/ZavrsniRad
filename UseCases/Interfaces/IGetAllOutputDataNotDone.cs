using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetAllOutputDataNotDone
    {
        IEnumerable<OutputData> Execute();
    }
}