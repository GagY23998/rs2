using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgencyMobileApp.Models
{
    public enum MenuItemType
    {
        Offers,
        Countries,
        MyReservations,
        Feeds
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
