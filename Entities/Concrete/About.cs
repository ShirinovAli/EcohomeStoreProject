using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class About :IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string MainText { get; set; }

    }
}
