using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public interface IAuthService
    {
        AuthResponseModel UserAuthenticate(AuthModel login);
    }
}
