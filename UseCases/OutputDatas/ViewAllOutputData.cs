using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.OutputDatas
{
    public class ViewAllOutputData : IViewAllOutputData
    {
        IOutputDataRepository outputDataRepository;

        public ViewAllOutputData(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }
        public IEnumerable<OutputData> Execute()
        {
            return outputDataRepository.GetAll();
        }
    }
}
