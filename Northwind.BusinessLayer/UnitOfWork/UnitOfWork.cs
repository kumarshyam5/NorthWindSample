using Northwind.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.BusinessLayer.Repository;
using Northwind.BusinessEntities.Models;

namespace Northwind.BusinessLayer.UnitOfWork
{
   public  class UnitOfWork : IUnitOfWork
    {
        private CategoryRepository _categoryRepository;
        private NorthwindDbContext _context = null;


        public UnitOfWork()
        {
            _context = new NorthwindDbContext();
        }

        public CategoryRepository categoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    return _categoryRepository = new CategoryRepository(_context);

                return _categoryRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
