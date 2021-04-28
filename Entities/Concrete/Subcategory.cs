using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Subcategory :IEntity
    {
        public int Id { get; set; }
        public string SubcategoryName { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
