namespace NavKids
{
    partial class FormPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tSlide = new System.Windows.Forms.Timer(this.components);
            this.NavPanelForm = new System.Windows.Forms.Panel();
            this.tUso = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tSlide
            // 
            this.tSlide.Interval = 1;
            this.tSlide.Tick += new System.EventHandler(this.tSlide_Tick);
            // 
            // NavPanelForm
            // 
            this.NavPanelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavPanelForm.Location = new System.Drawing.Point(50, 0);
            this.NavPanelForm.Margin = new System.Windows.Forms.Padding(0);
            this.NavPanelForm.Name = "NavPanelForm";
            this.NavPanelForm.Size = new System.Drawing.Size(1060, 726);
            this.NavPanelForm.TabIndex = 8;
            // 
            // tUso
            // 
            this.tUso.Interval = 10000;
            this.tUso.Tick += new System.EventHandler(this.tUso_Tick);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(122)))));
            this.menuPanel.BackgroundImage = global::NavKids.Properties.Resources.pattern_2;
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.btnJogo);
            this.menuPanel.Controls.Add(this.btnSair);
            this.menuPanel.Controls.Add(this.btnConfiguracoes);
            this.menuPanel.Controls.Add(this.btnNavegador);
            this.menuPanel.Controls.Add(this.btnMenu);
            this.menuPanel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(233, 726);
            this.menuPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::NavKids.Properties.Resources.LogoMarcaBranco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 665);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 61);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnJogo
            // 
            this.btnJogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnJogo.FlatAppearance.BorderSize = 0;
            this.btnJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogo.ForeColor = System.Drawing.Color.White;
            this.btnJogo.Image = global::NavKids.Properties.Resources.rsz_mouse;
            this.btnJogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJogo.Location = new System.Drawing.Point(-3, 384);
            this.btnJogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnJogo.Name = "btnJogo";
            this.btnJogo.Size = new System.Drawing.Size(233, 50);
            this.btnJogo.TabIndex = 4;
            this.btnJogo.Text = "Jogar";
            this.btnJogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJogo.UseVisualStyleBackColor = false;
            this.btnJogo.Click += new System.EventHandler(this.btnJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(-3, 445);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(233, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Image = global::NavKids.Properties.Resources.rsz_settings;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(-3, 317);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(233, 50);
            this.btnConfiguracoes.TabIndex = 2;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNavegador.BackColor = System.Drawing.Color.Transparent;
            this.btnNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavegador.FlatAppearance.BorderSize = 0;
            this.btnNavegador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnNavegador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavegador.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegador.ForeColor = System.Drawing.Color.White;
            this.btnNavegador.Image = global::NavKids.Properties.Resources.rsz_1compass;
            this.btnNavegador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavegador.Location = new System.Drawing.Point(-3, 250);
            this.btnNavegador.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(233, 50);
            this.btnNavegador.TabIndex = 1;
            this.btnNavegador.Text = "Navegar";
            this.btnNavegador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavegador.UseVisualStyleBackColor = false;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::NavKids.Properties.Resources.menu_Button;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 51);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 726);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.NavPanelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1126, 726);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavKids";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer tSlide;
        private System.Windows.Forms.Panel NavPanelForm;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer tUso;
        private System.Windows.Forms.Button btnJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

