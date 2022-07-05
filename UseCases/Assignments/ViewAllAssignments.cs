using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using CoreBusiness;
using UseCases.Interfaces;

namespace UseCases.Assignments
{
    public class ViewAllAssignments : IViewAllAssignments
    {
        private IAssignmentRepository assignmentRepository;
        public ViewAllAssignments(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }
        public IEnumerable<Assignment> Execute()
        {
            return assignmentRepository.GetAll();
        }
    }
}
