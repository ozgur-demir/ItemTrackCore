using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class Item:BaseEntity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ShortDesc { get; set; }
        public string WebJson { get; set; }
        public string Tag { get; set; }
        public int UserId { get; set; }
        public ICollection<ItemDetail> Details { get; set; }
        public ICollection<ItemCategory> Categories { get; set; }
        public User User { get; set; }

    }
}
