namespace NavKids {
    partial class JogoAddResposta {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.cbCheck = new System.Windows.Forms.RadioButton();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCheck.Location = new System.Drawing.Point(27, 24);
            this.cbCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(13, 12);
            this.cbCheck.TabIndex = 0;
            this.cbCheck.TabStop = true;
            this.cbCheck.UseVisualStyleBackColor = true;
            this.cbCheck.CheckedChanged += new System.EventHandler(this.cbCheck_CheckedChanged);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTexto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtbTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTexto.ForeColor = System.Drawing.Color.White;
            this.rtbTexto.Location = new System.Drawing.Point(66, 0);
            this.rtbTexto.MinimumSize = new System.Drawing.Size(600, 58);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(779, 59);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "aaaaaaaaaaaasdasdasdasdaaaaaaaaaaaaasdasdasdasdaaaaaaaaaaaaasdasdasdasdaaaaaaaaaa" +
    "aaasdasdasdasdaaaaaaaaaaaaasdasdasdasdaaaaaaaaaaaaasdasdasdasda";
            this.rtbTexto.TextChanged += new System.EventHandler(this.rtbTexto_TextChanged);
            // 
            // JogoAddResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.cbCheck);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "JogoAddResposta";
            this.Size = new System.Drawing.Size(845, 59);
            this.Load += new System.EventHandler(this.JogoAddResposta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbTexto;
        public System.Windows.Forms.RadioButton cbCheck;
    }
}
