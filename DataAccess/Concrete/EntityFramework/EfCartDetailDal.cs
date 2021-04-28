using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.DbContext;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDetailDal : EfEntityRepositoryBase<CartDetail, EcoDbContext>, ICartDetailDal
    {
    }
}
