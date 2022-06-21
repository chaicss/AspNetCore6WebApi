using AspNetCore6WebApi.Common;
using AspNetCore6WebApi.Models;

namespace AspNetCore6WebApi.Mappers
{
    public static class CustomerMapper
    {
        public static Customer MapToCommon(CustomerModel customerdata)
        {
            if (customerdata == null)
            {
                return null;
            }
            return new Customer
            {
                ID = customerdata.ID,
                FirstName = customerdata.FirstName,
                LastName = customerdata.LastName,
                Email = customerdata.Email,
                Mobile = customerdata.Mobile,
                CreateDate = customerdata.CreateDate,   
                UpdateDate = customerdata.UpdateDate
            };
        }

        public static CustomerModel MapToDto(Customer customerdata)
        {
            if(customerdata == null)
            {
                return null;
            }

            return new CustomerModel
            {
                ID = customerdata.ID,
                FirstName = customerdata.FirstName,
                LastName = customerdata.LastName,
                Email = customerdata.Email,
                Mobile = customerdata.Mobile,
                CreateDate = customerdata.CreateDate,
                UpdateDate = customerdata.UpdateDate
            };
        }
    }
}
