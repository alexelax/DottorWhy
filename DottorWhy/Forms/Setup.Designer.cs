using ExtendCSharp;
using System.Windows.Forms;

namespace DottorWhy.Forms
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_inport = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panelloDisegno4 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno3 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno2 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno1 = new DottorWhy.Controlli.PanelloDisegno();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(229, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 303);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ninja Naruto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Punteggio Start";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddGiocatore_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveGiocatore_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Ninja Naruto", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(41, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(87, 128);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(87, 165);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 3;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(87, 200);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 3;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(87, 238);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "File salvataggio Giocatori | *.gdw";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "Pulisci";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearAllGiocatori_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::DottorWhy.Properties.Resources.edit_256;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(8, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 28);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.EditDomande_Click);
            // 
            // button_inport
            // 
            this.button_inport.BackgroundImage = global::DottorWhy.Properties.Resources._in;
            this.button_inport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_inport.Location = new System.Drawing.Point(346, 333);
            this.button_inport.Name = "button_inport";
            this.button_inport.Size = new System.Drawing.Size(30, 28);
            this.button_inport.TabIndex = 5;
            this.button_inport.UseVisualStyleBackColor = true;
            this.button_inport.Click += new System.EventHandler(this.button_inport_Click);
            // 
            // button_save
            // 
            this.button_save.BackgroundImage = global::DottorWhy.Properties.Resources.save;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Location = new System.Drawing.Point(310, 333);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(30, 28);
            this.button_save.TabIndex = 5;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panelloDisegno4
            // 
            this.panelloDisegno4.AspectRateo = 1;
            this.panelloDisegno4.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Cerchio;
            this.panelloDisegno4.Location = new System.Drawing.Point(35, 238);
            this.panelloDisegno4.Margine = 3;
            this.panelloDisegno4.Name = "panelloDisegno4";
            this.panelloDisegno4.Size = new System.Drawing.Size(21, 21);
            this.panelloDisegno4.TabIndex = 10;
            // 
            // panelloDisegno3
            // 
            this.panelloDisegno3.AspectRateo = 1;
            this.panelloDisegno3.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Triangolo;
            this.panelloDisegno3.Location = new System.Drawing.Point(34, 200);
            this.panelloDisegno3.Margine = 3;
            this.panelloDisegno3.Name = "panelloDisegno3";
            this.panelloDisegno3.Size = new System.Drawing.Size(23, 23);
            this.panelloDisegno3.TabIndex = 9;
            // 
            // panelloDisegno2
            // 
            this.panelloDisegno2.AspectRateo = 1;
            this.panelloDisegno2.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Quadrato;
            this.panelloDisegno2.Location = new System.Drawing.Point(36, 165);
            this.panelloDisegno2.Margine = 2;
            this.panelloDisegno2.Name = "panelloDisegno2";
            this.panelloDisegno2.Size = new System.Drawing.Size(19, 19);
            this.panelloDisegno2.TabIndex = 8;
            // 
            // panelloDisegno1
            // 
            this.panelloDisegno1.AspectRateo = 1;
            this.panelloDisegno1.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.ICCESE;
            this.panelloDisegno1.Location = new System.Drawing.Point(36, 128);
            this.panelloDisegno1.Margine = 2;
            this.panelloDisegno1.Name = "panelloDisegno1";
            this.panelloDisegno1.Size = new System.Drawing.Size(18, 18);
            this.panelloDisegno1.TabIndex = 7;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 446);
            this.Controls.Add(this.panelloDisegno4);
            this.Controls.Add(this.panelloDisegno3);
            this.Controls.Add(this.panelloDisegno2);
            this.Controls.Add(this.panelloDisegno1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_inport);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxC;
        private Button button_inport;
        private Button button_save;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private Button button5;
        private Controlli.PanelloDisegno panelloDisegno1;
        private Controlli.PanelloDisegno panelloDisegno2;
        private Controlli.PanelloDisegno panelloDisegno3;
        private Controlli.PanelloDisegno panelloDisegno4;
    }
}