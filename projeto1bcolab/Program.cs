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

=======
<<<<<<< HEAD
            Pessoa aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aula alunos = new aula();
            aluno.materia = "matematica";
            aluno.tema = "fracao";
            aluno.nome = "stivem";
            aluno.email = "aluno@gmail.com";
            professor.nome = "jeferson";
            professor.email = "professor@gmail.com";

            Console.WriteLine("nome: " + aluno.nome);
            Console.WriteLine("email: " + aluno.email);
            Console.WriteLine("nome: " + professor.nome);
            Console.WriteLine("email: " + professor.email);
            Console.WriteLine("materia: " + aluno.materia);
            Console.WriteLine("fracao: " + aluno.tema);

            Console.ReadKey();

=======
            
>>>>>>> a0aebb70b263def098150bb3f267da33834aaa0c
            int numero;
            Pessoa aluno;
            aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aluno.nome = "Gabriello";
            professor.nome = "Prof. NosreffeJ Jetli";
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.WriteLine("Professor:" + professor.nome);

<<<<<<< HEAD
=======
            //willian--
            SmartPhone samsung = new SmartPhone();
            Console.WriteLine("===================================");
            samsung.nome = "Samsung A31";
            samsung.serie = int.Parse("634535242");
            Console.WriteLine("SmartPhone:" + samsung.nome);
            Console.WriteLine("Serie:" + samsung.serie);


>>>>>>> a0aebb70b263def098150bb3f267da33834aaa0c
            Console.ReadKey();
>>>>>>> d90be4972650745b0354d3ba54a0324ac0454490
        }
    }
}
