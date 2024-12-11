using ShopApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface IProductsDb
    {
        List<CustomerModel> GetCustomers();
        CustomerModel GetCustomer(int CustomerId);
        void SaveCustomer(CustomerAddModel customerAdd);
        void UpdateCustomer(CustomerUpdateModel customerUpdate);
        void RemoveCustomer(CustomerRemoveModel customerRemove);
    }
}
