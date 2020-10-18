using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Console_CalculaMediaNotas
{
    class Media
    {
        private double nota1, nota2, nota3, resultado;


        public double _nota1 
        {
            
            get { return nota1; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    nota1 = Convert.ToDouble(value);
                }

            }  

        }
        public double _nota2 
        {
            get { return nota2; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();                    
                }
                else
                {
                    nota2 = Convert.ToDouble(value);
                }            
            }
        }
        public double _nota3
        {
            get { return nota3; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    nota3
                        = Convert.ToDouble(value);
                }
            }
        }

        public double _resultado
        {
            get { return resultado;}
            set {resultado = (nota1 + nota2 + nota3)/3;}
        }
            
    }
}
