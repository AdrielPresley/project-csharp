using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    { 
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }
    class Animal : IAnimal
    { 
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
        Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
        NomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
        Especie = especie;
        }
    }
}
