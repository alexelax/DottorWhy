using DottorWhy.Controlli;

namespace DottorWhy.Forms
{
    partial class DottorWhyForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DottorWhyForm));
            this.textBox_domanda = new System.Windows.Forms.TextBox();
            this.panel_giocatori = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelloDisegno2 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno3 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno4 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno1 = new DottorWhy.Controlli.PanelloDisegno();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_domanda
            // 
            this.textBox_domanda.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_domanda.Location = new System.Drawing.Point(399, 78);
            this.textBox_domanda.Multiline = true;
            this.textBox_domanda.Name = "textBox_domanda";
            this.textBox_domanda.Size = new System.Drawing.Size(643, 144);
            this.textBox_domanda.TabIndex = 3;
            this.textBox_domanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_giocatori
            // 
            this.panel_giocatori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_giocatori.BackColor = System.Drawing.Color.Transparent;
            this.panel_giocatori.Location = new System.Drawing.Point(12, 440);
            this.panel_giocatori.Name = "panel_giocatori";
            this.panel_giocatori.Size = new System.Drawing.Size(1058, 127);
            this.panel_giocatori.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 108);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer";
            // 
            // textBox_X
            // 
            this.textBox_X.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_X.Location = new System.Drawing.Point(97, 245);
            this.textBox_X.Multiline = true;
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(285, 61);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Q
            // 
            this.textBox_Q.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Q.Location = new System.Drawing.Point(97, 312);
            this.textBox_Q.Multiline = true;
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(285, 57);
            this.textBox_Q.TabIndex = 3;
            this.textBox_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_C
            // 
            this.textBox_C.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_C.Location = new System.Drawing.Point(97, 178);
            this.textBox_C.Multiline = true;
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(285, 61);
            this.textBox_C.TabIndex = 3;
            this.textBox_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_T
            // 
            this.textBox_T.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_T.Location = new System.Drawing.Point(97, 111);
            this.textBox_T.Multiline = true;
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(285, 61);
            this.textBox_T.TabIndex = 3;
            this.textBox_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOMANDA";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 187);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuova Domanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "RISPOSTE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(934, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 56);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset Classifica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelloDisegno2
            // 
            this.panelloDisegno2.AspectRateo = 1;
            this.panelloDisegno2.BackgroundImage = global::DottorWhy.Properties.Resources.Tasto_Q_Why;
            this.panelloDisegno2.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.nul;
            this.panelloDisegno2.Location = new System.Drawing.Point(30, 312);
            this.panelloDisegno2.Margine = 8;
            this.panelloDisegno2.Name = "panelloDisegno2";
            this.panelloDisegno2.Size = new System.Drawing.Size(57, 57);
            this.panelloDisegno2.TabIndex = 7;
            // 
            // panelloDisegno3
            // 
            this.panelloDisegno3.AspectRateo = 1;
            this.panelloDisegno3.BackgroundImage = global::DottorWhy.Properties.Resources.Tasto_X_Why;
            this.panelloDisegno3.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.nul;
            this.panelloDisegno3.Location = new System.Drawing.Point(30, 245);
            this.panelloDisegno3.Margine = 8;
            this.panelloDisegno3.Name = "panelloDisegno3";
            this.panelloDisegno3.Size = new System.Drawing.Size(61, 61);
            this.panelloDisegno3.TabIndex = 7;
            // 
            // panelloDisegno4
            // 
            this.panelloDisegno4.AspectRateo = 1;
            this.panelloDisegno4.BackgroundImage = global::DottorWhy.Properties.Resources.Tasto_C_Why;
            this.panelloDisegno4.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.nul;
            this.panelloDisegno4.Location = new System.Drawing.Point(30, 178);
            this.panelloDisegno4.Margine = 8;
            this.panelloDisegno4.Name = "panelloDisegno4";
            this.panelloDisegno4.Size = new System.Drawing.Size(61, 61);
            this.panelloDisegno4.TabIndex = 7;
            // 
            // panelloDisegno1
            // 
            this.panelloDisegno1.AspectRateo = 1;
            this.panelloDisegno1.BackgroundImage = global::DottorWhy.Properties.Resources.Tasto_T_Why;
            this.panelloDisegno1.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.nul;
            this.panelloDisegno1.Location = new System.Drawing.Point(30, 111);
            this.panelloDisegno1.Margine = 8;
            this.panelloDisegno1.Name = "panelloDisegno1";
            this.panelloDisegno1.Size = new System.Drawing.Size(61, 61);
            this.panelloDisegno1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(934, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "GOOO !!!!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DottorWhyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 629);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.panelloDisegno2);
            this.Controls.Add(this.panelloDisegno3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelloDisegno4);
            this.Controls.Add(this.panelloDisegno1);
            this.Controls.Add(this.panel_giocatori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_domanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DottorWhyForm";
            this.Text = "Dr.Why";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_domanda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_giocatori;
        private System.Windows.Forms.Label label1;
        private PanelloDisegno panelloDisegno1;
        private PanelloDisegno panelloDisegno2;
        private PanelloDisegno panelloDisegno3;
        private PanelloDisegno panelloDisegno4;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

