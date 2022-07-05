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
    public class GetOutputDataById : IGetOutputDataById
    {
        IOutputDataRepository outputDataRepository;

        public GetOutputDataById(IOutputDataRepository outputDataRepository)
        {
            this.outputDataRepository = outputDataRepository;
        }

        public OutputData Execute(int id)
        {
            return outputDataRepository.GetById(id);
        }
    }
}
