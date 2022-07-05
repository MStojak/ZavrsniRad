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
    public class DeleteAssignment : IDeleteAssignment
    {
        private IAssignmentRepository assignmentRepository;
        public DeleteAssignment(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }
        public void Execute(int id)
        {
            assignmentRepository.Delete(id);
        }
    }
}
