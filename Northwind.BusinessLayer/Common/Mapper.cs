using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.BusinessEntities.Models;
using Northwind.BusinessEntities.DTO;

namespace Northwind.BusinessLayer.Common
{
    public static class Mapper
    {

        public static void Register()
        {
            AutoMapper.Configuration.MapperConfigurationExpression config = new AutoMapper.Configuration.MapperConfigurationExpression();
            config.CreateMap<Category, CategoryDTO>();
            config.CreateMap<Product, ProductDTO>();
            AutoMapper.Mapper.Initialize(config);

        }
    }
}
