using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Custumers : Person
    {
        public DateTime creation_date { get; set; }
    }
}
