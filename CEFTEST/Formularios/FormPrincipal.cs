using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Handler;

namespace NavKids {
    public partial class FormPrincipal : Form {
        NavControl navControl = new NavControl() {
            Dock = DockStyle.Fill
        };
        ConfigControl configControl = new ConfigControl() {
            Dock = DockStyle.Fill
        };
        bool hidden = false;

        public FormPrincipal() {
            InitializeComponent();
            NavPanelForm.Controls.Add(navControl);
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            tSlide.Start();
        }

        private void tSlide_Tick(object sender, EventArgs e) {
            if (!hidden) {
                if (menuPanel.Width > 60) {
                    menuPanel.Width -= 10;
                }
                else {
                    hidden = true;
                    tSlide.Stop();
                }
            }
            else {
                if (!menuPanel.Visible) {
                    menuPanel.Visible = true;
                }
                if (menuPanel.Width < 230) {
                    menuPanel.Width += 10;
                }
                else {
                    hidden = false;
                    tSlide.Stop();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {
            btnConfiguracoes.Enabled = CGlobalStatica.usuarioGlobal.Administrador;
            if (!CGlobalStatica.usuarioGlobal.Administrador) {
                tUso.Start();
            }
            btnNavegador.ImageAlign = ContentAlignment.MiddleLeft;

        }

        private void tUso_Tick(object sender, EventArgs e) {

            //x = x + 600; 
            CGlobalStatica.usuarioGlobal.TempoUsado += 600;

            // X equivale 10m a cada 10s
            //MessageBox.Show("Valor de X = " + x);
            //MessageBox.Show("X representa " + (x/60) + " Minutos" );
            DbClass.setTempUsed(CGlobalStatica.usuarioGlobal.Id, CGlobalStatica.usuarioGlobal.TempoUsado);
            /* pega somente a parte numerica da string. EX "30 M" = 30.
             * verifica se a parte numerica é menor que 30 (Se for menor só pode ser 1 HR, 2 HR ... 6 HR,
             * se for maior só pode ser 30 M).
             * 30m == 1800s >> 30m * 60s == 1800s  || 1hr == 3600s >> 1h * 60m * 60s == 3800.
             * verifica se o contador x é maior ou igual aos segundos estipulados, se for, Sai.
             */

            if (DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) < 30 && DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) != 0) {
                if (CGlobalStatica.usuarioGlobal.TempoUsado >= DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) * 60 * 60) {
                    MessageBox.Show("Seu tempo de Navegação acabou, até logo!");
                    this.Close();
                }
            }
            else if (DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) != 0) {
                if (CGlobalStatica.usuarioGlobal.TempoUsado >= DbClass.getOnlyNum(CGlobalStatica.usuarioGlobal.TempoMaxUso) * 60) {
                    MessageBox.Show("Seu tempo de Navegação acabou, até logo!");
                    this.Close();
                }
            }
        }

        private void btnJogo_Click(object sender, EventArgs e) {
            NavPanelForm.Controls.Clear();
            if (CGlobalStatica.usuarioGlobal.Administrador) {
                NavPanelForm.Controls.Add(new JogoAddControl() { Dock = DockStyle.Fill });
            }
            else {
                NavPanelForm.Controls.Add(new JogoControl() { Dock = DockStyle.Fill });
            }

        }

        private void btnNavegador_Click(object sender, EventArgs e) {
            NavPanelForm.Controls.Clear();
            NavPanelForm.Controls.Add(navControl);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e) {
            NavPanelForm.Controls.Clear();
            NavPanelForm.Controls.Add(configControl);
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                MessageBox.Show("Test");
                e.Handled = true;
                //e.SuppressKeyPress = true;
            }
        }
    }
}
