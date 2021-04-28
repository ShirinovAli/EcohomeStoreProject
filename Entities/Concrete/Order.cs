using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
