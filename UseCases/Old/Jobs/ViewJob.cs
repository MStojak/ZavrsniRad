using CoreBusiness.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Jobs
{
    public class ViewJob : IViewJob
    {
        private IJobRepository taskRepository;

        public ViewJob(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<Job> Execute()
        {
            return taskRepository.GetAll();
        }
    }

}
