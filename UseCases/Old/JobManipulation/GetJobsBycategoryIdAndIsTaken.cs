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
    public class GetJobsByCategoryIdAndIsTaken : IGetJobsBycategoryIdAndIsTaken
    {
        private IJobRepository taskRepository;

        public GetJobsByCategoryIdAndIsTaken(IJobRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<Job> Execute(int categoryId, bool isTaken)
        {
            return taskRepository.GetJobsByCategoryIdAndIsTakenAndIsNotDone(categoryId, isTaken);
        }
    }
}
