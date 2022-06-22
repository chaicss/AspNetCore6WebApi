using AspNetCore6WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.business.Managers.Interfaces
{
    public interface ICustomerManager
    {
        List<Customer> GetCustomer();
        ResponseData CreateCustomer(Customer customerdata);
        ResponseData UpdateCustomer(Customer customerdata);
        ResponseData DeleteCustomer(int Id);
    }
}
