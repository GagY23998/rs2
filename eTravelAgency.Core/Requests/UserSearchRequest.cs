using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class UserSearchRequest
    {
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
    }
}
