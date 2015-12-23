﻿using System;
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

namespace DottorWhy
{
    public partial class Form1 : Form
    {

        Dictionary<Giocatore, Dictionary<Keys, Pulsante>> Giocatori = new Dictionary<Giocatore, Dictionary<Keys, Pulsante>>();

        Domanda _DomandaCorrente;
        Domanda DomandaCorrente
        {
            get { return _DomandaCorrente; }
            set {
                _DomandaCorrente = value;
                textBox2.Text = _DomandaCorrente.Testo + "\r\n\r\n";
                foreach(KeyValuePair<Pulsante, String> k in _DomandaCorrente.ListaRisp)
                    textBox2.Text += k.Key + " - " + k.Value + "\r\n";

                SettaGiocatoriAttivi(true);

            }
        }

        List<Domanda> Domande = new List<Domanda>();


        public Form1()
        {
            InitializeComponent();


        }


      

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<Keys, Pulsante> t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.NumPad0,Pulsante.X);
            t.Add(Keys.NumPad1, Pulsante.Q);
            t.Add(Keys.NumPad2, Pulsante.T);
            t.Add(Keys.NumPad3, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 1"), t);


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.NumPad4, Pulsante.X);
            t.Add(Keys.NumPad5, Pulsante.Q);
            t.Add(Keys.NumPad6, Pulsante.T);
            t.Add(Keys.NumPad7, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 2"), t);


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.A, Pulsante.X);
            t.Add(Keys.B, Pulsante.Q);
            t.Add(Keys.C, Pulsante.T);
            t.Add(Keys.D, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 3"), t);


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.E, Pulsante.X);
            t.Add(Keys.F, Pulsante.Q);
            t.Add(Keys.G, Pulsante.T);
            t.Add(Keys.H, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 4"), t);

            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.I, Pulsante.X);
            t.Add(Keys.J, Pulsante.Q);
            t.Add(Keys.K, Pulsante.T);
            t.Add(Keys.L, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 5"), t);


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.M, Pulsante.X);
            t.Add(Keys.N, Pulsante.Q);
            t.Add(Keys.O, Pulsante.T);
            t.Add(Keys.P, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 6"), t);


            t = new Dictionary<Keys, Pulsante>();
            t.Add(Keys.Q, Pulsante.X);
            t.Add(Keys.R, Pulsante.Q);
            t.Add(Keys.S, Pulsante.T);
            t.Add(Keys.T, Pulsante.C);
            Giocatori.Add(new Giocatore("Giocatore 7"), t);



            List<Control> l = this.GetControl(true);
            foreach( Control c in l )
            {
                c.KeyDown += KeyDownEvent;
            }



            Domanda d = new Domanda();
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
            DomandaCorrente = d;

            /*foreach(String s in File.ReadLines("pippo.txt"))
            {
                Domande.Add(Json.Deserialize<Domanda>(s));
            }*/

            /* using (FileStream s = File.OpenWrite("pippo.txt"))
            {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(Json.Serialize(Domande));
                }
            }*/

            Domande=Json.Deserialize<List<Domanda>>(File.ReadAllText("pippo.txt"));

            
        }

       


        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            foreach(KeyValuePair<Giocatore, Dictionary<Keys, Pulsante>> coppia in Giocatori)
            {
                if (coppia.Key.attivo &&  coppia.Value.ContainsKey(e.KeyCode))
                {
                    textBox1.Text += coppia.Key+" ";
                    textBox1.Text += coppia.Value[e.KeyCode] + "\r\n";
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.ScrollToCaret();
                    Clicca(coppia.Key, coppia.Value[e.KeyCode]);
                    break;
                }
            }
           
            e.Handled = true;
            e.SuppressKeyPress = true;
        }


        private void Clicca(Giocatore Giocatore, Pulsante premuto)
        {
            Giocatore.attivo = false;
            if ( DomandaCorrente.risposta==premuto)
            {
                textBox1.Text += "GIUSTO!!!";
                SettaGiocatoriAttivi(false);
            }
        }

        private void SettaGiocatoriAttivi(bool Valore)
        {
            foreach (KeyValuePair<Giocatore, Dictionary<Keys, Pulsante>> coppia in Giocatori)
                coppia.Key.attivo = Valore;
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            Domanda d = new Domanda();
            d.Testo = "sei frocio?"+i;
            Dictionary<Pulsante, String> dd = new Dictionary<Pulsante, string>();
            dd.Add(Pulsante.X, "Si");
            dd.Add(Pulsante.T, "Assolutamente SI");
            dd.Add(Pulsante.Q, "Come vazz (quindi si)");
            dd.Add(Pulsante.C, "Come Lu (quindi lecca la figa a manetta)");
            d.ListaRisp = dd;
            d.risposta = Pulsante.Q;


            DomandaCorrente = d;

            /*using (FileStream s = File.OpenWrite("pippo.txt"))
            {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(Json.Serialize(d));
                }
            }*/


            
        }
    }



    public class Domanda
    {
        public String Testo;
        public Pulsante risposta;
        public Dictionary<Pulsante,String> ListaRisp= new Dictionary<Pulsante, String>();

    }
    public class Giocatore
    {
        String Name;
        public bool attivo = true;
        public Giocatore(String Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return Name;
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