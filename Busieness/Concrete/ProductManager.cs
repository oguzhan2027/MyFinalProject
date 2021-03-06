﻿using Busieness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concrete
{
    public class ProductManager : IProductService
    {

      IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            // yetki varmı 
            // şöylemi böylemi :)
            return _productDal.GetAll();


        }
    }
}
