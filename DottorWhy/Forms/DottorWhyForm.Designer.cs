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
            this.textBox_domanda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_giocatori = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelloDisegno1 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno2 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno3 = new DottorWhy.Controlli.PanelloDisegno();
            this.panelloDisegno4 = new DottorWhy.Controlli.PanelloDisegno();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_domanda
            // 
            this.textBox_domanda.Location = new System.Drawing.Point(12, 12);
            this.textBox_domanda.Multiline = true;
            this.textBox_domanda.Name = "textBox_domanda";
            this.textBox_domanda.Size = new System.Drawing.Size(613, 64);
            this.textBox_domanda.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuova Domanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_giocatori
            // 
            this.panel_giocatori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_giocatori.Location = new System.Drawing.Point(12, 192);
            this.panel_giocatori.Name = "panel_giocatori";
            this.panel_giocatori.Size = new System.Drawing.Size(970, 321);
            this.panel_giocatori.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // panelloDisegno1
            // 
            this.panelloDisegno1.AspectRateo = 1;
            this.panelloDisegno1.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Triangolo;
            this.panelloDisegno1.Location = new System.Drawing.Point(327, 133);
            this.panelloDisegno1.Margine = 4;
            this.panelloDisegno1.Name = "panelloDisegno1";
            this.panelloDisegno1.Size = new System.Drawing.Size(34, 34);
            this.panelloDisegno1.TabIndex = 7;
            // 
            // panelloDisegno2
            // 
            this.panelloDisegno2.AspectRateo = 1;
            this.panelloDisegno2.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Quadrato;
            this.panelloDisegno2.Location = new System.Drawing.Point(12, 133);
            this.panelloDisegno2.Margine = 4;
            this.panelloDisegno2.Name = "panelloDisegno2";
            this.panelloDisegno2.Size = new System.Drawing.Size(34, 34);
            this.panelloDisegno2.TabIndex = 7;
            // 
            // panelloDisegno3
            // 
            this.panelloDisegno3.AspectRateo = 1;
            this.panelloDisegno3.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.ICCESE;
            this.panelloDisegno3.Location = new System.Drawing.Point(12, 82);
            this.panelloDisegno3.Margine = 4;
            this.panelloDisegno3.Name = "panelloDisegno3";
            this.panelloDisegno3.Size = new System.Drawing.Size(34, 34);
            this.panelloDisegno3.TabIndex = 7;
            // 
            // panelloDisegno4
            // 
            this.panelloDisegno4.AspectRateo = 1;
            this.panelloDisegno4.DisegnoCorrente = DottorWhy.Controlli.PanelloDisegno.Disegno.Cerchio;
            this.panelloDisegno4.Location = new System.Drawing.Point(327, 82);
            this.panelloDisegno4.Margine = 4;
            this.panelloDisegno4.Name = "panelloDisegno4";
            this.panelloDisegno4.Size = new System.Drawing.Size(34, 34);
            this.panelloDisegno4.TabIndex = 7;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(68, 82);
            this.textBox_X.Multiline = true;
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(242, 34);
            this.textBox_X.TabIndex = 3;
            // 
            // textBox_Q
            // 
            this.textBox_Q.Location = new System.Drawing.Point(68, 133);
            this.textBox_Q.Multiline = true;
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(242, 34);
            this.textBox_Q.TabIndex = 3;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(383, 82);
            this.textBox_C.Multiline = true;
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(242, 34);
            this.textBox_C.TabIndex = 3;
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(383, 133);
            this.textBox_T.Multiline = true;
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(242, 34);
            this.textBox_T.TabIndex = 3;
            // 
            // DottorWhyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 525);
            this.Controls.Add(this.panelloDisegno4);
            this.Controls.Add(this.panelloDisegno3);
            this.Controls.Add(this.panelloDisegno2);
            this.Controls.Add(this.panelloDisegno1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_giocatori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.textBox_domanda);
            this.Name = "DottorWhyForm";
            this.Text = "Form1";
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
    }
}

