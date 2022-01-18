using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class NullAnimal:IAnimal
    {
        public string type { get; set; }
        public string view { get; set; }
        public string breed { get; set; }
        public string habitat { get; set; }
        public NullAnimal()
        {
            type = "";
            view = "Нет вида";
            breed = "Нет породы";
            habitat = "Нет среды обитания";
        }
    }
}
