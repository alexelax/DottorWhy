using DottorWhy.Classes;
using ExtendCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DottorWhy.Forms
{
    public partial class EditDomande : Form
    {
        public EditDomande()
        {
            InitializeComponent();
        } 
        private void EditDomande_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Domande.txt"))
                using (FileStream s = File.OpenWrite("Domande.txt")) { }  
            else
                listBox1.Items.AddRange(Json.Deserialize<List<Domanda>>(File.ReadAllText("Domande.txt")).ToArray()); 
        }

        private void AddDomanda_Click(object sender, EventArgs e)
        {
            Domanda d = new Domanda();
            d.Testo = textBox1.Text.Trim();
            Dictionary<Pulsante, String> dd = new Dictionary<Pulsante, string>();
            dd.Add(Pulsante.X, textBox2.Text.Trim());
            dd.Add(Pulsante.Q, textBox3.Text.Trim());
            dd.Add(Pulsante.T, textBox4.Text.Trim());
            dd.Add(Pulsante.C, textBox5.Text.Trim());
            d.ListaRisp = dd;
            d.risposta = radioButtonX.Checked ? Pulsante.X : radioButtonQ.Checked ? Pulsante.Q : radioButtonT.Checked ? Pulsante.X : Pulsante.C;
            listBox1.Items.Add(d);

            if (checkBox1.Checked)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
        private void RemoveDomanda_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
        }
        private void ClearAllDomande_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void SaveDomande_Click(object sender, EventArgs e)
        {
            using (FileStream s = File.OpenWrite("Domande.txt"))
            {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(Json.Serialize(new List<Domanda>(listBox1.Items.Cast<Domanda>())));
                }
            }
        }

    }
}
