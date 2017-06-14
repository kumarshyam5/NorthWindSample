using Northwind.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.BusinessEntities.DTO;
using Northwind.BusinessEntities.Models;

namespace Northwind.BusinessLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private NorthwindDbContext context;
        public CategoryRepository(  NorthwindDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            var categories= context.Categories.ToList();
            return AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(categories);
        }
    }
}
