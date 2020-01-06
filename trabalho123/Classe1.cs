using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho123
{
    class Classe1
    {
        private double _n1, _n2; // _a -> Altura ; _l -> Largura

        public string Altura { set => _n1 = Convert.ToDouble(value); }
        public string Largura { set => _n2 = Convert.ToDouble(value); }



        public string Multiplicar => (_n1 * _n2).ToString();
        public string Somar => (_n1 + _n2).ToString();
        public string Subtrair => (_n1 - _n2).ToString();
        public string Dividir => (_n1 / _n2).ToString();
    }
}
