using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private List<Assignment> assignments;

        public AssignmentRepository()
        {
            assignments = new List<Assignment>()
            {
                new Assignment { Id = 0, Description = "Silva slikovnica", Format = "35x25", PaperType = "Offsetni", MachineType = "color", BookCover = "kolor", BookCoverPaperType = "Karton", BookCoverPlasticType = "Mat", BookCoverAdditional = "-", BookAdditional = "-", BindingType = "meki uvez" },
                new Assignment { Id = 1, Description = "Odorčić romani", Format = "40x30", PaperType = "Voluminozni", MachineType = "crno-bijeli", BookCover = "kolor", BookCoverPaperType = "Ljepenka", BookCoverPlasticType = "Sjaj", BookCoverAdditional = "-", BookAdditional = "-", BindingType = "meki uvez" }
            };
        }
        public void Add(Assignment assignment)
        {
            assignment.Id = GetMinimalId() + 1;
            assignments.Add(assignment);
        }

        public void Delete(int id)
        {
            assignments?.Remove(GetById(id));
        }

        public IEnumerable<Assignment> GetAll()
        {
            return assignments;
        }

        public Assignment GetById(int id)
        {
            return assignments?.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Assignment assignment)
        {
            var categoryToUpdate = GetById(assignment.Id);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Format= assignment.Format;
                categoryToUpdate.PaperType = assignment.PaperType;
                categoryToUpdate.MachineType = assignment.MachineType;
                categoryToUpdate.Description = assignment.Description;
                categoryToUpdate.BookCover = assignment.BookCover;
                categoryToUpdate.BookCoverPaperType = assignment.BookCoverPaperType;
                categoryToUpdate.BookCoverPlasticType = assignment.BookCoverPlasticType;
                categoryToUpdate.BookCoverAdditional = assignment.BookCoverAdditional;
                categoryToUpdate.BookAdditional = assignment.BookAdditional;
                categoryToUpdate.BindingType = assignment.BindingType;
            }
        }

        private int GetMinimalId()
        {
            var id = -1;
            if (assignments.Count != 0)
                id = assignments.Max(x => x.Id);
            return id == -1 ? 0:id;
        }
    }
}
