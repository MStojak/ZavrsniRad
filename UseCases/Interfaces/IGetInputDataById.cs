using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetInputDataById
    {
        InputData Execute(int bringInJobId);
    }
}