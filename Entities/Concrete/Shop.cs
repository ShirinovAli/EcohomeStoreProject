using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Shop :IEntity
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string WorkHours { get; set; }
        public string PhoneNumber { get; set; }
    }
}
