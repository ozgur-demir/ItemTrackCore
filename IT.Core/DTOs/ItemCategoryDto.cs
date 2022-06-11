using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.DTOs
{
    public class ItemCategoryDto : BaseDto
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
    }
}
