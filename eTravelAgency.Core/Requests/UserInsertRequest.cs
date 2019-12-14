using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class UserInsertRequest
    {
   //     [Required(AllowEmptyStrings =false)]
        public string FirstName { get; set; }
     //   [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
      // [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }
      //[Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
       // [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$")]
        public string Password { get; set; }
     // [Required(AllowEmptyStrings =false)]
        public string PasswordConfirmation { get; set; }
        public string Phone { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<int> Roles { get; set; }
    }
}
