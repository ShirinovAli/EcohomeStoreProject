using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Setting :IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public string TitleLogoPath { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string FacebookURL { get; set; }
        public string InstagramURL{ get; set; }
    }
}
