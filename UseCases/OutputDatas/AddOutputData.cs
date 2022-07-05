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
    public class AddOutputData : IAddOutputData
    {
        IOutputDataRepository outputDataRepository;

        public AddOutputData(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }

        public void Execute(OutputData outputData)
        {
            outputDataRepository.Add(outputData);
        }
    }
}
