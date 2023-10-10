using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoCarro
{
    class Veiculo
    {
        public int velMax;

        private int rodas;

        public bool ligado;
        public Veiculo(int rodas)// este construtor vai ser herdado no construtor da classe derivada
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public string getLigado()
        {
            return (ligado ? "sim": "não");//operador ternário substitui o if/else
            
            /*if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }*/
        }
        public int getRodas()
        {
            return rodas;
        }
        public void setRodas(int rodas)
        {
            if(rodas < 0)
            {
               this.rodas = 0;
            }else if(rodas > 40)
            {
               this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }
}
