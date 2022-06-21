using AspNetCore6WebApi.Common;
using AspNetCore6WebApi.DataAccess.DataAccess.Interfaces;
using AspNetCore6WebApi.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.DataAccess.DataAccess.Implementations
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        private ICustomerRopository _CustomerRopository;

        public CustomerDataAccess(ICustomerRopository customerRopository)
        {
            _CustomerRopository = customerRopository;
        }
        public Customer CreateCustomer(Customer customerdata)
        {
            return _CustomerRopository.CreateCustomer(customerdata);
        }

        public string DeleteCustomer(int ID)
        {
            return _CustomerRopository.DeleteCustomer(ID);
        }

        public List<Customer> GetCustomer()
        {
            return _CustomerRopository.GetCustomer();
        }

        public Customer UpdateCustomer(Customer customerdata)
        {
            return _CustomerRopository.UpdateCustomer(customerdata);
        }
    }
}
