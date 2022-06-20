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
<<<<<<< HEAD
            smartphone samsung = new smartphone();
            samsung.nome = "A31";
            samsung.serie = 4654234256775;

            Console.WriteLine("Nome:" + samsung.nome);
            Console.WriteLine("Serie" + samsung.serie);
=======
            int numero;
            Pessoa aluno;
            aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aluno.nome = "Pedro";
            professor.nome = "Prof. Carvalho";
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.WriteLine("Professor:" + professor.nome);
>>>>>>> 90271834b87cabf91cc79ff4ccc437b5644edc29
            Console.ReadKey();
        }
    }
}
