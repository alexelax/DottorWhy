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
        int MaxColonne = 7;
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
  


            int r = 0,c=0;
            int widthMax = 0, widthCurrent=0, Height = 0;

            foreach (Giocatore g in Giocatori)
            {
                g.ControlloGrafico = new ControlGiocatore(g);
                g.ControlloGrafico.Location = new Point(widthCurrent, r * g.ControlloGrafico.Height);
                widthCurrent += g.ControlloGrafico.Width;
                panel_giocatori.Controls.Add(g.ControlloGrafico);

                c++;
                if(Height==0)
                    Height = g.ControlloGrafico.Height;
                if (c >= MaxColonne)
                {
                    c = 0;
                    r++;
                    

                    if (widthCurrent > widthMax)
                        widthMax = widthCurrent;
                    widthCurrent = 0;
                }
            }
            if (widthCurrent > widthMax)
                widthMax = widthCurrent;

             panel_giocatori.Width=widthMax;
            panel_giocatori.Height= (r+1)*Height;



            PulisciGraficaGiocatori();


            foreach (Control cc in this.GetControl(true))
                cc.KeyDown += KeyDownEvent;


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
            panel_giocatori.SetVisibleInvoke(false);
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
                        label1.SetTextInvoke("STOP");
                        panel_giocatori.SetVisibleInvoke(true);
                    }
                    else
                    {
                        label1.SetTextInvoke("INTERROTTO");
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

        private static Giocatore GetGiocatore(Giocatore Giocatore)
        {
            return Giocatore;
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
                    Giocatore.SettaMessaggioGrafica("CORRETTO!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Option(Giocatori).ShowDialog();
        }
        
    }  
    
   
}