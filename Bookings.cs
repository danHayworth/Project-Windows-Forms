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

        public Bookings(int id, string type, string name, string surname, string checkin, string checkout, string note) : base(id,type,name,surname)
        {
            this.CheckIn = checkin;
            this.CheckOut = checkout;
            this.Notes = note;
            this.Notes = note;
        }
    }
}
