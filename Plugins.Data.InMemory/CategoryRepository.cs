using CoreBusiness.Old;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category {Id = 0, Name = "Import", Description = "Import task."},
                new Category {Id = 1, Name = "Export", Description = "Export task."}
            };

        }

        public void Add(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            var id = GetCategoriesMinimalId();
            categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }

        public void Update(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.Id);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return categories;
        }

        //ovdje je moguć null?? Category? -> oznacuje da moze doci do null pointera
        //todo
        public Category? GetCategoryById(int? categoryId)
        {
            return categories?.FirstOrDefault(x => x.Id == categoryId);
        }

        public int GetCategoriesMinimalId()
        {
            var id = -1;
            if (categories.Count != 0)
                id = categories.Min(x => x.Id);
            return id;
        }
    }
}