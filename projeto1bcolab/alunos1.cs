using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            alunos aluno;
            aluno = new Pessoa();
            alunos professor = new Pessoa();
            aluno.nome = "kelvinho";
            professor.nome = "pardal";
            Console.WriteLine("aluno:" + aluno.nome);
            Console.Writeline("professor:" + professor.nome);
            Console.ReadKey();
            
    }
}
