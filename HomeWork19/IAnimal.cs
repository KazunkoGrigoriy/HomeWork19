using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    interface IAnimal
    {
        string type { get; set; }
        string view { get; set; }
        string breed { get; set; }
        string habitat { get; set; }
    }
}
