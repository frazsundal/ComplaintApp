using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public class AuthResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        //Can have status code property. 200 for success, 400 for BadRequest
        //public int StatusCode { get; set; }
    }
    public enum ErrorMessage
    { 
        INVALID_REQUEST = 0,
        INVALID_USERNAME_PASSWORD = 1,
        SUCCESS = 2,
        ERROR = 3
    }
}
