using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Clients
    {
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdType { get; set; }
        public Clients(int id, string type, string name, string surname) 
        {
            this.IdNumber = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
