namespace DottorWhy
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
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Punteggio = new System.Windows.Forms.TextBox();
            this.textBox_Messaggio = new System.Windows.Forms.TextBox();
            this.textBox_Pulsante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Nome.Location = new System.Drawing.Point(3, 3);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(142, 20);
            this.textBox_Nome.TabIndex = 0;
            this.textBox_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Punteggio
            // 
            this.textBox_Punteggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Punteggio.Location = new System.Drawing.Point(3, 29);
            this.textBox_Punteggio.Name = "textBox_Punteggio";
            this.textBox_Punteggio.Size = new System.Drawing.Size(142, 20);
            this.textBox_Punteggio.TabIndex = 0;
            this.textBox_Punteggio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Messaggio
            // 
            this.textBox_Messaggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Messaggio.Location = new System.Drawing.Point(3, 125);
            this.textBox_Messaggio.Name = "textBox_Messaggio";
            this.textBox_Messaggio.Size = new System.Drawing.Size(142, 20);
            this.textBox_Messaggio.TabIndex = 0;
            this.textBox_Messaggio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Pulsante
            // 
            this.textBox_Pulsante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pulsante.Location = new System.Drawing.Point(3, 99);
            this.textBox_Pulsante.Name = "textBox_Pulsante";
            this.textBox_Pulsante.Size = new System.Drawing.Size(142, 20);
            this.textBox_Pulsante.TabIndex = 0;
            this.textBox_Pulsante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlGiocatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox_Pulsante);
            this.Controls.Add(this.textBox_Messaggio);
            this.Controls.Add(this.textBox_Punteggio);
            this.Controls.Add(this.textBox_Nome);
            this.Name = "ControlGiocatore";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Nome;
        public System.Windows.Forms.TextBox textBox_Punteggio;
        public System.Windows.Forms.TextBox textBox_Messaggio;
        public System.Windows.Forms.TextBox textBox_Pulsante;
    }
}
