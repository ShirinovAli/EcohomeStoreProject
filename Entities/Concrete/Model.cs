﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Model :IEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public virtual Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}
