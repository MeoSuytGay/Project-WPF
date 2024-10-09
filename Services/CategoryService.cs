using BussinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public CategoryService() {
            iCategoryRepository = new CategoryRepository();
        
        }
        public List<Category> GetCategories()
        {


            return iCategoryRepository.GetCategories();
        }
    }
}
