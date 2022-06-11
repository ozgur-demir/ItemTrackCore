using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.DTOs
{
    public class ItemKeyDto : BaseDto
    {
        public int ItemId { get; set; }
        public string IdentityKey { get; set; }
        public int Type { get; set; }
        public DateTime VerifyDate { get; set; }
    
    }
}
