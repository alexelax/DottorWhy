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

namespace DottorWhy.Controlli
{
    public partial class PanelloDisegno : UserControl
    {
        Disegno _DisegnoCorrente = Disegno.nul;
        public Disegno DisegnoCorrente {
            get { return _DisegnoCorrente; }
            set
            {
                _DisegnoCorrente = value;
                PanelloDisegno_Resize(null, null);
                Invalidate();
            }
        }


        public int Margine { get; set; } = 2;
        public int AspectRateo { get; set; } = 1;
        public Pen Penna { get; set; } = new Pen(Color.Black,10);


        public PanelloDisegno()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(DisegnoCorrente== Disegno.ICCESE)
            {
                e.Graphics.DrawLine(Penna, Margine, Margine, Width - Margine, Height - Margine);
                e.Graphics.DrawLine(Penna,Width- Margine, Margine, Margine, Height - Margine);
            }
            else if (DisegnoCorrente == Disegno.Quadrato)
            {
                e.Graphics.DrawPolygon(Penna,new Point(Margine, Margine), new Point(Width - Margine, Margine), new Point(Width - Margine, Height-Margine), new Point(Margine, Height - Margine));
            }
            else if (DisegnoCorrente == Disegno.Triangolo)
            {
                e.Graphics.DrawPolygon(Penna, new Point(Margine +(int)(Penna.Width/2), Height-(Margine)), new Point(Width /2, Margine+ (int)(Penna.Width / 2)), new Point(Width - (Margine+ (int)(Penna.Width / 2)), Height - (Margine)));
            }
            else if (DisegnoCorrente == Disegno.Cerchio)
            {
                e.Graphics.DrawCircle(Penna,Width/2,Height/2,(Width-2*Margine)/2);
            }
        }
        private void PanelloDisegno_Resize(object sender, EventArgs e)
        {
            Margine = Size.Width / 7;
            Penna = new Pen(Color.Black, Size.Width / 4);
            Size = new Size(Size.Width, Size.Width * AspectRateo);
        }


        public enum Disegno
        {
            ICCESE,
            Quadrato,
            Triangolo,
            Cerchio,
            nul
        }

        
    }
}
