using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class Amphibians:IAnimal
    {
        public string type { get; set; }
        public string view { get; set; }
        public string breed { get; set; }
        public string habitat { get; set; }

        public Amphibians(string type, string view, string breed, string habitat)
        {
            this.type = type;
            this.view = view;
            this.breed = breed;
            this.habitat = habitat;
        }
    }
}
