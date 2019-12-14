using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RoomTypeInsertRequest
    {
        [RegularExpression(".[^!@#$%^&*(),.?\":{}|<>]{4,20}")]
        public string RoomTypeName { get; set; }
        [RegularExpression(".[^!@#$%^&*(),.?\":{}|<>]{4,20}")]
        public string RoomDetails { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
