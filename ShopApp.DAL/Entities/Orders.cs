using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Orders : BaseEntity
    {
        public int orderid { get; set; }
        public string? shipname { get; set; }
        public decimal freight { get; set; }
        public int custid { get; set; }
    }
}
