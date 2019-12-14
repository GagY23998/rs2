using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Interfaces
{
    public interface IRoleService : ICRUDService<Role,RoleDTO,RoleInsertRequest,RoleInsertRequest,RoleInsertRequest>
    {
    }
}
