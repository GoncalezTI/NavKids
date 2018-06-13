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
    public partial class JogoAddResposta : UserControl {

        public CResposta resposta = new CResposta();

        public JogoAddResposta() {
            InitializeComponent();
        }

        private void JogoAddResposta_Load(object sender, EventArgs e) {
            if (resposta != null && (resposta.resposta != "" || resposta.resposta != null)) {
                cbCheck.Checked = resposta.certa;
                cbCheck.Tag = resposta.certa;
                rtbTexto.Text = resposta.resposta;
            }
            else {
                cbCheck.Tag = resposta.certa;
            }
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e) {
            resposta.certa = cbCheck.Checked;
            cbCheck.Tag = cbCheck.Checked;
        }

        public void ConfirmarAlteracoes() {
            resposta.resposta = rtbTexto.Text;
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
