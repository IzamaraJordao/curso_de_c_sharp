using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciociop03
{
    internal class Aluno
    {
        public string Name;
        public double n1;
        public double n2;
        public double n3;


        public double NotaFinal()
        {
            return n1+n2+ n3;
        }
        public bool Aprovado()
        {
            if(NotaFinal() >= 60.0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
