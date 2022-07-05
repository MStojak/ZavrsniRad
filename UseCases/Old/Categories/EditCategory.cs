using CoreBusiness.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Categories
{
    public class EditCategory : IEditCategory
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
