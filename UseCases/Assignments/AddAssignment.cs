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
    public class AddAssignment : IAddAssignment
    {
        private IAssignmentRepository assignmentRepository;
        public AddAssignment(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }
        public void Execute(Assignment assignment)
        {
            assignmentRepository.Add(assignment);
        }
    }
}
