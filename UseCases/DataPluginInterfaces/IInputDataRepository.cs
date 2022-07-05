using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface IInputDataRepository
    {
        void Add(InputData bringInJob);

        void Delete(int bringInJobId);

        void Update(InputData bringInJob);

        IEnumerable<InputData> GetAll();
        InputData GetById(int bringInJobId);
    }
}
