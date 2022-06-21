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
            aluno.nome = "Gabriello";
            professor.nome = "Prof. NosreffeJ";
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.WriteLine("Professor:" + professor.nome);

            Console.ReadKey();
        }
    }
}
