using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Juice
{
    internal class AppleJuice: Ijuceinterface
    {
        public void Drink()
        {
            Console.WriteLine("Drinking Apple juice");
        }
    }
}
