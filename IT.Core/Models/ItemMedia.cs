using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class ItemMedia:BaseEntity
    {
        public enum MediaType
        {
            Image=0,
            Video=1,
            Audio=2,
            Document =3
        }
        public string Name { get; set; }
        public MediaType Type { get; set; }
        public string File { get; set; }
        public string Alt { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

    }
}
