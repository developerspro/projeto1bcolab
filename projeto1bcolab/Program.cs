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
            Pessoa aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aluno.nome = "stivem";
            aluno.email = "aluno@gmail.com";
            professor.nome = "jeferson";
            professor.email = "professor@gmail.com";

            Console.WriteLine("nome: " + aluno.nome);
            Console.WriteLine("email: " + aluno.email);
            Console.WriteLine("nome: " + professor.nome);
            Console.WriteLine("email: " + professor.email);

            Console.ReadKey();

        }
    }
}
