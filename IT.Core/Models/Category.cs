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
        public int Top { get; set; } = 0;
        public int Index { get; set; } = 0;
        public bool Listing { get; set; } = true;
    }
}
