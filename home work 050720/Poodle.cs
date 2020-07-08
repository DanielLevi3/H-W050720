using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_050720
{
    public class Poodle : Dog
    {
        public string _numberOfPonyTails;
        public Poodle(string _name, string _favoriteDogFood, string _numberOfPonyTails) : base(_name, _favoriteDogFood)
        {
            this._numberOfPonyTails = _numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("Wif");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] NumberOfPonyTails : {_numberOfPonyTails}";
        }
    }
}
