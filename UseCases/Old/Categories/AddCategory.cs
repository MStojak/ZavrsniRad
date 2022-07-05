using CoreBusiness.Old;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.Categories
{
    public class AddCategory : IAddCategory
    {
        ICategoryRepository categoryRepository;
        public AddCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.Add(category);
        }
    }
}