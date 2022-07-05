using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> GetAll();
        void Add(Assignment assignment);
        Assignment GetById(int id);
        void Update(Assignment assignment);
        void Delete(int id);
    }
}
