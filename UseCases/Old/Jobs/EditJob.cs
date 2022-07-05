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
    public class EditJob : IEditJob
    {
        private IJobRepository taskRepository;

        public EditJob(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void Execute(Job job)
        {
            taskRepository.Update(job);
        }
    }
}
