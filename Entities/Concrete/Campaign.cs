using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripttion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PhotoPath { get; set; }
        public bool WeeklyStatus { get; set; }
    }
}
