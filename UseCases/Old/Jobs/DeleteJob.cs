using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Jobs
{
    public class DeleteJob : IDeleteJob
    {
        private IJobRepository taskRepository;

        public DeleteJob(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void Execute(int id)
        {
            taskRepository.Delete(id);
        }
    }
}
