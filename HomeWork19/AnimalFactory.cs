using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class AnimalFactory
    {
        public static IAnimal GetAnimal(string type, string view, string breed, string habitat)
        {
            if (type == "Млекопитающие") return new Mammals(type, view, breed, habitat);
            if (type == "Птицы") return new Birds(type, view, breed, habitat);
            if (type == "Земноводные") return new Amphibians(type, view, breed, habitat);
            else return new NullAnimal();
        }
    }
}
