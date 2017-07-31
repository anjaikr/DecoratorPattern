using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Decorator 2 - Turbocharged engine
    public class TurboChargedEngineDecorator : CarDecorator
    {
        public TurboChargedEngineDecorator(ICar car) : base(car) { }

        public override string Description => base.Description + " with Turbo Charged Engine";

        public override int Price => base.Price + 10000;
    }

}
