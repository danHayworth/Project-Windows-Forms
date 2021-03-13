namespace Project
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 15-03-2021
    */

    //create the base client abstract class
    public abstract class Clients
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }

        public Clients(string name, string surname, int phone) 
        {
            this.Phone = phone;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
