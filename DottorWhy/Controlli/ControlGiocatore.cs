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
using ExtendCSharp.Services;

namespace DottorWhy.Controlli
{
    public partial class ControlGiocatore : UserControl
    {
        List<int> ComboMenuSEGRETOOOOOO = new List<int>();


        private Giocatore Parent;
        public ControlGiocatore(Giocatore Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

            this.GetControl(true).ForEach(c => c.MouseUp += ControlGiocatore_MouseUp);

            
            //sarebbe meglio metterlo nelle global var...

            ComboMenuSEGRETOOOOOO.Add((int)Keys.LControlKey); //control left
            ComboMenuSEGRETOOOOOO.Add(0x12); //Alt
            ComboMenuSEGRETOOOOOO.Add((int)Keys.D);     //tasto D
        }

        private void ControlGiocatore_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                foreach (int i in ComboMenuSEGRETOOOOOO)
                {
                    if (KeyboardService.GetKeyState(i).KeyStat ==MyKeyboardEvent.KeyStatus.None || KeyboardService.GetKeyState(i).KeyStat == MyKeyboardEvent.KeyStatus.Up)
                        return;
                }



                if (Parent!=null)
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
