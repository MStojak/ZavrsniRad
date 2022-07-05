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
    public class EditAssignment : IEditAssignment
    {
        private IAssignmentRepository assignmentRepository;
        public EditAssignment(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }
        public void Execute(Assignment assignment)
        {
            assignmentRepository.Update(assignment);
        }
    }
}
