using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class ItemKey:BaseEntity
    {
        public enum KeyType
        {
            Default = 0,
            QR =1,
            Barcode=2
        }
        public int ItemId { get; set; }
        public string IdentityKey { get; set; }
        public KeyType Type { get; set; } = KeyType.Default;
        public DateTime VerifyDate { get; set; }
        public Item Item { get; set; }

    }
}
