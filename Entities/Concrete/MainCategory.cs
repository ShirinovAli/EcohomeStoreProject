using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class MainCategory :IEntity
    {
        public int Id { get; set; }
        public string MainCategoryName { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
