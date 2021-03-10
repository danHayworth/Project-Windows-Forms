using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Bookings: Clients
    { 
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Notes { get; set; }

        public Bookings(string name, string surname, int phone, string checkin, string checkout, string note) : base(name,surname,phone)
        {
            this.CheckIn = checkin;
            this.CheckOut = checkout;
            this.Notes = note;
        }
    }
}
