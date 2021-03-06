using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductPhotoDal : IEntityRepository<ProductPhoto>
    {
    }
}
