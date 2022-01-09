using System;
using Primeiro;
using Classes;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Gustavo;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Rompe Ferro";
            animal.NomeDono = "Lucas";
            animal.Especie = "Dragão";

            Pessoa person = new Pessoa();

            person.Nome = "Paula";
            person.Idade = 19;
            person.Estado = "SP";
             
            var person2 = new Pessoa();

            person2.Nome = "Luana";
            person2.Idade = 20;
            person2.Estado = "RJ";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa2);
        }
    }
}
