using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Products : BaseEntity
    {
        public int productid { get; set; }
        public string? productname { get; set; }
        public decimal unitprice { get; set; }
        public DateTime creation_date { get; set; }
        public int? creation_user { get; set; }
    }
}
