using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DottorWhy.Classes
{
    public class Domanda
    {
        public String Testo;
        public Pulsante risposta;
        public Dictionary<Pulsante, String> ListaRisp = new Dictionary<Pulsante, String>();

        public override string ToString()
        {
            return Testo;
        }
    }
}
