using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavKids {
    public partial class SiteControl : UserControl {
        bool hidden = true;
        string site;

        CSitePermitido sitec;

        public SiteControl() {
            InitializeComponent();
        }

        public SiteControl(string site) {
            InitializeComponent();
            this.site = site;
            lblSite.Text = site;
            btnEditar.Tag = btnExcluir.Tag = site;
        }

        public SiteControl(CSitePermitido sitec) {
            InitializeComponent();
            this.sitec = sitec;
            lblSite.Text = this.sitec.site;
            btnEditar.Tag = btnExcluir.Tag = this.sitec.site;
        }

        private void button2_Click(object sender, EventArgs e) {

            if (hidden) {
                lblSite.Size = new Size(331, 37);
                lblSite.Enabled = false;
                textBox1.Text = lblSite.Text;
                btnEditar.Text = "Confirmar";
                hidden = false;
            }
            else {
                sitec.site = textBox1.Text;
                if (DbClass.UpdateSitePermitido(sitec)) {
                    MessageBox.Show("Site atualizado com sucesso!");
                }
                lblSite.Size = new Size(331, 77);
                lblSite.Enabled = true;
                lblSite.Text = textBox1.Text;
                btnEditar.Tag = textBox1.Text;
                btnEditar.Text = "Editar";
                hidden = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (DbClass.DeletSite(sitec)) {
                MessageBox.Show("Site excluido com sucesso!");
            }

        }
    }
}
