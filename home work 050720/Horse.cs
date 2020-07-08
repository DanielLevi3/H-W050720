using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_050720
{
    public class Horse : Animal
    {
        public bool _racingHorse;
        public Horse(string _name , bool _racingHorse) : base(_name)
        {
            this._racingHorse = _racingHorse;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Neigh");
        }
        public virtual void Neigh()
        {
            Console.WriteLine("Neiigghhhh!");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] RacingHorse : {_racingHorse}";
        }
    }
}
