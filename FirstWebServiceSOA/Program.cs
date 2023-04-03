using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebServiceSOA
{
    class Program
    {
        static void Main()
        {
            var demoWebService = new ServiceReference1.CalculatorSoapClient();
            var result = demoWebService.Multiply(4, 4);
            Console.WriteLine("Resultado da multiplicação: " + result);
        }
    }
}
