using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplaintApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplaintApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _IAuth;
        public AuthController(IAuthService IAuth) => _IAuth = IAuth;
        // POST: api/Auth
        [HttpPost]
        public AuthResponseModel Post([FromBody] AuthModel model)
        {
            if (model == null)
                return new AuthResponseModel { Message = ErrorMessage.INVALID_REQUEST.ToString(), Status = false };

            return _IAuth.UserAuthenticate(model);
        }
    }
}
