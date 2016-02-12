using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtendCSharp;
using DottorWhy.Classes;
using DottorWhy.Forms;
using ExtendCSharp;

namespace DottorWhy.Controlli
{
    public partial class ControlGiocatore : UserControl
    {
        private Giocatore Parent;
        public ControlGiocatore(Giocatore Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

            this.GetControl(true).ForEach(c => c.MouseUp += ControlGiocatore_MouseUp);

        }

        private void ControlGiocatore_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(Parent!=null)
                {
                    InserisciValore iv = new InserisciValore(Parent.Punteggio + "");
      
                    iv.ShowDialog();

                    if(iv.result==DialogResult.OK)
                    {
                        if (iv.NewValue.IsInt())
                            Parent.Punteggio = iv.NewValue.ParseInt();
                        else
                            Parent.Punteggio = 0;
                    }
                   
                   


                }
            }
        }
    }
}
