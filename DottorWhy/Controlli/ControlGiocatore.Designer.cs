namespace DottorWhy.Controlli
{
    partial class ControlGiocatore
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nome = new System.Windows.Forms.Label();
            this.label_Punteggio = new System.Windows.Forms.Label();
            this.label_Pulsante = new System.Windows.Forms.Label();
            this.label_Messaggio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nome.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.Red;
            this.label_nome.Location = new System.Drawing.Point(3, 3);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(139, 23);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "label1";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Punteggio
            // 
            this.label_Punteggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Punteggio.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Punteggio.ForeColor = System.Drawing.Color.Black;
            this.label_Punteggio.Location = new System.Drawing.Point(3, 26);
            this.label_Punteggio.Name = "label_Punteggio";
            this.label_Punteggio.Size = new System.Drawing.Size(139, 34);
            this.label_Punteggio.TabIndex = 1;
            this.label_Punteggio.Text = "label1";
            this.label_Punteggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Pulsante
            // 
            this.label_Pulsante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Pulsante.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pulsante.ForeColor = System.Drawing.Color.Black;
            this.label_Pulsante.Location = new System.Drawing.Point(3, 78);
            this.label_Pulsante.Name = "label_Pulsante";
            this.label_Pulsante.Size = new System.Drawing.Size(139, 23);
            this.label_Pulsante.TabIndex = 1;
            this.label_Pulsante.Text = "label1";
            this.label_Pulsante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Messaggio
            // 
            this.label_Messaggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Messaggio.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Messaggio.ForeColor = System.Drawing.Color.Black;
            this.label_Messaggio.Location = new System.Drawing.Point(3, 101);
            this.label_Messaggio.Name = "label_Messaggio";
            this.label_Messaggio.Size = new System.Drawing.Size(139, 23);
            this.label_Messaggio.TabIndex = 1;
            this.label_Messaggio.Text = "label1";
            this.label_Messaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlGiocatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_Messaggio);
            this.Controls.Add(this.label_Pulsante);
            this.Controls.Add(this.label_Punteggio);
            this.Controls.Add(this.label_nome);
            this.Name = "ControlGiocatore";
            this.Size = new System.Drawing.Size(145, 127);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlGiocatore_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label_nome;
        public System.Windows.Forms.Label label_Punteggio;
        public System.Windows.Forms.Label label_Pulsante;
        public System.Windows.Forms.Label label_Messaggio;
    }
}
