using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAllByCatgeory(int id);
        Task<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
    }
}
