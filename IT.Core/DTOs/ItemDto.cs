using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.DTOs
{
    public class ItemDto : BaseDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ShortDesc { get; set; }
        public string WebJson { get; set; }
        public string Tag { get; set; }
        public int UserId { get; set; }
    }
}
