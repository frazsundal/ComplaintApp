using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintApp.Models
{
    public class AuthService : IAuthService
    {
        AuthContext _context;
        public AuthService(AuthContext context) => _context = context;
        public AuthResponseModel UserAuthenticate(AuthModel login)
        {
            return _context.UserAuthenticate(login);
        }
    }
}
