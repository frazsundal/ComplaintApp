using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public class AuthContext
    {
        public AuthResponseModel UserAuthenticate(AuthModel login) {
            if (login.Email.Equals("frazms@hotmail.com"))
                return new AuthResponseModel { Message = ErrorMessage.SUCCESS.ToString(), Status = true };
            else
                return new AuthResponseModel { Message = ErrorMessage.INVALID_USERNAME_PASSWORD.ToString(), Status = false };
        }
    }
}
