using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_SpravceVozidel
{
    public class SpravceVozidel
    {
        public List<Vozidlo> SeznamVozidel = new List<Vozidlo>();
        private string typVozidla;

        public void PridaniAuta(string typVozidla, int rokVyroby, string barva, int pocetDveri, string model)
        {
            SeznamVozidel.Add(new Automobil(typVozidla, rokVyroby, barva, pocetDveri, model) { });
            
        }

        public void PridaniMotorky(string typVozidla, int rokVyroby, string barva, int pocetKol, string typMotocyklu)
        {
            SeznamVozidel.Add(new Motocykl(typVozidla, rokVyroby, barva, pocetKol, typMotocyklu) { });

        }

        public void ZobrazNaKonzoli() 
        {
            foreach (var vozidlo  in SeznamVozidel)
            {
                Console.WriteLine($"{vozidlo.TypVozidla}, {vozidlo.RokVyroby}, {vozidlo.Barva}");
                if (vozidlo.TypVozidla == "auto") 
                {
                    Console.Write($"Jak sem vypsat model auta a pocet dveri?");                    
                }
                else if (vozidlo.TypVozidla == "moto")
                {
                    Console.Write($"Jak sem vypsat typ motorky a pocet kol?");
                }
            }
        }

    }
}
