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
namespace DottorWhy
{
    public partial class Setup : Form
    {

       
        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giocatore g = null;
            if (textBox1.Text.Trim()=="")
            {
               g  = new Giocatore("Giocatore " + listBox1.Items.Count);

            }
            else
            {
                g = new Giocatore(textBox1.Text.Trim());
            }


            if(textBox2.Text.Trim().IsInt())
            {
                g.Punteggio = textBox2.Text.Trim().ParseInt();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Add(g);


           
        }

        private void Setup_Load(object sender, EventArgs e)
        {
           foreach( Control c in this.GetControl(true))
            {
                c.KeyDown += (object s, KeyEventArgs ee) =>
                {
                    if(ee.Control && ee.Alt && ee.Shift && ee.KeyCode==Keys.V)
                    {
                        label2.Visible = !label2.Visible;
                        textBox2.Visible = !textBox2.Visible;
                    }

                };
            }

            textBoxX.KeyDown += (object s, KeyEventArgs ee) =>
            {
                ((TextBox)sender).Text = ee.KeyCode.ToString();

            };
        }

  

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<Giocatore, Dictionary<Keys, Pulsante>> Giocatori = new Dictionary<Giocatore, Dictionary<Keys, Pulsante>>();

            
        }
    }
}
