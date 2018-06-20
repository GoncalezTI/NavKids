namespace NavKids {
    partial class JogoAddControl {
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.pRespostas = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pQuestoesItem = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pDireita = new System.Windows.Forms.Panel();
            this.btnAdicionarResposta = new System.Windows.Forms.Button();
            this.pNivel = new System.Windows.Forms.Panel();
            this.rbAvancado = new System.Windows.Forms.RadioButton();
            this.rbIntermediario = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.lblNivel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pDireita.SuspendLayout();
            this.pNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.rtbTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbTexto.Location = new System.Drawing.Point(0, 0);
            this.rtbTexto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(742, 286);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // pRespostas
            // 
            this.pRespostas.AutoSize = true;
            this.pRespostas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pRespostas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRespostas.Location = new System.Drawing.Point(0, 351);
            this.pRespostas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pRespostas.MinimumSize = new System.Drawing.Size(0, 209);
            this.pRespostas.Name = "pRespostas";
            this.pRespostas.Size = new System.Drawing.Size(742, 209);
            this.pRespostas.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(409, 582);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(160, 72);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar Alterações";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(579, 582);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(161, 72);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Nova Pergunta";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pQuestoesItem
            // 
            this.pQuestoesItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.pQuestoesItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuestoesItem.Location = new System.Drawing.Point(5, 6);
            this.pQuestoesItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pQuestoesItem.Name = "pQuestoesItem";
            this.pQuestoesItem.Size = new System.Drawing.Size(367, 654);
            this.pQuestoesItem.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.4F));
            this.tableLayoutPanel1.Controls.Add(this.pQuestoesItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDireita, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 666);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pDireita
            // 
            this.pDireita.Controls.Add(this.btnAdicionarResposta);
            this.pDireita.Controls.Add(this.btnConfirmar);
            this.pDireita.Controls.Add(this.btnNovo);
            this.pDireita.Controls.Add(this.pRespostas);
            this.pDireita.Controls.Add(this.pNivel);
            this.pDireita.Controls.Add(this.lblNivel);
            this.pDireita.Controls.Add(this.rtbTexto);
            this.pDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDireita.Location = new System.Drawing.Point(380, 3);
            this.pDireita.Name = "pDireita";
            this.pDireita.Size = new System.Drawing.Size(742, 660);
            this.pDireita.TabIndex = 5;
            // 
            // btnAdicionarResposta
            // 
            this.btnAdicionarResposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarResposta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdicionarResposta.FlatAppearance.BorderSize = 0;
            this.btnAdicionarResposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarResposta.Location = new System.Drawing.Point(226, 582);
            this.btnAdicionarResposta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdicionarResposta.Name = "btnAdicionarResposta";
            this.btnAdicionarResposta.Size = new System.Drawing.Size(173, 72);
            this.btnAdicionarResposta.TabIndex = 4;
            this.btnAdicionarResposta.Text = "Adicionar Nova Resposta";
            this.btnAdicionarResposta.UseVisualStyleBackColor = false;
            this.btnAdicionarResposta.Click += new System.EventHandler(this.btnAdicionarResposta_Click);
            // 
            // pNivel
            // 
            this.pNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.pNivel.Controls.Add(this.rbAvancado);
            this.pNivel.Controls.Add(this.rbIntermediario);
            this.pNivel.Controls.Add(this.rbBasico);
            this.pNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNivel.Location = new System.Drawing.Point(0, 313);
            this.pNivel.Name = "pNivel";
            this.pNivel.Size = new System.Drawing.Size(742, 38);
            this.pNivel.TabIndex = 42;
            this.pNivel.Paint += new System.Windows.Forms.PaintEventHandler(this.pNivel_Paint);
            // 
            // rbAvancado
            // 
            this.rbAvancado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbAvancado.AutoSize = true;
            this.rbAvancado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAvancado.Location = new System.Drawing.Point(493, 3);
            this.rbAvancado.Name = "rbAvancado";
            this.rbAvancado.Size = new System.Drawing.Size(135, 27);
            this.rbAvancado.TabIndex = 37;
            this.rbAvancado.Tag = "AVANCADO";
            this.rbAvancado.Text = "Avançado";
            this.rbAvancado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAvancado.UseVisualStyleBackColor = true;
            this.rbAvancado.Click += new System.EventHandler(this.RbNivel_CheckedChanged);
            // 
            // rbIntermediario
            // 
            this.rbIntermediario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbIntermediario.AutoSize = true;
            this.rbIntermediario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIntermediario.Location = new System.Drawing.Point(296, 3);
            this.rbIntermediario.Name = "rbIntermediario";
            this.rbIntermediario.Size = new System.Drawing.Size(155, 27);
            this.rbIntermediario.TabIndex = 36;
            this.rbIntermediario.Tag = "INTERMEDIARIO";
            this.rbIntermediario.Text = "Intermediário";
            this.rbIntermediario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbIntermediario.UseVisualStyleBackColor = true;
            this.rbIntermediario.Click += new System.EventHandler(this.RbNivel_CheckedChanged);
            // 
            // rbBasico
            // 
            this.rbBasico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBasico.Location = new System.Drawing.Point(132, 3);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(89, 27);
            this.rbBasico.TabIndex = 35;
            this.rbBasico.TabStop = true;
            this.rbBasico.Tag = "BASICO";
            this.rbBasico.Text = "Básico";
            this.rbBasico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.Click += new System.EventHandler(this.RbNivel_CheckedChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNivel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(0, 286);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(742, 27);
            this.lblNivel.TabIndex = 41;
            this.lblNivel.Text = "Nivel da Pergunta";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JogoAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "JogoAddControl";
            this.Size = new System.Drawing.Size(1125, 666);
            this.Load += new System.EventHandler(this.JogoAddControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pDireita.ResumeLayout(false);
            this.pDireita.PerformLayout();
            this.pNivel.ResumeLayout(false);
            this.pNivel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Panel pRespostas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pQuestoesItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pDireita;
        private System.Windows.Forms.Button btnAdicionarResposta;
        private System.Windows.Forms.Panel pNivel;
        private System.Windows.Forms.RadioButton rbAvancado;
        private System.Windows.Forms.RadioButton rbIntermediario;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.Label lblNivel;
    }
}
