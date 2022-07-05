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
    public class AddInputData : IAddInputData
    {
        IInputDataRepository bringInJobRepository;

        public AddInputData(IInputDataRepository bringInJobRepository)
        {
            this.bringInJobRepository = bringInJobRepository;
        }

        public void Execute(InputData inputData)
        {
            bringInJobRepository.Add(inputData);
        }
    }
}
