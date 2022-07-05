using CoreBusiness;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class OutputDataRepository : IOutputDataRepository
    {
        private List<OutputData> outputData;

        public OutputDataRepository()
        {
            outputData = new List<OutputData>()
            {
                new OutputData() { Id = 0, BookName = "Papirko", ClientId = 0,BookCount = 200 , Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false},
                new OutputData() { Id = 1, BookName = "Papi", ClientId = 2,BookCount = 200 , Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false},
                new OutputData() { Id = 2, BookName = "Okolo nas", ClientId = 1, BookCount = 200 , Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false}
            };
        }
        public void Add(OutputData data)
        {
            if (outputData.Any(x => x.ClientId == data.ClientId && x.BookCount == data.BookCount && x.PackageCount == data.PackageCount))
                return;
            var id = -1;
            if (outputData.Count != 0)
                id = outputData.Max(x => x.Id);
            data.Id = id + 1;
            outputData.Add(data);
        }

        public void Delete(int bringInJobId)
        {
            outputData?.Remove(GetById(bringInJobId));
        }

        public IEnumerable<OutputData> GetAll()
        {
            return outputData;
        }

        public IEnumerable<OutputData> GetAllNotDone()
        {
            return outputData.Where(x => x.IsDone == false);
        }

        public IEnumerable<OutputData> GetAllDone()
        {
            return outputData.Where(x => x.IsDone == true);
        }

        public OutputData? GetById(int bringInJobId)
        {
            return outputData?.FirstOrDefault(x => x.Id == bringInJobId);
        }

        public void Update(OutputData bringInJob)
        {
            var bringInJobToUpdate = GetById(bringInJob.Id);

            if (bringInJobToUpdate != null)
            {
                bringInJobToUpdate.BookName = bringInJob.BookName;
                bringInJobToUpdate.ClientId = bringInJob.ClientId;
                bringInJobToUpdate.Location = bringInJob.Location;
                bringInJobToUpdate.Contact = bringInJob.Contact;
                bringInJobToUpdate.BookCount = bringInJob.BookCount;
                bringInJobToUpdate.Deadline = bringInJob.Deadline;
                bringInJobToUpdate.CertifyDeliveryNote = bringInJob.CertifyDeliveryNote;
                bringInJobToUpdate.IsDone = bringInJob.IsDone;
                bringInJobToUpdate.PackageCount = bringInJob.PackageCount;
            }
        }
    }
}
