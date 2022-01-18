using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class RepositoryAnimal
    {
        public BindingList<IAnimal> bd;

        public RepositoryAnimal()
        {
            bd = new BindingList<IAnimal>();
        }

        public void Add(IAnimal animal)
        {
            bd.Add(animal);
        }
    }
}
