using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CheckingIn: Bookings
    {
        public string CabinType { get; set; }
        public int CabinNumber { get; set; }

        public CheckingIn(int id, string type, string name, string surname, string checkin, string checkout, string note, string cabintype, int cabNumber): base(id, type, name, surname, checkin, checkout, note)
        {
            this.CabinNumber = cabNumber;
            this.CabinType = cabintype;
        }
    }
}
