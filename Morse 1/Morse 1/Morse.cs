using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_1
{
    class Morse
    {
        public string Betu;
        public string MorseKod;
        
        public Morse(string sor)
        {
            var dbok = sor.Split(';');
            this.Betu = dbok[0];
            this.MorseKod = dbok[1];
        }
    }
 
}
