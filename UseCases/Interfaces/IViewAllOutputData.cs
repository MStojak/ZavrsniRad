using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllOutputData
    {
        IEnumerable<OutputData> Execute();
    }
}