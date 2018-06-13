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
    public partial class JogoAddControl : UserControl {

        List<CQuestao> listaQuestoes = CQuestao.GetQuestoes();
        CQuestao editando = new CQuestao();
        List<JogoAddResposta> listaControlesRespostas = new List<JogoAddResposta>();
        //List<CResposta> novasRespostas = new List<CResposta>();
        int respAux = -1;

        public JogoAddControl() {
            InitializeComponent();
        }

        private void JogoAddControl_Load(object sender, EventArgs e) {
            foreach (CQuestao item in listaQuestoes) {
                JogoAddItemControl temp = new JogoAddItemControl() {
                    questao = item,
                    Dock = DockStyle.Top
                };
                temp.EventHandler += GetInfo;
                pQuestoesItem.Controls.Add(temp);
            }
            btnAdicionarResposta.Enabled = btnConfirmar.Enabled = rtbTexto.Enabled = false;
        }

        private void GetInfo(object sender, EventArgs e) {

            editando = ((JogoAddItemControl)sender).questao;
            rtbTexto.Text = editando.Pergunta;
            listaControlesRespostas.Clear();
            pRespostas.Controls.Clear();
            if (editando.Nivel == "BASICO") {
                rbBasico.Checked = true;
            }
            else if (editando.Nivel == "INTERMEDIARIO") {
                rbIntermediario.Checked = true;
            }
            else {
                rbAvancado.Checked = true;
            }

            foreach (CResposta item in editando.listaRespostas) {
                
                JogoAddResposta temp = new JogoAddResposta() {resposta = item, Dock = DockStyle.Top };
                temp.cbCheck.CheckedChanged += RbVerdadeiraCheck_CheckedChanged;

                listaControlesRespostas.Add(temp);
                pRespostas.Controls.Add(temp);
            }

            btnConfirmar.Enabled = btnAdicionarResposta.Enabled = rtbTexto.Enabled = true;
        }

        private void RbVerdadeiraCheck_CheckedChanged(object sender, EventArgs e) {
            foreach (JogoAddResposta item in listaControlesRespostas) {
                if (item.cbCheck != (RadioButton)sender && (bool)((RadioButton)sender).Tag == true) {
                    item.cbCheck.Checked = false;
                }
            }
        }

        private void RbNivel_CheckedChanged(object sender, EventArgs e) {
            editando.Nivel = ((RadioButton)sender).Tag.ToString();
        }

        private void btnAdicionarResposta_Click(object sender, EventArgs e) {

            CResposta respTemp = new CResposta() {
                id_Questao = editando.Id,
                certa = false,
                id_Resposta = --respAux
            };
            
            JogoAddResposta temp = new JogoAddResposta() { resposta = respTemp, Dock = DockStyle.Top };

            temp.cbCheck.CheckedChanged += RbVerdadeiraCheck_CheckedChanged;
            listaControlesRespostas.Add(temp);
            pRespostas.Controls.Add(temp);
            editando.listaRespostas.Add(respTemp);
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {

            foreach (JogoAddResposta item in listaControlesRespostas) {
                item.ConfirmarAlteracoes();

                MessageBox.Show(item.resposta.resposta + " ::: " + item.resposta.certa);
                editando.listaRespostas.Find(x => x.id_Resposta == item.resposta.id_Resposta).resposta = item.resposta.resposta;

            }

            editando.Pergunta = rtbTexto.Text;
            editando.GravarAlteracao();

            listaQuestoes = CQuestao.GetQuestoes();
            pQuestoesItem.Controls.Clear();
            foreach (CQuestao item in listaQuestoes) {
                JogoAddItemControl temp = new JogoAddItemControl() {
                    questao = item,
                    Dock = DockStyle.Top
                };
                temp.EventHandler += GetInfo;
                pQuestoesItem.Controls.Add(temp);
            }

            editando = listaQuestoes.Find(x => x.Id == editando.Id);

            rtbTexto.Text = editando.Pergunta;
            listaControlesRespostas.Clear();
            pRespostas.Controls.Clear();

            foreach (CResposta item in editando.listaRespostas) {

                JogoAddResposta temp = new JogoAddResposta() { resposta = item, Dock = DockStyle.Top };
                temp.cbCheck.CheckedChanged += RbVerdadeiraCheck_CheckedChanged;

                listaControlesRespostas.Add(temp);
                pRespostas.Controls.Add(temp);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e) {
            listaControlesRespostas.Clear();
            pRespostas.Controls.Clear();

            editando = new CQuestao() {
                listaRespostas = new List<CResposta>(),
                Nivel = "BASICO"
            };

            rbBasico.Checked = true;

            btnAdicionarResposta.Enabled = btnConfirmar.Enabled = rtbTexto.Enabled = true;
        }

        private void pNivel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
