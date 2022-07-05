using CoreBusiness.Old;

namespace UseCases.DataPluginInterfaces
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetAll();
        void Add(Job job);
        void Update(Job job);
        public Job? GetJobById(int id);
        void Delete(int id);
        IEnumerable<Job> GetJobsByCategoryId(int categoryId);
        IEnumerable<Job> GetJobsByCategoryIdAndIsTakenAndIsNotDone(int categoryId, bool isTaken);
    }
}