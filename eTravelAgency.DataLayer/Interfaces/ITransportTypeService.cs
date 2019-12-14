using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Interfaces
{
    public interface ITransportTypeService:
        ICRUDService<TransportType,TransportTypeDTO,TransportTypeInsertRequest,TransportTypeInsertRequest,TransportTypeSearchRequest>
    {
    }
}
