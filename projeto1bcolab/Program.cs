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
//<<<<<<< HEAD

//=======
//<<<<<<< HEAD

            Pessoa professor = new Pessoa();
            aula alunos = new aula();
            musica cliente = new musica();
            alunos.materia = "matematica";
            alunos.tema = "fracao";

            //Stivem
            Pessoa aluno = new Pessoa();
            aluno.nome = "stivem";
            aluno.email = "aluno@gmail.com";
            Console.WriteLine("nome: " + aluno.nome);
            Console.WriteLine("email: " + aluno.email);

            professor.nome = "jeferson";
            professor.email = "professor@gmail.com";
            cliente.tipo = "rock";
            cliente.artista = "metallica";

            Console.WriteLine("nome: " + professor.nome);
            Console.WriteLine("email: " + professor.email);
            Console.WriteLine("materia: " + alunos.materia);
            Console.WriteLine("fracao: " + alunos.tema);
            Console.WriteLine("tipo:" + cliente.tipo);
            Console.WriteLine("artista:" + cliente.artista);


//=======
            
//>>>>>>> a0aebb70b263def098150bb3f267da33834aaa0c
            Pessoa alun;
            alun = new Pessoa();
            Pessoa professora = new Pessoa();
            alun.nome = "Gabriello";
            professora.nome = "Prof. NosreffeJ Jetli";
            Console.WriteLine("Aluno:" + alun.nome);
            Console.WriteLine("Professor:" + professora.nome);

//<<<<<<< HEAD
//=======
            //willian--
            SmartPhone samsung = new SmartPhone();
            Console.WriteLine("===================================");
            samsung.nome = "Samsung A31";
            samsung.serie = int.Parse("634535242");
            Console.WriteLine("SmartPhone:" + samsung.nome);
            Console.WriteLine("Serie:" + samsung.serie);

            //Lucas
            PC programado = new PC();
            programado.marca = "Queijo prato";
            programado.modelo = "presunto";
            Console.WriteLine("Pc:" + programado.marca);
            Console.WriteLine("Pc:" + programado.modelo);


            //Alexandre
            veiculo carro = new veiculo();
            carro.marca = "VW";
            carro.modelo = "Fox";
            carro.ano = "2016";
            Console.WriteLine("\r\n Alexandre \r\n");
            Console.WriteLine("Marca: " + carro.marca);
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Ano: " + carro.ano);

            //Felipe
            marcas marca2 = new marcas();
            marca2.marca = "gucci";
            Console.WriteLine("Marca: " + marca2.marca);

            //Leticia 
            cores azul = new cores();
            cores.nome = "azul";
            cores.tonalidade = "azul escuro";
            Console.WriteLine("cores:" +cores.nome);
            Console.WriteLine("cores:" +cores.tonalidade);
         

            //Alice
            acessorio pulseira = new acessorio();
            pulseira.nome = "miojo";
            pulseira.modelo = "niagra";
            Console.WriteLine("Acessorio:" +pulseira.nome);
            Console.WriteLine("Laranja:" +pulseira.modelo);
           

            //Larissa
            animal gato = new animal();
            gato.nome = "start";
            gato.raça = "Siamês";
            Console.WriteLine("Animal:" + gato.nome);
            Console.WriteLine("Raça:"+ gato.raça);
            //>>>>>>> a0aebb70b263def098150bb3f267da33834aaa0c

            //Renato
            //bó bleis
            jogo bbcf = new jogo();
            bbcf.nome = "BlazBlue Centralfiction";
            bbcf.genero = "Fighting Game";
            Console.WriteLine($"Nome: {bbcf.nome}");
            Console.WriteLine($"Gênero: {bbcf.genero}");
            //>>>>>>> d90be4972650745b0354d3ba54a0324ac0454490

            //Raquel
            Pessoa estudante;
            estudante = new Pessoa();
            Pessoa instrutor;
            instrutor = new Pessoa();
            estudante.nome = "Raquel";
            instrutor.nome = "Lary";
            Console.WriteLine("Estudante " + estudante.nome);
            Console.WriteLine("instrutor " + instrutor.nome);
            Console.ReadKey();
        }
    }
}
