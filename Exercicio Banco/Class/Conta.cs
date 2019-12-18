using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco.Class
{
    class Conta
    {
        private string  _nome;
        public string   _conta;
        public Double valor { get; private set; }

        public  String Nome
        {
            get { return _nome; }
            set
            {
                if(value!=null)
                {
                    _nome = value;
                }
            }
        }

        public String NumConta
        {
            get { return _conta; }
            set
            {
                if(value!=null)
                {
                    _conta = value;
                }
            }
        }

        public void valorinicial(Double Valor)
        {
            valor += Valor;     
        }

        public void Addvalor(Double Valor)
        {
                    valor += Valor;
        }
        public void Subvalor( Double Valor)
        {
                      valor =this.valor-Valor;
         }

        public void ValidaInf(String valida, String deposito, Double Valor)
        {
            if(valida!=" ")
            {
                if (deposito.Equals("S"))
                    valorinicial(Valor);
                
                else
                {
                    this.valor = 0;
                    this._nome = valida;
                    if (_conta.Contains(valida))
                    {
                        if (Valor != 0)
                        {
                            Addvalor(Valor);
                        }
                    }

                    if (_conta.Contains(valida))
                    {
                        if (Valor != 0)
                        {
                            Subvalor(Valor);
                        }
                    }
                }

                
            }

        }

       
    }
}
