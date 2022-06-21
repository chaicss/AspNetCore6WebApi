using AspNetCore6WebApi.business.Managers.Interfaces;
using AspNetCore6WebApi.Common;
using AspNetCore6WebApi.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.business.Managers.Implementations
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerDataAccess _CustomerDataAccess;
        private readonly ResponseData res = new ResponseData();

        public CustomerManager(ICustomerDataAccess customerDataAccess)
        {
            _CustomerDataAccess = customerDataAccess;
        }
        public ResponseData CreateCustomer(Customer customerdata)
        {
            try
            {
                _CustomerDataAccess.CreateCustomer(customerdata);
                res.ResponseCode = "00";
                res.ResponseDescription = "Success";
                res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                return res;
            }
            catch (Exception ex)
            {
                res.ResponseCode = "01";
                res.ResponseDescription = ex.ToString();
                res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                return res;
            }
        }

        public ResponseData DeleteCustomer(int ID)
        {
            try
            {
                if (_CustomerDataAccess.DeleteCustomer(ID) == "00")
                {
                    res.ResponseCode = "00";
                    res.ResponseDescription = "Success";
                    res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    return res;
                }
                else
                {
                    res.ResponseCode = "01";
                    res.ResponseDescription = "Customer ID: " + ID + " Not Found";
                    res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    return res;
                }
            }
            catch (Exception ex)
            {
                res.ResponseCode = "01";
                res.ResponseDescription = ex.ToString();
                res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                return res;
            }
        }

        public List<Customer> GetCustomer()
        {
            return _CustomerDataAccess.GetCustomer();
        }

        public ResponseData UpdateCustomer(Customer customerdata)
        {
            try
            {
                _CustomerDataAccess.UpdateCustomer(customerdata);
                res.ResponseCode = "00";
                res.ResponseDescription = "Success";
                res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                return res;
            }
            catch (Exception ex)
            {
                res.ResponseCode = "01";
                res.ResponseDescription = ex.ToString();
                res.ServerDateTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                return res;
            }
        }
    }
}
