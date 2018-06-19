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
    public partial class ConfigControl : UserControl {
        List<CUsuario> listaUsuarios = new List<CUsuario>();
        CUsuario usuario;
        string nivelJogoAux;

        public ConfigControl() {
            InitializeComponent();
            cbMaxUso.SelectedIndex = 0;
            pHistItens.Controls.Clear();
            AtualizaComboBox();

        }

        private void AtualizaComboBox() {
            cbUsuarioHist.Items.Clear();
            listaUsuarios = DbClass.GetUsers();

            foreach (CUsuario user in listaUsuarios) {
                cbUsuarioHist.Items.Add(user.Usuario);
                //HistControl add = new HistControl() {
                //    Dock = DockStyle.Top
                //};
                //add.btnDelHist.Click += BtnDelHist_Click;
                //panel3.Controls.Add(new HistControl() { Dock = DockStyle.Top });
                //pHistItens.Controls.Add(add);
            }
            cbUsuarioHist.SelectedIndex = 0;
            ///*listaUsuarios.Find(x => x.Usuario == "User1");*/

            //panel2.Controls.Add(new SiteControl());
        }

        private void BtnDelHist_Click(object sender, EventArgs e) {
            //MessageBox.Show(((Button)sender).Tag.ToString());
            if (bool.Parse(((Button)sender).Tag.ToString())) {
                AtualizaHistorico();
            }
            else {
                MessageBox.Show(usuario.DelLinhaHistorico(int.Parse(((Button)sender).Tag.ToString())).ToString());

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            pHistItens.Controls.Clear();
            panel2.Controls.Clear();

            usuario = listaUsuarios.Find(x => x.Usuario == cbUsuarioHist.Text);
            nivelJogoAux = usuario.NivelJogo;
            if (nivelJogoAux == "BASICO") {
                rbBasico.Checked = true;
            }
            else if (nivelJogoAux == "INTERMEDIARIO") {
                rbIntermediario.Checked = true;
            }
            else {
                rbAvancado.Checked = true;
            }
            if (usuario.Administrador) {
                cbuSegunda.Enabled =
                    cbuTerca.Enabled =
                    cbuQuarta.Enabled =
                    cbuQuinta.Enabled =
                    cbuSexta.Enabled =
                    cbuSabado.Enabled =
                    cbuDomingo.Enabled =
                    lbluMaxUso.Enabled =
                    cbuMaxUso.Enabled =
                    rbBasico.Enabled =
                    rbIntermediario.Enabled =
                    rbAvancado.Enabled = false;
            }
            else {
                cbuSegunda.Enabled =
                    cbuTerca.Enabled =
                    cbuQuarta.Enabled =
                    cbuQuinta.Enabled =
                    cbuSexta.Enabled =
                    cbuSabado.Enabled =
                    cbuDomingo.Enabled =
                    lbluMaxUso.Enabled =
                    cbuMaxUso.Enabled =
                    rbBasico.Enabled =
                    rbIntermediario.Enabled =
                    rbAvancado.Enabled =
                    cbuMaxUso.Enabled =
                    lbluMaxUso.Enabled = true;

                cbuSegunda.Checked = usuario.DiasSemana[1];
                cbuTerca.Checked = usuario.DiasSemana[2];
                cbuQuarta.Checked = usuario.DiasSemana[3];
                cbuQuinta.Checked = usuario.DiasSemana[4];
                cbuSexta.Checked = usuario.DiasSemana[5];
                cbuSabado.Checked = usuario.DiasSemana[6];
                cbuDomingo.Checked = usuario.DiasSemana[0];
                cbuMaxUso.SelectedItem = usuario.TempoMaxUso;

                if (usuario.NivelJogo == "BASICO") {
                    rbBasico.Checked = true;
                }
                else if (usuario.NivelJogo == "INTERMEDIARIO") {
                    rbIntermediario.Checked = true;
                }
                else {
                    rbAvancado.Checked = true;
                }
            }

            AtualizaHistorico();
            AtualizaSitesPermitidos();
        }

        private void AtualizaSitesPermitidos() {
            panel2.Controls.Clear();
            usuario.AtualizaSitesPermitidos();
            foreach (CSitePermitido sitePermitido in usuario.SitesPermitidos) {
                SiteControl odd = new SiteControl(sitePermitido) { Dock = DockStyle.Top };

                odd.btnEditar.Click += btnSitePermitidos_Click;
                odd.btnExcluir.Click += btnSitePermitidos_Click;

                panel2.Controls.Add(odd);
            }
        }

        private void AtualizaHistorico() {
            usuario.AtualizaHistorico();
            pHistItens.Controls.Clear();
            foreach (CHistorico hist in (usuario.Historico)) {
                HistControl foo = new HistControl(hist) {
                    Dock = DockStyle.Top,
                };
                foo.btnDelHist.Click += BtnDelHist_Click;
                pHistItens.Controls.Add(foo);
            }
        }

        private void cbAdministrador_CheckedChanged(object sender, EventArgs e) {
            if (cbAdministrador.Checked) {
                cbSegunda.Enabled =
                    cbTerca.Enabled =
                    cbQuarta.Enabled =
                    cbQuinta.Enabled =
                    cbSexta.Enabled =
                    cbSabado.Enabled =
                    cbDomingo.Enabled =
                    lblMaxUso.Enabled =
                    cbMaxUso.Enabled = false;
            }
            else {
                cbSegunda.Enabled =
                    cbTerca.Enabled =
                    cbQuarta.Enabled =
                    cbQuinta.Enabled =
                    cbSexta.Enabled =
                    cbSabado.Enabled =
                    cbDomingo.Enabled =
                    lblMaxUso.Enabled =
                    cbMaxUso.Enabled = true;
            }
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e) {
            if (tbLogin.Text != "" && tbSenha.Text != "") {
                CUsuario novoUsuario = new CUsuario() {
                    Usuario = tbLogin.Text,
                    Senha = tbSenha.Text,
                    Administrador = cbAdministrador.Checked,
                    DiasSemana = new bool[] {
                        cbDomingo.Checked,
                        cbSegunda.Checked,
                        cbTerca.Checked,
                        cbQuarta.Checked,
                        cbQuinta.Checked,
                        cbSexta.Checked,
                        cbSabado.Checked
                    },
                    TempoMaxUso = cbMaxUso.SelectedItem.ToString(),
                };

                if (novoUsuario.Administrador) {
                    if (DbClass.setUser(novoUsuario.Usuario, novoUsuario.Senha, novoUsuario.Administrador)) {
                        AtualizaComboBox();
                    }
                }
                else {
                    if (DbClass.SetUser(novoUsuario)) {
                        AtualizaComboBox();
                    }

                }
            }
            else {
                MessageBox.Show("Insira os dados corretamente!");
            }
        }

        private void btnAdicionarSite_Click(object sender, EventArgs e) {
            if (usuario.SetSite(tbAdicionarSite.Text)) {
                MessageBox.Show("Site adicionado com sucesso!");
                AtualizaSitesPermitidos();
            }
            else {
                MessageBox.Show("Algum problema ocorreu, verifique se o site já não foi adicionado!");
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e) {

            usuario.DiasSemana[0] = cbuSegunda.Checked;
            usuario.DiasSemana[1] = cbuTerca.Checked;
            usuario.DiasSemana[2] = cbuQuarta.Checked;
            usuario.DiasSemana[3] = cbuQuinta.Checked;
            usuario.DiasSemana[4] = cbuSexta.Checked;
            usuario.DiasSemana[5] = cbuSabado.Checked;
            usuario.DiasSemana[6] = cbuDomingo.Checked;
            usuario.NivelJogo = nivelJogoAux;

            usuario.salvarConfigs();
            MessageBox.Show("Configurações de usuario salvas com sucesso!");
            if (!(tbNovaSenha.Text == "")) {
                if (tbNovaSenha.Text == tbCNovaSenha.Text) {
                    usuario.Senha = tbNovaSenha.Text;
                    usuario.salvarSenha();
                }
                else {
                    MessageBox.Show("Confirmação de senha invalida!");
                }
            }

        }

        private void cbu_Click(object sender, EventArgs e) {

            //Dictionary<string, int> dicionario = new Dictionary<string, int>();
            //dicionario.Add("Segunda-Feira", 0);
            //dicionario.Add("Terça-Feira", 1);
            //dicionario.Add("Quarta-Feira", 2);
            //dicionario.Add("Quinta-Feira", 3);
            //dicionario.Add("Sexta-Feira", 4);
            //dicionario.Add("Sabado", 5);
            //dicionario.Add("Domingo", 6);

            //usuario.DiasSemana[dicionario[((CheckBox)sender).Text]] = ((CheckBox)sender).Checked;

        }

        private void radioClick_Click(object sender, EventArgs e) {

            //usuario = listaUsuarios.Find(x => x.Usuario == cbUsuarioHist.Text);

            nivelJogoAux = ((RadioButton)sender).Text.ToUpper();
            //MessageBox.Show(((RadioButton)sender).Text.ToUpper());

        }

        private void btnLimparHistorico_Click(object sender, EventArgs e) {
            DbClass.delHisto(usuario.Id);
            AtualizaHistorico();
        }

        private void btnSitePermitidos_Click(object sender, EventArgs e) {
            if (((Button)sender).Text == "Editar") {
                AtualizaSitesPermitidos();
            }
            else if (((Button)sender).Text == "Excluir") {
                AtualizaSitesPermitidos();
            }
        }

        private void cbuMaxUso_SelectedIndexChanged(object sender, EventArgs e) {
            usuario.TempoMaxUso = cbuMaxUso.Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            if (usuario.Administrador) {
                if (listaUsuarios.Count(x => x.Administrador) > 1) {
                    if (usuario.Usuario == CGlobalStatica.usuarioGlobal.Usuario) {
                        MessageBox.Show("Você não pode excluir o seu próprio usuario!");
                    }
                    else if(usuario.Delete()) {
                        MessageBox.Show("Usuario excluido com sucesso!");
                        AtualizaComboBox();
                    }
                }
                else {
                    MessageBox.Show("Usuario não pode ser excluido pois é administrador e não há outro usuario administrador!");
                }
            }
            else {
                if (usuario.Delete()) {
                    MessageBox.Show("Usuario excluido com sucesso!");
                    AtualizaComboBox();
                }
            }
        }
    }
}
