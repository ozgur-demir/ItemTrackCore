using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class ItemDetail:BaseEntity
    {
        public int ItemId { get; set; }
        public int Lang { get; set; }
        public string Json { get; set; }
        public int UserId { get; set; }
        public Item Item { get; set; }
        public User User { get; set; }
    }
}
