using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.OutputDatas
{
    public class GetAllOutputDataNotDone : IGetAllOutputDataNotDone
    {
        IOutputDataRepository outputDataRepository;

        public GetAllOutputDataNotDone(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }
        public IEnumerable<OutputData> Execute()
        {
            return outputDataRepository.GetAllNotDone();
        }
    }
}
