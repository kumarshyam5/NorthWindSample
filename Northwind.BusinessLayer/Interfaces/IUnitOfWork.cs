using Northwind.BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        void Complete();

        CategoryRepository categoryRepository { get; }
    }
}
