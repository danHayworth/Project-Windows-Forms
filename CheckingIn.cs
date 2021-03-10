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
        public string IdType { get; set; }
        public string IdNumber { get; set; }

        public CheckingIn(string id, string type, string name, string surname,int phone, string checkin, string checkout, string note, string cabintype, int cabNumber): base(name, surname,phone,checkin,checkout, note)
        {
            this.CabinNumber = cabNumber;
            this.CabinType = cabintype;
            this.IdType = type;
            this.IdNumber = id;
        }
    }
}
