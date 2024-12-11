using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Daos
{
    public class CustomerDb : IProductsDb
    {
        private readonly ShopContext context;

        public CustomerDb(ShopContext context)
        {
            this.context = context;
        }
        public CustomerModel GetCustomer(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public List<CustomerModel> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(CustomerRemoveModel customerRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveCustomer(CustomerAddModel customerAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerUpdateModel customerUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
