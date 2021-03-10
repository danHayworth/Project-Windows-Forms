using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Clients
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
