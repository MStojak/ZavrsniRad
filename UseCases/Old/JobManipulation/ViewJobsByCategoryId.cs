using CoreBusiness.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.JobManipulation
{
    public class ViewJobsByCategoryId : IViewJobsByCategoryId
    {
        private IJobRepository taskRepository;

        public ViewJobsByCategoryId(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<Job> Execute(int categoryId)
        {
            return taskRepository.GetJobsByCategoryId(categoryId);
        }
    }
}
