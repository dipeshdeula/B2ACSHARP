using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Interfaces
{
    public interface IAnimal
    {
        public void MakeSound();
        public string Name { get; set; }
    }
}
