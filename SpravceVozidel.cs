using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_SpravceVozidel
{
    public class SpravceVozidel
    {
        public List<Automobil> SeznamAut = new List<Automobil>();
        public List<Motocykl> SeznamMotorek = new List<Motocykl>();
     

        public void PridaniAuta(string typVozidla, int rokVyroby, string barva, int pocetDveri, string model)
        {
            SeznamAut.Add(new Automobil(typVozidla, rokVyroby, barva, pocetDveri, model) { });
            
        }

        public void PridaniMotorky(string typVozidla, int rokVyroby, string barva, int pocetKol, string typMotocyklu)
        {
            SeznamMotorek.Add(new Motocykl(typVozidla, rokVyroby, barva, pocetKol, typMotocyklu) { });

        }

        public void ZobrazNaKonzoli() 
        {
            
            Console.WriteLine("Vypis seznamu");
            foreach (var vozidlo  in SeznamAut)
            {
                Console.WriteLine($"Typ vozidla: {vozidlo.TypVozidla}, Rok vyroby: {vozidlo.RokVyroby}, Barva: {vozidlo.Barva},\t Pocet dveri: {vozidlo.PocetDveri}, Model: {vozidlo.Model}");          
            }
            
            foreach (var vozidlo in SeznamMotorek)
            {
                Console.WriteLine($"Typ vozidla: {vozidlo.TypVozidla}, Rok vyroby: {vozidlo.RokVyroby}, Barva: {vozidlo.Barva},\t Pocet kol: {vozidlo.PocetKol}, Typ motocyklu: {vozidlo.TypMotocyklu}");
            }
        }

    }
}
