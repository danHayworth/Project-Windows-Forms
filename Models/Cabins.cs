namespace Project
{
    /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
    //create a class model for cabins
    public class Cabins
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public bool Inuse { get; set; }

        public Cabins(int id, string type, int number, bool inuse)
        {
            this.Id = id;
            this.Type = type;
            this.Number = number;
            this.Inuse = inuse;
        }
        
        
        
    }
    
}
