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
using DottorWhy.Classes;

namespace DottorWhy.Forms
{
    public partial class Setup : Form
    {
        
        TextBoxPlus<Keys?> textBoxXX = new TextBoxPlus<Keys?>();
        TextBoxPlus<Keys?> textBoxQQ = new TextBoxPlus<Keys?>();
        TextBoxPlus<Keys?> textBoxTT = new TextBoxPlus<Keys?>();
        TextBoxPlus<Keys?> textBoxCC = new TextBoxPlus<Keys?>();

        public Setup()
        {
            InitializeComponent();
        }
        private void Setup_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.GetControl(true))
            {
                c.KeyDown += (object s, KeyEventArgs ee) =>
                {
                    if (ee.Control && ee.Alt && ee.Shift && ee.KeyCode == Keys.V)
                    {
                        label2.Visible = !label2.Visible;
                        textBox2.Visible = !textBox2.Visible;
                    }
                };
            }

            this.Controls.Replace(textBoxX, textBoxXX);
            this.Controls.Replace(textBoxQ, textBoxQQ);
            this.Controls.Replace(textBoxT, textBoxTT);
            this.Controls.Replace(textBoxC, textBoxCC);


            textBoxXX.KeyDownPlus += TextBoxPulsante_KeyDownPlus;
            textBoxQQ.KeyDownPlus += TextBoxPulsante_KeyDownPlus;
            textBoxTT.KeyDownPlus += TextBoxPulsante_KeyDownPlus;
            textBoxCC.KeyDownPlus += TextBoxPulsante_KeyDownPlus;




        }


        private void AddGiocatore_Click(object sender, EventArgs e)
        {
            if (textBoxXX.TextObject == null || textBoxQQ.TextObject == null || textBoxTT.TextObject == null || textBoxCC.TextObject == null)
            {
                MessageBox.Show("Inserire Tutti i Comandi Associati");
                return;
            }

            Giocatore g = null;
            if (textBox1.Text.Trim()=="")
               g  = new Giocatore("Giocatore " + (listBox1.Items.Count+1));
            else
                g = new Giocatore(textBox1.Text.Trim());

            if(textBox2.Text.Trim().IsInt())
                g.Punteggio = textBox2.Text.Trim().ParseInt();


            g.ComandiAssociati.Add(textBoxXX.TextObject.Value, Pulsante.X);
            g.ComandiAssociati.Add(textBoxQQ.TextObject.Value, Pulsante.Q);
            g.ComandiAssociati.Add(textBoxTT.TextObject.Value, Pulsante.T);
            g.ComandiAssociati.Add(textBoxCC.TextObject.Value, Pulsante.C);

            PulisciCampi();

            listBox1.Items.Add(g);
        }
        private void RemoveGiocatore_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]); 
        }
        private void ClearAllGiocatori_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void TextBoxPulsante_KeyDownPlus(TextBoxPlus<Keys?> s, KeyEventArgs ee)
        {
            if (KeyInUseOtherGiocatore(ee.KeyCode) || KeyCurrentSet(ee.KeyCode,s))
            {
                s.TextObject = null;
                s.BackColor = Color.LightSalmon;
            }
            else
            {
                s.TextObject = ee.KeyCode;
                s.BackColor = Color.LightGreen;
            }
            ee.Handled = true;
            ee.SuppressKeyPress = true;
        }

        private bool KeyInUseOtherGiocatore(Keys k)
        {
            foreach(Giocatore g in listBox1.Items)
            {
                foreach(KeyValuePair<Keys, Pulsante> kv in g.ComandiAssociati)
                {
                    if (kv.Key == k)
                        return true;
                }
            }
            return false;
        }
        private bool KeyCurrentSet(Keys k,params TextBoxPlus<Keys?>[] ExcudedTextbox)
        {

            if (!ExcudedTextbox.Contains(textBoxXX) && textBoxXX.TextObject != null && textBoxXX.TextObject.Value == k)
                return true;
            else if (!ExcudedTextbox.Contains(textBoxQQ) && textBoxQQ.TextObject != null && textBoxQQ.TextObject.Value == k)
                return true;
            else if (!ExcudedTextbox.Contains(textBoxTT) && textBoxTT.TextObject != null && textBoxTT.TextObject.Value == k)
                return true;
            else if (!ExcudedTextbox.Contains(textBoxCC) && textBoxCC.TextObject != null && textBoxCC.TextObject.Value == k)
                return true;

            return false;
        }

        private void PulisciCampi()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxXX.TextObject = null;
            textBoxQQ.TextObject = null;
            textBoxTT.TextObject = null;
            textBoxCC.TextObject = null;

            textBoxXX.BackColor = Color.White;
            textBoxQQ.BackColor = Color.White;
            textBoxTT.BackColor = Color.White;
            textBoxCC.BackColor = Color.White;
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salva la lista di giocatori";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {

                using (FileStream s = (FileStream)saveFileDialog1.OpenFile())
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        List<Giocatore> g = new List<Giocatore>(listBox1.Items.Cast<Giocatore>());
                        sw.WriteLine(Json.Serialize(g));
                    }
                }
            }
        }
        private void button_inport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Apri una lista di giocatori";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream s = (FileStream)openFileDialog1.OpenFile())
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        List<Giocatore> lg = Json.Deserialize<List<Giocatore>>(sr.ReadToEnd());
                        PulisciCampi();

                        bool UnoNonAggiunto = false;
        
                        foreach (Giocatore g in lg)
                        {
                            bool DaAggiungere = true;
                            foreach (KeyValuePair<Keys, Pulsante> kv in g.ComandiAssociati)
                            {
                                if (KeyInUseOtherGiocatore(kv.Key))
                                {
                                    DaAggiungere = false;
                                    UnoNonAggiunto = true;
                                    break;
                                }
                            }
                            if(DaAggiungere)
                                listBox1.Items.Add(g);
                        }
                        if(UnoNonAggiunto)
                            MessageBox.Show("Attenzione!\r\nAlcuni giocatori non sono stati caricati in quanto i loro Comandi Associati sono incompatibili con quelli associati agli altri giocatori gia in lista.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        




                    }
                }
            }
        }
        private void EditDomande_Click(object sender, EventArgs e)
        {
            new EditDomande().ShowDialog();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 2)
            {
                MessageBox.Show("Inserire almeno 2 giocatori");
                return;
            }
            List<Giocatore> Giocatori = new List<Giocatore>(listBox1.Items.Cast<Giocatore>());

            new Thread(() =>
            {
                DottorWhyForm dw = new DottorWhyForm(Giocatori);
                dw.ShowDialog();
            }).Start();

            this.Close();
        }


    }
}
