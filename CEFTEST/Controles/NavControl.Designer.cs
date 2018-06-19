namespace NavKids
{
    partial class NavControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavControl));
            this.navPanel = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.ChromiumPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(122)))));
            this.navPanel.BackgroundImage = global::NavKids.Properties.Resources.pattern_2;
            this.navPanel.Controls.Add(this.btnVoltar);
            this.navPanel.Controls.Add(this.btnHome);
            this.navPanel.Controls.Add(this.btnAvancar);
            this.navPanel.Controls.Add(this.tbEndereco);
            this.navPanel.Controls.Add(this.btnIr);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(659, 38);
            this.navPanel.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(3, 2);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(54, 34);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::NavKids.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(602, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 34);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvancar.BackgroundImage")));
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvancar.FlatAppearance.BorderSize = 0;
            this.btnAvancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(63, 2);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(54, 34);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEndereco.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.ForeColor = System.Drawing.Color.White;
            this.tbEndereco.Location = new System.Drawing.Point(123, 2);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(413, 33);
            this.tbEndereco.TabIndex = 3;
            this.tbEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEndereco_KeyDown);
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.BackColor = System.Drawing.Color.Transparent;
            this.btnIr.BackgroundImage = global::NavKids.Properties.Resources.triangle;
            this.btnIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIr.FlatAppearance.BorderSize = 0;
            this.btnIr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnIr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIr.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.ForeColor = System.Drawing.Color.White;
            this.btnIr.Location = new System.Drawing.Point(542, 2);
            this.btnIr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(54, 34);
            this.btnIr.TabIndex = 2;
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // ChromiumPanel
            // 
            this.ChromiumPanel.AutoSize = true;
            this.ChromiumPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChromiumPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChromiumPanel.Location = new System.Drawing.Point(0, 38);
            this.ChromiumPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChromiumPanel.Name = "ChromiumPanel";
            this.ChromiumPanel.Size = new System.Drawing.Size(659, 632);
            this.ChromiumPanel.TabIndex = 8;
            // 
            // NavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChromiumPanel);
            this.Controls.Add(this.navPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NavControl";
            this.Size = new System.Drawing.Size(659, 670);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Panel ChromiumPanel;
    }
}
