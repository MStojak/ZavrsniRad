using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Categories
{
    public class DeleteCategory : IDeleteCategory
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(int categoryId)
        {
            categoryRepository.Delete(categoryId);
        }
    }
}
