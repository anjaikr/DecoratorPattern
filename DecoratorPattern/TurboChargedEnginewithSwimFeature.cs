using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class TurboChargedEnginewithSwimFeature : CarDecorator
    {
        public TurboChargedEnginewithSwimFeature(ICar car) : base(car) { }

        public override string Description => base.Description + " with Swim Feature";

        public override int Price => base.Price + 15000;
    }
}
