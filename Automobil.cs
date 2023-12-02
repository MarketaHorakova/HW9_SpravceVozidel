﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_SpravceVozidel
{
    public class Automobil : Vozidlo 
    {
        public int PocetDveri;
        public string Model;

        public Automobil(string typVozidla, int rokVyroby, string barva, int pocetDveri, string model) : base(typVozidla, rokVyroby, barva) 
        {
            PocetDveri = pocetDveri;
            Model = model;
        }

      
    }
}
