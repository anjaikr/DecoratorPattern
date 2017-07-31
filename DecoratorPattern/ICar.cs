using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Car IComponent Class
    public interface ICar
    {
        string Description { get; }
        int Price { get; }
    }

}
