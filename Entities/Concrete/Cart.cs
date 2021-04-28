using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Cart :IEntity
    {
        public int CartId { get; set; }
        public DateTime AdditionalDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual List<CartDetail> CartDetails { get; set; }
    }
}
