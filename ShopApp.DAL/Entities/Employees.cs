using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Employees : Person
    {
        public DateTime hiredate {  get; set; }
    }
}
