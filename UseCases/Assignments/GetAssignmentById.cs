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
    public class GetAssignmentById : IGetAssignmentById
    {
        private IAssignmentRepository assignmentRepository;
        public GetAssignmentById(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }
        public Assignment Execute(int id)
        {
            return assignmentRepository.GetById(id);
        }


    }
}
