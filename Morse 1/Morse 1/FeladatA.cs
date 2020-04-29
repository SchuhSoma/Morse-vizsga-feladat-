using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_1
{
    class FeladatA
    {
        public string Szerzo;
        public string Idezet;

        public FeladatA(string sor)
        {
            var dbok = sor.Split(';');
            this.Szerzo = dbok[0];
            this.Idezet = dbok[1];
        }

    }
}
