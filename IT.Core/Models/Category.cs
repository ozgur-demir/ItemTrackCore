using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int Top { get; set; }
        public int Index { get; set; }
        public bool Listing { get; set; }
    }
}
