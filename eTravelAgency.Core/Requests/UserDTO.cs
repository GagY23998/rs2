using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using eTravelAgency.Core.Models;

namespace eTravelAgency.Core.Requests
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<UserRolesDTO> UserRoles { get; set; }
    }
}
