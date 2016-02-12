using DottorWhy.Classes;
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
using System.Threading;
using System.IO;
using DottorWhy.Controlli;


namespace DottorWhy.Forms
{
    public partial class Option : Form
    {
        public Option(List<Giocatore> G)
        {
            InitializeComponent();
            Giocatori = G;
        }

        List<Giocatore> Giocatori { get; set; }

        private void ResettaClassifica()
        {
            foreach (Giocatore g in Giocatori)
                g.Punteggio = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResettaClassifica();
        }

        
    }
 }
