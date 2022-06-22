using AspNetCore6WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.DataAccess.DataAccess.Interfaces
{
    public interface ICustomerDataAccess
    {
        List<Customer> GetCustomer();
        Customer CreateCustomer(Customer customerdata);
        Customer UpdateCustomer(Customer customerdata);
        string DeleteCustomer(int Id);
    }
}
