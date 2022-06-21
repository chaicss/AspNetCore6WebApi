using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.Common
{
    public class ResponseData
    {
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string ServerDateTime { get; set; }
    }
}
