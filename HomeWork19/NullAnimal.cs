using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class NullAnimal:IAnimal
    {
        public string Type { get; set; }
        public string View { get; set; }
        public string Breed { get; set; }
        public string Habitat { get; set; }
        public NullAnimal()
        {
            Type = "";
            View = "Нет вида";
            Breed = "Нет породы";
            Habitat = "Нет среды обитания";
        }
    }
}
