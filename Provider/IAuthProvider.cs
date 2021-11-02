using Elearn_StaffJWT.ElearnModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elearn_StaffJWT.Provider
{
    public interface IAuthProvider
    {
        public string GenerateJSONWebToken(staff userInfo, IConfiguration _config);
        public dynamic AuthenticateUser(staff login);
    }
}
