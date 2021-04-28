using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class ProductPhoto :IEntity
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
