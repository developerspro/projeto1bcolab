using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1bcolab
{
    class Program
    {
        static void Main(string[] args)
        {
            smartphone samsung = new smartphone();
            samsung.nome = "A31";
            samsung.serie = 4654234256775;

            Console.WriteLine("Nome:" + samsung.nome);
            Console.WriteLine("Serie" + samsung.serie);
            Console.ReadKey();
        }
    }
}
