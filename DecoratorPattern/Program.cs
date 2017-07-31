using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //var str = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
            var objRegInfo = new RegionInfo("en-IN");
            string syb = objRegInfo.CurrencySymbol;
            //Manufacturing a Boring Car
            ICar boringCar = new BoringCar();
            Console.WriteLine(String.Format("{0} costs {1}", boringCar.Description, boringCar.Price.ToString("C", CultureInfo.CurrentCulture)));

            //Manufacturing an Exciting Car = Boring Car + Custom Paint
            ICar excitingCar = new CustomPaintDecorator(
                                                            new BoringCar()
                                                        );
            Console.WriteLine(String.Format("{0} costs {1}", excitingCar.Description, excitingCar.Price.ToString("C", CultureInfo.CurrentCulture)));

            //Manufacturing an Amazing Car = Boring Car + Custom Paint + Turbocharged engine VRRROOM..
            ICar amazingCar = new TurboChargedEngineDecorator(
                                            new CustomPaintDecorator(
                                                new BoringCar()
                                                )

                                                );
            var val = String.Format("{0} costs {1}", amazingCar.Description, amazingCar.Price.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(val);


            //Manufacturing an Amazing Car = Boring Car + Custom Paint + Turbocharged engine VRRROOM..
            ICar swimmingCar = new TurboChargedEnginewithSwimFeature(
                                  new TurboChargedEngineDecorator(
                                            new CustomPaintDecorator(
                                                new BoringCar()
                                                )

                                                ));
            var val2 = String.Format("{0} costs {1}", swimmingCar.Description, swimmingCar.Price.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(val2);


            //const string input = " ₹ 5000 €";
            //var replacements = new Dictionary<string, string> { { "₹", "\u20B9" }, { "€", "\u20AC" } };
            //var output = replacements.Aggregate(input, (current, replacement) => current.Replace(replacement.Key, replacement.Value));
            //Console.WriteLine(output);
            //Console.ReadLine();

            //var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            //culture.NumberFormat.CurrencySymbol = "\u20B9"; // or "¥", etc.

            //var amount = 1000D;
            //Console.WriteLine(amount.ToString("C", culture));

            Console.ReadLine();

        }
    }
}
