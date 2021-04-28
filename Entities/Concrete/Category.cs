using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string IconPath { get; set; }
        public string AdvertisingPhotoPath { get; set; }
        public virtual MainCategory MainCategory { get; set; }
        public int MainCategoryId { get; set; }
        public virtual List<Subcategory> Subcategories { get; set; }
    }
}
