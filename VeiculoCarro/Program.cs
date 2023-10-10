using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão", "Vermelho");
            CarroCombate cc1 = new CarroCombate();//o argumento já foi herdado e atribuido na classe carro

            Console.WriteLine("Cor.......: {0}", c1.cor);
            Console.WriteLine("Nome......: {0}", c1.nome);
            Console.WriteLine("Rodas.....: {0}", c1.getRodas());
            Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
            Console.WriteLine("Ligado....: {0}", c1.getLigado());

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Cor.......: {0}", cc1.cor);
            Console.WriteLine("Nome......: {0}", cc1.nome);
            Console.WriteLine("Rodas.....: {0}", cc1.getRodas());
            Console.WriteLine("Vel.Máxima: {0}", cc1.velMax);
            Console.WriteLine("Ligado....: {0}", cc1.getLigado());
            Console.WriteLine("Munição...: {0}", cc1.municao);
        }
    }
}
