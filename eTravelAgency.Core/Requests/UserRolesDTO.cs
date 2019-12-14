using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class UserRolesDTO
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public RoleDTO Role { get; set; }
    }
}
