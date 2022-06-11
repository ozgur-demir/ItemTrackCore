using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.DTOs
{
    public class ItemMediaDto : BaseDto
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public string File { get; set; }
        public string Alt { get; set; }
        public int ItemId { get; set; }
    }
}
