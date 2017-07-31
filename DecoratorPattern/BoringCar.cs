using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Car Component Class
    public class BoringCar : ICar
    {
        public string Description => @"Boring Car";

        public int Price => 20000;
    }

}
