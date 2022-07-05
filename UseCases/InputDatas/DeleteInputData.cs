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
    public class DeleteInputData : IDeleteInputData
    {
        IInputDataRepository bringInJobRepository;

        public DeleteInputData(IInputDataRepository bringInJobRepository)
        {
            this.bringInJobRepository = bringInJobRepository;
        }

        public void Execute(int bringInJobId)
        {
            bringInJobRepository.Delete(bringInJobId);
        }
    }
}
