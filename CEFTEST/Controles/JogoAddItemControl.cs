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
    public partial class JogoAddItemControl : UserControl {

        public CQuestao questao;

        public EventHandler EventHandler;

        public JogoAddItemControl() {
            InitializeComponent();
        }

        private void JogoAddItemControl_Load(object sender, EventArgs e) {

            if (questao != null) {
                btnEditar.Tag = questao.Id;
                lblIdQuestao.Text = questao.Id.ToString();
                lblTexto.Text = questao.Pergunta;
            }

            //EventHandler += EventoTeste;

        }

        //private void EventoTeste(Object sender, EventArgs e) {
        //    MessageBox.Show("Funciona!!!!");
        //}

        private void btnEditar_Click(object sender, EventArgs e) {
            EventHandler(this, new EventArgs());
        }
    }
}
