using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IGetJobById
    {
        Job? Execute(int jobId);
    }
}