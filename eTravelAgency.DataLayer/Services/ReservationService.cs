using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic.Core;

namespace eTravelAgency.DataLayer.Services
{
    public class ReservationService:CRUDService<Reservation,
                                                ReservationDTO,
                                                ReservationInsertRequest,
                                                ReservationInsertRequest,
                                                ReservationSearchRequest>,IReservationService
    {
        public ReservationService(eTravelContext context,IMapper mapper):base(context,mapper)
        {

        }
        public override IEnumerable<ReservationDTO> Get(ReservationSearchRequest request)
        {
            var query = _eTravelContext.Set<Reservation>().AsQueryable();

            query = MyMapper.Map<List<Reservation>>(base.Get(request)).AsQueryable();


            if(request.FromPersons !=0 || request.ToPersons != 0)
            {
                query = query.Where(_ => request.FromPersons <= _.NumberOfPersons && request.ToPersons >= _.NumberOfPersons);
            }

            if(request.FromDate.ToString() != "01-Jan-01 1:00:00 AM" && request.ToDate.ToString() != "01-Jan-01 1:00:00 AM")
            {
                query = query.Where(_ => request.FromDate <= _.DateReserved && request.ToDate >= _.DateReserved);
            }
            if(request.FromPrice !=0 || request.ToPrice != 0)
            {
                query = query.Where(_ => request.FromPrice <= _.TotalPrice && request.ToPrice >= _.TotalPrice);
            }
            if(request.FromDays != 0 || request.ToDays != 0)
            {
                query = query.Where(_ => request.FromDays <= _.NumberOfDays && request.ToDays >= _.NumberOfDays);
            }
           
            
            //query = query.Where(_ => _.Canceled == request.Canceled
            //                    || _.DateReserved == request.DateReserved
            //                    || _.NumberOfPersons == request.NumberOfPersons);
            //                    || (request.FromPrice <= _.TotalPrice && request.ToPrice >= _.TotalPrice)
            //                    || (request.FromDate <= _.DateReserved && request.ToDate >= _.DateReserved)
            //                    || (request.FromPersons <= _.NumberOfPersons && request.ToPersons >= _.NumberOfPersons));
            var result = MyMapper.Map<List<ReservationDTO>>(query.ToList());
            return result;
        }
    }
}
