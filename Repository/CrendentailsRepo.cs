using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elearn_StaffJWT.Repository
{
    public class CrendentailsRepo:ICredentialsRepo
    {
        private Dictionary<string, string> ValidUsersDictionary = new Dictionary<string, string>()
        {
                {"user1","pass1"},
               {"user2","pass2"},
        };
        public Dictionary<string, string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
