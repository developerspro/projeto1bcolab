using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_PCs_Arthur
{
    class Eletronico
    {
        static void Main(string[] args)
        {
            //Arthur
            Eletronico PC = new Eletronico();
            PC.tipo = "PC gamer";
            PC.modelo = "Acer nitro 5x";
            PC.valor = double.Parse("12000");
            PC.serie = double.Parse("894564564");
            Console.WriteLine("tipo: " + PC.tipo);
            Console.WriteLine("valor: R$" + PC.valor);
            Console.WriteLine("serie: " + PC.serie);
            Console.WriteLine("modelo: " + PC.modelo);

            Console.ReadKey();
        }
    }
}
