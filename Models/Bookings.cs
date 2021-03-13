namespace Project
{
    /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */

    //create a class model for bookings that extends clients class
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
