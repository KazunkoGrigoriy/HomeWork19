using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    abstract class Animal
    {
        BindingList<IGeneral> bd;
        public void Add(IGeneral Animal)
        {
            bd.Add(Animal);
        }

    }
}
