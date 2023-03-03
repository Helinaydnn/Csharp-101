using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsParametized
    {
        int x;
        public clsParametized(int i)
        {
            x = i;
            Console.WriteLine( $"Parametreli ctor/yapıcı çağrıldı ...Parametre değeri : {i}");
        }

        public void Display( )
        {
            Console.WriteLine($"x değişgenin değeri : {x}");

        }
    }
}
