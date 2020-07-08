using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_050720
{
    public abstract class Animal
    {

        public string _name;

        public Animal (string _name)
        {
            this._name = _name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"[{base.ToString()}] Name: {_name}";
        }
    }
}
