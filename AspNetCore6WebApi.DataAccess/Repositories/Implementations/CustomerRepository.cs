using AspNetCore6WebApi.Common;
using AspNetCore6WebApi.DataAccess.DatabaseContexts;
using AspNetCore6WebApi.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.DataAccess.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRopository
    {
        private DbCustomerContext _DbCustomerContext;
        public CustomerRepository(DbCustomerContext dbCustomerContext)
        {
            _DbCustomerContext = dbCustomerContext;
        }

        public Customer CreateCustomer(Customer customerdata)
        {
            customerdata.CreateDate = DateTime.Now;
            _DbCustomerContext.CustomerTable.Add(customerdata);
            _DbCustomerContext.SaveChanges();

            return customerdata;
        }

        public string DeleteCustomer(int ID)
        {
            var items = _DbCustomerContext.CustomerTable.Where(item => item.ID == ID);
            if (items.Any())
            {
                _DbCustomerContext.Remove(items.First());
                _DbCustomerContext.SaveChanges();
            }
            else
            {
                return "01";
            }

            return "00";
        }

        public List<Customer> GetCustomer()
        {
            return _DbCustomerContext.CustomerTable.ToList();
        }

        public Customer UpdateCustomer(Customer customerdata)
        {
            var items = _DbCustomerContext.CustomerTable.Where(item => item.ID == customerdata.ID);
            if (items.FirstOrDefault() == null)
            {
                return null;
            }
            var customer = items.FirstOrDefault();
            customer.FirstName = customerdata.FirstName;
            customer.LastName = customerdata.LastName;
            customer.Email = customerdata.Email;
            customer.Mobile = customerdata.Mobile;
            customer.UpdateDate = DateTime.Now;
            _DbCustomerContext.SaveChanges();

            return customer;
        }
    }
}
