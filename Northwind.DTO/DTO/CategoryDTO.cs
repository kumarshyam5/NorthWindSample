using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DTO.DTO
{
   public  class CategoryDTO
    {
       
        public CategoryDTO()
        {
            Products = new HashSet<ProductDTO>();
        }

        public int CategoryID { get; set; }

       
        public string CategoryName { get; set; }

      
        public string Description { get; set; }

       
        public byte[] Picture { get; set; }

      
        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
