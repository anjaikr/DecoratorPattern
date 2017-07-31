using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Car Decorator Base Class
    public abstract class CarDecorator : ICar
    {
        private ICar car { get; set; }
        protected CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string Description => car.Description;

        public virtual int Price => car.Price;
    }

}
