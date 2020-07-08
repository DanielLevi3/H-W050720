using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace home_work_050720
{
    class Program
    {
        static void AnimalSing(Animal[] a)
        {
            
            for (int i = 0; i <a.Length ; i++)
            {
                a[i].MakeSound();
            }
        }
        
        static void GetRacingHorses (Horse[] racingHorses)
        {
            
            for(int i = 0; i<racingHorses.Length;i++)
            {
                if(racingHorses[i]._racingHorse)
                {
                    Console.WriteLine(racingHorses[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Dog Pitbull = new Dog("Roki", "Bonzo");
         
            Horse Horse1 = new Horse("Robi", false);
          
            Poodle WhitePoodle = new Poodle("Miki", "Bonzo", "Two");
           
            Wolf WestrenWolf = new Wolf("Stew", "Sheeps", "R");
           
            PetWolf NewBorn = new PetWolf("Rick", "Mom's food", "X");
           
            Animal[] a = new Animal[3] { Horse1, WhitePoodle, Pitbull };
           
            AnimalSing(a);
            
            Horse Horse2 = new Horse("KingJ", true);
           
            Horse Horse3 = new Horse("Price S", true);
            
            Horse[] b = new Horse[3] { Horse1, Horse2, Horse3 };
           
            GetRacingHorses(b);
        }
    }
}
