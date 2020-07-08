using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_050720
{
    public class Dog : Animal
    {

        public string _favoriteDogFood;

        public Dog(string _name,string _favoriteDogFood) : base(_name)
        {
            this._favoriteDogFood = _favoriteDogFood;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Bark");
        }
        public virtual void Bark()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] FavoriteDogFood : {_favoriteDogFood} ";
        }
    }
}
