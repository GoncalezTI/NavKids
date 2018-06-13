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
    public partial class JogoControl : UserControl {

        List<CQuestao> questoes;
        CQuestao questao;
        int aux;
        Random rand = new Random();
        int pontos = 0;
        int temp = 90;
        bool resposta = false;
        private bool pontoSomado = true;

        public JogoControl() {
            InitializeComponent();
        }

        private void JogoControl_Load(object sender, EventArgs e) {
            questoes = CQuestao.GetQuestoes(CGlobalStatica.usuarioGlobal.NivelJogo);
            aux = questoes.Count();
        }

        private void tContador_Tick(object sender, EventArgs e) {
            temp--;
            lblRestante.Text = "" + temp / 60 + " Min e " + temp % 60 + " Segs";
            if (temp == 0) {
                tContador.Stop();
                MessageBox.Show("Seu tempo para responder acabou! :(");
                btnVerificar.Enabled = false;
                btnIniciar.Text = "Próxima";
                btnIniciar.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e) {

            temp = 90;
            resposta = false;
            pontoSomado = true;

            if (aux > 0) {
                questao = questoes[rand.Next(aux)];
            }

            rtbTexto.Text = questao.Pergunta;
            questao.listaRespostas.OrderBy(x => rand.Next());
            pRespostas.Controls.Clear();

            foreach (CResposta item in questao.listaRespostas) {

                RadioButton rad = new RadioButton() {
                    Dock = DockStyle.Top,
                    Text = item.resposta,
                    Tag = item.certa,
                    Padding = new Padding(15, 10, 10, 10),
                    AutoSize = true
                };

                rad.CheckedChanged += rbCheck_CheckedChanged;
                pRespostas.Controls.Add(rad);
            }

            btnIniciar.Enabled = false;
            btnIniciar.Text = "Próxima";
            btnVerificar.Enabled = true;
            tContador.Start();
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e) {
            resposta = bool.Parse(((RadioButton)sender).Tag.ToString());
        }

        private void btnVerificar_Click(object sender, EventArgs e) {
            if (resposta) {
                MessageBox.Show("Resposta certa!");
                btnIniciar.Text = "Próxima";
                btnIniciar.Enabled = true;
                if (pontoSomado) {
                    pontos += temp + 10;
                    lblPontos.Text = pontos + " pontos";
                    pontoSomado = false;
                }
                tContador.Stop();
            }
            else {
                MessageBox.Show("Resposta Errada!");
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTempoRestante_Click(object sender, EventArgs e)
        {

        }

        private void lblPontos_Click(object sender, EventArgs e)
        {

        }
    }
}
