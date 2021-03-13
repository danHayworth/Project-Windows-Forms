namespace Project
{
    /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */

    // create a class model for the clients that are checking in extending bookings class model
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
