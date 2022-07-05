using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Categories
{
    public class GetCategoriesMinimalId : IGetCategoriesMinimalId
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoriesMinimalId(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public int Execute()
        {
            return categoryRepository.GetCategoriesMinimalId();
        }
    }
}
