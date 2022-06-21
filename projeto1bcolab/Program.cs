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
            
            int numero;
            Pessoa aluno;
            aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aluno.nome = "Pedro";
            professor.nome = "Prof. Carvalho";
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.WriteLine("Professor:" + professor.nome);

            //willian--
            SmartPhone samsung = new SmartPhone();
            Console.WriteLine("===================================");
            samsung.nome = "Samsung A31";
            samsung.serie = int.Parse("634535242");
            Console.WriteLine("SmartPhone:" + samsung.nome);
            Console.WriteLine("Serie:" + samsung.serie);


            Console.ReadKey();
        }
    }
}
