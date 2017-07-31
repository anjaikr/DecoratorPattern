using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Decorator 1 - Custom Paint
    public class CustomPaintDecorator : CarDecorator
    {
        public CustomPaintDecorator(ICar car) : base(car) { }

        public override string Description => base.Description + " with Custom Paint";

        public override int Price => base.Price + 5000;
    }

}
