using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}