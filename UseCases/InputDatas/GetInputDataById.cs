using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;
using UseCases.Interfaces;

namespace UseCases.BringInJobs
{
    public class GetInputDataById : IGetInputDataById
    {
        IInputDataRepository bringInJobRepository;

        public GetInputDataById(IInputDataRepository bringInJobRepository)
        {
            this.bringInJobRepository = bringInJobRepository;
        }

        public InputData Execute(int bringInJobId)
        {
            return bringInJobRepository.GetById(bringInJobId);
        }
    }
}
