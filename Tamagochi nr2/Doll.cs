using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_nr2
{
    class Doll : Toy
    {
        public Doll()
        {
            Name = "Doll";
            BoredomReducer =+ 2;
        }
    }
}
