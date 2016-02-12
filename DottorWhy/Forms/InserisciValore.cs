using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DottorWhy.Forms
{
    public partial class InserisciValore : Form
    {
        public String OldValue
        {
            get; 
        }
        public String NewValue
        {
            get; private set;
        }

        public DialogResult result { get; set; } = DialogResult.None;

        public InserisciValore(String OldValue)
        {
            InitializeComponent();
            this.OldValue = OldValue;
            textBox1.Text = OldValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewValue = textBox1.Text;
            result = DialogResult.OK;
            Close();
        }

        private void InserisciValore_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(result==DialogResult.None)
                result = DialogResult.Cancel;
        }
    }
}
