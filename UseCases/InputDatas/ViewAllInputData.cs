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
    public class ViewAllInputData : IViewAllInputData
    {
        IInputDataRepository bringInJobRepository;

        public ViewAllInputData(IInputDataRepository bringInJobRepository)
        {
            this.bringInJobRepository = bringInJobRepository;
        }

        public IEnumerable<InputData> Execute()
        {
            return bringInJobRepository.GetAll();
        }
    }
}
