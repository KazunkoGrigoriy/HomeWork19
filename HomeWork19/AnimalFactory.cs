using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class AnimalFactory
    {
        public static IAnimal GetAnimal(string Type, string View, string Breed, string Habitat)
        {
            if (Type == "Млекопитающие") return new Mammals(Type, View, Breed, Habitat);
            if (Type == "Птицы") return new Birds(Type, View, Breed, Habitat);
            if (Type == "Земноводные") return new Amphibians(Type, View, Breed, Habitat);
            else return new NullAnimal();
        }
    }
}
