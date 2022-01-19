using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    interface IAnimal
    {
        string Type { get; set; }
        string View { get; set; }
        string Breed { get; set; }
        string Habitat { get; set; }
    }
}
