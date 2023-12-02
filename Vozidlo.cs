using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_SpravceVozidel
{
    public abstract class Vozidlo
    {
        public string TypVozidla;
        public int RokVyroby;
        public string Barva;

        public Vozidlo (string typVozidla, int rokVyroby, string barva)
        {
            TypVozidla = typVozidla;
            RokVyroby = rokVyroby;
            Barva = barva;
        }



    }
}
