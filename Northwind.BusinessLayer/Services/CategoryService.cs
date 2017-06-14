using Northwind.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.BusinessEntities.DTO;

namespace Northwind.BusinessLayer.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork unit;

        public CategoryService(  IUnitOfWork _unit)
        {
            unit = _unit;
        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            return  unit.categoryRepository.GetAll();
        }
    }
}
