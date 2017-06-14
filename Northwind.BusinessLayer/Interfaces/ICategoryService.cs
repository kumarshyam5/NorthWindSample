using Northwind.BusinessEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.Interfaces
{
   public  interface ICategoryService
    {

        IEnumerable<CategoryDTO> GetAllCategories();
    }
}
