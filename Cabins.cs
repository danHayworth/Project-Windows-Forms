using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
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
