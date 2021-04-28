﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand :IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string LogoPath { get; set; }
        public virtual List<Model> Models { get; set; }
    }
}
