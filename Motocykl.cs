using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW9_SpravceVozidel
{
    public class Motocykl : Vozidlo
    {
        public string TypMotocyklu;
        public int PocetKol;

        public Motocykl(string typVozidla, int rokVyroby, string barva, int pocetKol, string typMotocyklu) : base(typVozidla, rokVyroby, barva) 
        { 
            TypMotocyklu = typMotocyklu;
            PocetKol = pocetKol;
        }
    }
}
