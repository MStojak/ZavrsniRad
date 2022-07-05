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
    public class EditOutputData : IEditOutputData
    {
        IOutputDataRepository outputDataRepository;

        public EditOutputData(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }

        public void Execute(OutputData outputData)
        {
            outputDataRepository.Update(outputData);
        }
    }
}
