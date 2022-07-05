using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewAllInputData
    {
        IEnumerable<InputData> Execute();
    }
}