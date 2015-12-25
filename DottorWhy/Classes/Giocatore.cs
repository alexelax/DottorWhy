using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using DottorWhy.Controlli;

namespace DottorWhy.Classes
{
    [DataContractAttribute]
    public class Giocatore
    {
        [DataMemberAttribute]
        String Name;

        [IgnoreDataMemberAttribute]
        public bool attivo = true;
        [IgnoreDataMemberAttribute]
        int _Punteggio;
        [IgnoreDataMemberAttribute]
        public int Punteggio
        {
            get
            {
                return _Punteggio;
            }
            set
            {
                _Punteggio = value;
                if(ControlloGrafico!=null)
                    ControlloGrafico.label_Punteggio.Text = _Punteggio + "";
            }
        }

        [DataMemberAttribute]
        public Dictionary<Keys, Pulsante> ComandiAssociati;

        [IgnoreDataMemberAttribute]
        public ControlGiocatore ControlloGrafico = null;



        public Giocatore(String Name, Dictionary<Keys, Pulsante> ComandiAssociati = null, int punteggio = 0)
        {
            this.Name = Name;
            Punteggio = punteggio;
            if (ComandiAssociati == null)
                this.ComandiAssociati = new Dictionary<Keys, Pulsante>();
            else
                this.ComandiAssociati = ComandiAssociati;
        }

        public override string ToString()
        {
            return Name;
        }

        public void PulisciGrafica()
        {
            if (ControlloGrafico != null)
            {
                ControlloGrafico.label_nome.Text = Name;
                ControlloGrafico.label_Punteggio.Text = Punteggio + "";
                ControlloGrafico.label_Pulsante.Text = "";
                ControlloGrafico.label_Messaggio.Text = "";
            }
        }
        public void SettaMessaggioGrafica(String s)
        {
            if (ControlloGrafico != null)
            {
                ControlloGrafico.label_Messaggio.Text = s;
            }
        }
        public void SettaPulsanteGrafica(String s)
        {
            if (ControlloGrafico != null)
            {
                ControlloGrafico.label_Pulsante.Text = s;
            }
        }

    }
    public enum Pulsante
    {
        X,
        Q,
        T,
        C
    }
}
