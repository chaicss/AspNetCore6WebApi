using AspNetCore6WebApi.business.Managers.Interfaces;
using AspNetCore6WebApi.Mappers;
using AspNetCore6WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerManager _CustomerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _CustomerManager = customerManager;
        }

        [HttpGet]
        public ObjectResult GetCustomer()
        {
            return Ok(_CustomerManager.GetCustomer());
        }

        [HttpPost]
        public ObjectResult CreateCustomer(CustomerModel customerdata)
        {
            var cus = CustomerMapper.MapToCommon(customerdata);
            var result = _CustomerManager.CreateCustomer(cus);
            return Ok(result);
        }

        [HttpPatch]
        public ObjectResult UpdateCustomer(CustomerModel customerdata)
        {
            var cus = CustomerMapper.MapToCommon(customerdata);
            var result = _CustomerManager.UpdateCustomer(cus);
            return Ok(result);
        }

        [HttpDelete]
        public ObjectResult DeleteCustomer(int ID)
        {
            return Ok(_CustomerManager.DeleteCustomer(ID));
        }
    }
}
