using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class Birds:IAnimal
    {
        public string Type { get; set; }
        public string View { get; set; }
        public string Breed { get; set; }
        public string Habitat { get; set; }

        public Birds(string Type, string View, string Breed, string Habitat)
        {
            this.Type = Type;
            this.View = View;
            this.Breed = Breed;
            this.Habitat = Habitat;
        }
    }
}
