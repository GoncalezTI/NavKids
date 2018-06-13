namespace NavKids
{
    partial class HistControl
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
            this.lblDataHeader = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHoraHeader = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSiteHeader = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.pSpliter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelHist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataHeader
            // 
            this.lblDataHeader.AutoSize = true;
            this.lblDataHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblDataHeader.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataHeader.Location = new System.Drawing.Point(3, 2);
            this.lblDataHeader.Name = "lblDataHeader";
            this.lblDataHeader.Size = new System.Drawing.Size(33, 13);
            this.lblDataHeader.TabIndex = 0;
            this.lblDataHeader.Text = "Data";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(2, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(96, 21);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "25/06/2018";
            // 
            // lblHoraHeader
            // 
            this.lblHoraHeader.AutoSize = true;
            this.lblHoraHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraHeader.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHoraHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHoraHeader.Name = "lblHoraHeader";
            this.lblHoraHeader.Size = new System.Drawing.Size(32, 13);
            this.lblHoraHeader.TabIndex = 2;
            this.lblHoraHeader.Text = "Hora";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(2, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 21);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "15:45";
            // 
            // lblSiteHeader
            // 
            this.lblSiteHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSiteHeader.AutoSize = true;
            this.lblSiteHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSiteHeader.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSiteHeader.Location = new System.Drawing.Point(36, 1);
            this.lblSiteHeader.Name = "lblSiteHeader";
            this.lblSiteHeader.Size = new System.Drawing.Size(27, 13);
            this.lblSiteHeader.TabIndex = 4;
            this.lblSiteHeader.Text = "Site";
            // 
            // lblSite
            // 
            this.lblSite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSite.AutoSize = true;
            this.lblSite.BackColor = System.Drawing.Color.Transparent;
            this.lblSite.ForeColor = System.Drawing.Color.Black;
            this.lblSite.Location = new System.Drawing.Point(35, 14);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(330, 23);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "http://www.youtube.com/home";
            // 
            // pSpliter
            // 
            this.pSpliter.BackColor = System.Drawing.Color.Gainsboro;
            this.pSpliter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSpliter.Location = new System.Drawing.Point(0, 80);
            this.pSpliter.Name = "pSpliter";
            this.pSpliter.Size = new System.Drawing.Size(401, 3);
            this.pSpliter.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblDataHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 40);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lblHoraHeader);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(290, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 40);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblSite);
            this.panel3.Controls.Add(this.lblSiteHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 37);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btnDelHist);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 40);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 40);
            this.panel5.TabIndex = 12;
            // 
            // btnDelHist
            // 
            this.btnDelHist.BackgroundImage = global::NavKids.Properties.Resources.garbage;
            this.btnDelHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelHist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelHist.FlatAppearance.BorderSize = 0;
            this.btnDelHist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelHist.Location = new System.Drawing.Point(345, 0);
            this.btnDelHist.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelHist.Name = "btnDelHist";
            this.btnDelHist.Size = new System.Drawing.Size(56, 40);
            this.btnDelHist.TabIndex = 6;
            this.btnDelHist.UseVisualStyleBackColor = true;
            this.btnDelHist.Click += new System.EventHandler(this.btnDelHist_Click);
            // 
            // HistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pSpliter);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(401, 0);
            this.Name = "HistControl";
            this.Size = new System.Drawing.Size(401, 83);
            this.SizeChanged += new System.EventHandler(this.HistControl_SizeChanged);
            this.MouseLeave += new System.EventHandler(this.HistControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.HistControl_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDataHeader;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHoraHeader;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSiteHeader;
        private System.Windows.Forms.Label lblSite;
        public System.Windows.Forms.Button btnDelHist;
        private System.Windows.Forms.Panel pSpliter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
