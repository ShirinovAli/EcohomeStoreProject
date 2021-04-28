using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager :IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productDal.GetAll();
        }

        public async Task<List<Product>> GetAllByCatgeory(int id)
        {
            return await _productDal.GetAll(p => p.SubcategoryId == id);
        }

        public async Task<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return await _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
