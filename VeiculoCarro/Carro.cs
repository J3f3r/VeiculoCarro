using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoCarro
{
    class Carro : Veiculo
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor) : base(4)//base é referencia ao construtor da classe base que precisa de um argumento no caso '4'
        {
            desligar();
            velMax = 120;// aqui não tem como acessar rodas para atribuir valor pois rodas é private
            this.nome = nome;
            this.cor = cor;
        }
    }
}
