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
    public class DeleteOutputData : IDeleteOutputData
    {
        IOutputDataRepository outputDataRepository;

        public DeleteOutputData(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }

        public void Execute(int id)
        {
            outputDataRepository.Delete(id);
        }
    }
}
