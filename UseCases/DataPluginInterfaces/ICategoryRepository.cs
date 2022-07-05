using CoreBusiness.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataPluginInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        Category? GetCategoryById(int? categoryId);
        void Delete(int categoryId);
        int GetCategoriesMinimalId();
    }
}
