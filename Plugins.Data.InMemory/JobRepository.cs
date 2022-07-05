using CoreBusiness.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class JobRepository : IJobRepository
    {
        List<Job> jobs;

        public JobRepository()
        {
            this.jobs = new List<Job>();

            this.jobs.Add(new Job
            {
                Id = 0,
                Name = "Job no.1",
                CategoryId = 1,
                Location = "Unska 3",
                Deadline = DateOnly.ParseExact("19.07.2022.", "dd.MM.yyyy."),
                Description = "Odnesi knjige",
                SupplierId = 0,
                IsDone = false,
                IsTaken = false
            });
            this.jobs.Add(new Job
            {
                Id = 1,
                Name = "Job no.2",
                CategoryId = 1,
                Location = "Unska 33",
                Deadline = DateOnly.ParseExact("19.07.2022.", "dd.MM.yyyy."),
                Description = "Donesi papire",
                SupplierId = 2,
                IsDone = false,
                IsTaken = false
            });
        }

        public void Add(Job job)
        {
            if (jobs.Any(x => x.Name.Equals(job.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            var id = -1;
            if (jobs.Count != 0)
                id = jobs.Max(x => x.Id);
            job.Id = id + 1;
            jobs.Add(job);
        }

        public IEnumerable<Job> GetAll()
        {
            return jobs;
        }

        public void Update(Job job)
        {
            var jobToUpdate = GetJobById(job.Id);

            if (jobToUpdate != null)
            {
                jobToUpdate.CategoryId = job.CategoryId;
                jobToUpdate.Name = job.Name;
                jobToUpdate.SupplierId = job.SupplierId;
                jobToUpdate.Deadline = job.Deadline;
                jobToUpdate.Location = job.Location;
                jobToUpdate.Description = job.Description;
                jobToUpdate.IsTaken = job.IsTaken;
                jobToUpdate.IsDone = job.IsDone;
            }
        }

        public Job? GetJobById(int id)
        {
            return jobs.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var job = GetJobById(id);
            if (job != null)
                jobs?.Remove(job);
        }

        public IEnumerable<Job> GetJobsByCategoryId(int categoryId)
        {
            return jobs.Where(x => x.CategoryId == categoryId);
        }

        public IEnumerable<Job> GetJobsByCategoryIdAndIsTakenAndIsNotDone(int categoryId, bool isTaken)
        {
            return jobs.Where(x => x.CategoryId == categoryId && x.IsTaken == isTaken && x.IsDone == false);
        }
    }
}
