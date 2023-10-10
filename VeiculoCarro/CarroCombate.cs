using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoCarro
{
    class CarroCombate : Carro
    {
        public int municao;
        public CarroCombate() : base("Carro de Combate", "Verde")
        {
            municao = 100;
            setRodas(6);
        }
    }
}
