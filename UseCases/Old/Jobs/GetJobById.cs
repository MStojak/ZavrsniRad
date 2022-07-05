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
    public class GetJobById : IGetJobById
    {
        private IJobRepository taskRepository;

        public GetJobById(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public Job Execute(int jobId)
        {
            return taskRepository.GetJobById(jobId);
        }
    }
}
