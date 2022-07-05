using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface IOutputDataRepository
    {
        void Add(OutputData outputData);
        void Delete(int id);
        void Update(OutputData outputData);
        IEnumerable<OutputData> GetAll();
        OutputData GetById(int id);
        IEnumerable<OutputData> GetAllNotDone();
    }
}
