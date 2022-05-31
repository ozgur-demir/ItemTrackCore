using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Core.Models
{
    public class User:BaseEntity
    {
        public enum UserType
        {
            Manager=0,
            Admin =1
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public UserType Type { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
