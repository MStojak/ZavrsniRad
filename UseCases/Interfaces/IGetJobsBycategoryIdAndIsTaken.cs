using CoreBusiness.Old;

namespace UseCases.Interfaces
{
    public interface IGetJobsBycategoryIdAndIsTaken
    {
        IEnumerable<Job> Execute(int categoryId, bool isTaken);
    }
}