using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavKids {
    public partial class FormLogin : Form {

        string usuario, senha;
        public bool logado = false;

        public FormLogin() {
            InitializeComponent();
            lblLoginError.Visible = false;
            AcceptButton = btnEntrar;
            CancelButton = btnSair;
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            usuario = tbLogin.Text;
            senha = tbSenha.Text;
            if (DbClass.VerifyUser(usuario, senha)) {
                CGlobalStatica.usuarioGlobal = DbClass.GetUser(DbClass.getId(usuario));

                // verifica se o usuario pode entrar no dia da semana ou se é usuario administrador

                //MessageBox.Show(((int)DbClass.GetNetworkTime().DayOfWeek).ToString());
                if (CGlobalStatica.usuarioGlobal.DiasSemana[(int)DbClass.GetNetworkTime().DayOfWeek] || CGlobalStatica.usuarioGlobal.Administrador) {

                    // verifica se o usuario é administrador novamente
                    if (CGlobalStatica.usuarioGlobal.Administrador) {
                        logado = true;
                        this.Close();
                    }

                    // verifica o dia da ultima vez logado com o dia atual.
                    else if (CGlobalStatica.usuarioGlobal.UltimaVezUsado.Substring(0, 10) == DbClass.GetNetworkTime().ToString("dd/MM/yyyy")) {

                        // se o dia da ultima vez logado for igual, verifica-se o tempo de utilização.
                        if (DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) < 30) {

                            // se o tempo maximo foi atingido, então mostra mensagem de tempo max atingido >>
                            if (CGlobalStatica.usuarioGlobal.TempoUsado >= (DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) * 60 * 60) && int.Parse(CGlobalStatica.usuarioGlobal.TempoMaxUso) != 0) {
                                lblLoginError.Text = "Tempo maximo de login diario atingido!!";
                                lblLoginError.Visible = true;
                            }

                            // se o tempo maximo não foi atingido, então entra >>
                            else {
                                logado = true;
                                this.Close();
                            }
                        }
                        else {

                            // se o tempo maximo foi atingido, então mostra mensagem de tempo max atingido >>
                            if (CGlobalStatica.usuarioGlobal.TempoUsado >= (DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) * 60) && DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) != 0) {
                                lblLoginError.Text = "Tempo maximo de login diario atingido!!";
                                lblLoginError.Visible = true;
                            }

                            // se o tempo maximo não foi atingido, então entra >>
                            else {
                                logado = true;
                                this.Close();
                            }
                        }
                    }

                    // se o dia do ultimo login for diferente, seta o dia como dia atual e zera o tempo usado do banco
                    else {
                        //MessageBox.Show("diferente");
                        DbClass.setDia(CGlobalStatica.usuarioGlobal.Id);
                        DbClass.setTempUsed(CGlobalStatica.usuarioGlobal.Id);
                        CGlobalStatica.usuarioGlobal = DbClass.GetUser(CGlobalStatica.usuarioGlobal.Id);
                        logado = true;
                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Você não pode entrar hoje! ");
                }
            }
            else {
                lblLoginError.Text = "Senha ou login incorretos!";
                lblLoginError.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //private void TextBoxs_KeyDown(object sender, KeyEventArgs e) {
        //    if (e.Control && e.KeyValue == 86) {
        //        e.Handled = true;
        //        e.SuppressKeyPress = true;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //private void TextBoxs_KeyPress(object sender, KeyPressEventArgs e) {
        //    if ((!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))) {
        //        e.Handled = true;
        //    }
        //}

        private void Null_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))) {
                e.Handled = true;
            }
            if (Control.IsKeyLocked(Keys.CapsLock)) {
                lblCaps.Visible = true;
            }
            else {
                lblCaps.Visible = false;
            }
        }

        private void Null_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyValue == 86) {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
