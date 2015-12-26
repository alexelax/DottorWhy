using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtendCSharp;
using System.IO;
using DottorWhy.Classes;
using DottorWhy.Controlli;

namespace DottorWhy.Forms
{
    public partial class DottorWhyForm : Form
    {
        int MaxColonne = 4;
        List<Giocatore> Giocatori = null;
        List<Domanda> Domande = null;
        Domanda _DomandaCorrente;
        Domanda DomandaCorrente
        {
            get { return _DomandaCorrente; }
            set
            {
                _DomandaCorrente = value;
                textBox_domanda.Text = _DomandaCorrente.Testo;

                textBox_X.Text = _DomandaCorrente.ListaRisp[Pulsante.X];
                textBox_Q.Text = _DomandaCorrente.ListaRisp[Pulsante.Q];
                textBox_T.Text = _DomandaCorrente.ListaRisp[Pulsante.T];
                textBox_C.Text = _DomandaCorrente.ListaRisp[Pulsante.C];

                SettaGiocatoriAttivi(true);
                PulisciGraficaGiocatori();
            }
        }

        public DottorWhyForm()
        {
            InitializeComponent();
            Giocatori = new List<Giocatore>();
        }
        public DottorWhyForm(List<Giocatore> g)
        {
            InitializeComponent();
            if (g == null)
                Giocatori = new List<Giocatore>();
            else
                Giocatori = g;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Dictionary<Keys, Pulsante> t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.NumPad0, Pulsante.X);
            t.Add(Keys.NumPad1, Pulsante.Q);
            t.Add(Keys.NumPad2, Pulsante.T);
            t.Add(Keys.NumPad3, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 1",t));


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.NumPad4, Pulsante.X);
            t.Add(Keys.NumPad5, Pulsante.Q);
            t.Add(Keys.NumPad6, Pulsante.T);
            t.Add(Keys.NumPad7, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 2", t));


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.A, Pulsante.X);
            t.Add(Keys.B, Pulsante.Q);
            t.Add(Keys.C, Pulsante.T);
            t.Add(Keys.D, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 3", t));


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.E, Pulsante.X);
            t.Add(Keys.F, Pulsante.Q);
            t.Add(Keys.G, Pulsante.T);
            t.Add(Keys.H, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 4", t));

            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.I, Pulsante.X);
            t.Add(Keys.J, Pulsante.Q);
            t.Add(Keys.K, Pulsante.T);
            t.Add(Keys.L, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 5", t));


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.M, Pulsante.X);
            t.Add(Keys.N, Pulsante.Q);
            t.Add(Keys.O, Pulsante.T);
            t.Add(Keys.P, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 6", t));


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.Q, Pulsante.X);
            t.Add(Keys.R, Pulsante.Q);
            t.Add(Keys.S, Pulsante.T);
            t.Add(Keys.T, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 7", t));

            */


            int r = 0,c=0;
            foreach (Giocatore g in Giocatori)
            {
                g.ControlloGrafico = new ControlGiocatore();
                g.ControlloGrafico.Location = new Point(c++ * g.ControlloGrafico.Width, r * g.ControlloGrafico.Height);
                panel_giocatori.Controls.Add(g.ControlloGrafico);

                if (c >= MaxColonne)
                {
                    c = 0;
                    r++;
                }
            }
            PulisciGraficaGiocatori();


            foreach (Control cc in this.GetControl(true))
                cc.KeyDown += KeyDownEvent;





            /*Domanda d = new Domanda();
            d.Testo = "sei frocio?";
            Dictionary<Pulsante, String> dd = new Dictionary<Pulsante, string>();
            dd.Add(Pulsante.X, "Si");
            dd.Add(Pulsante.T, "Assolutamente SI");
            dd.Add(Pulsante.Q, "Come vazz (quindi si)");
            dd.Add(Pulsante.C, "Come Lu (quindi lecca la figa a manetta)");
            d.ListaRisp = dd;
            d.risposta = Pulsante.Q;

            Domande.Add(d);
            Domande.Add(d);
            DomandaCorrente = d;*/

            /* foreach (String s in File.ReadLines("Domande.txt"))
             {
                 Domande.Add(Json.Deserialize<Domanda>(s));
             }*/

            /*using (FileStream s = File.OpenWrite("Domande1.txt"))
            {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(Json.Serialize(Domande));
                }
            }*/

            if (!File.Exists("Domande.txt"))
            {
                MessageBox.Show("Attenzione!\r\nFile delle domande non trovato;\r\nne è stato appena creato uno VUOTO", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                File.Create("Domande.txt");
                Domande = new List<Domanda>();
            }
            else
                Domande = Json.Deserialize<List<Domanda>>(File.ReadAllText("Domande.txt"));


            
        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            if (DomandaCorrente == null)
                return;

            foreach (Giocatore g in Giocatori)
            {
                if (g.attivo && g.ComandiAssociati.ContainsKey(e.KeyCode))
                {
                    Clicca(g, g.ComandiAssociati[e.KeyCode]);
                    break;
                }
            }

            
        }

        CountDown ContoAllaRovescia = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ContoAllaRovescia == null)
            {
                ContoAllaRovescia = new CountDown(new TimeSpanPlus(0, 10));
                ContoAllaRovescia.Tick += (CountDown cd) =>
                {
                    label1.SetTextInvoke(cd.ToString("ss"));
                };
                ContoAllaRovescia.Started += (CountDown cd) =>
                {
                    label1.SetTextInvoke(cd.ToString("ss"));
                };

                ContoAllaRovescia.Stopped += (CountDown cd, StopStatus s) =>
                {
                    if (s == StopStatus.End)
                    {
                        label1.SetTextInvoke("FINE TEMPO!");
                    }
                    else
                    {
                        label1.SetTextInvoke("INTERROTTO!");
                    }
                    SettaGiocatoriAttivi(false);
                };

            }
            else
                ContoAllaRovescia.SetTime(new TimeSpanPlus(0, 10));



            if (CambiaDomanda())
                ContoAllaRovescia.Start();
            else
                label1.SetTextInvoke("ERRORE NEL RECUPERO DELLE DOMANDE!");

        }


        int i = 0;
        private bool CambiaDomanda()
        {
            if (Domande.Count == 0)
                return false;
            if (i >= Domande.Count)
                i = 0;
            DomandaCorrente = Domande[i++];
            return true;
        }

        private void Clicca(Giocatore Giocatore, Pulsante premuto)
        {
            Giocatore.attivo = false;
            Giocatore.SettaPulsanteGrafica(premuto.ToString());
            if (DomandaCorrente.risposta == premuto)
            {
                Giocatore.SettaMessaggioGrafica("GIUSTO!!!");
                Giocatore.Punteggio += (ContoAllaRovescia.Time.Seconds) * 50;
                //SettaGiocatoriAttivi(false);
            }
            else
            {
                Giocatore.Punteggio -= (ContoAllaRovescia.Time.Seconds) * 60;
            }
        }
        private void PulisciGraficaGiocatori()
        {
            foreach (Giocatore g in Giocatori)
            {
                g.PulisciGrafica();
            }
        }
        private void SettaGiocatoriAttivi(bool Valore)
        {
            foreach (Giocatore g in Giocatori)
                g.attivo = Valore;
        }

    }  
    
   
}