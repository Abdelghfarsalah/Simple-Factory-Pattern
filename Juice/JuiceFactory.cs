using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Juice
{
    internal class JuiceFactory
    {
        public static Ijuceinterface createJuice(string name)
        {
            if(name == "Orange")
            {
                return new OrangeJuice();
            }
            else if (name == "Appel")
            {
                return new AppleJuice();
            }
            else
            {
                return new ErrorJuice();
            }
        }
    }
}
