using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavKids {
    public class CQuestao {

        int id = -1;
        string pergunta;
        string nivel;

        public string Pergunta { get => pergunta; set => pergunta = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public int Id { get => id; set => id = value; }

        public List<CResposta> listaRespostas;

        public CQuestao(int id) {

        }

        public CQuestao() { }

        public static List<CQuestao> GetQuestoes(string nivelJogo) {
            return DbClass.GetPerguntas(nivelJogo);
        }

        public static List<CQuestao> GetQuestoes() {
            return DbClass.GetPerguntas();
        }

        public bool GravarAlteracao() {
            if (Id > -1) {
                if (DbClass.UpdatePergunta(this)) {
                    CQuestao temp = DbClass.GetPergunta(Id);
                    if (temp != null) {
                        Id = temp.Id;
                        Pergunta = temp.Pergunta;
                        Nivel = temp.Nivel;

                        foreach (CResposta item in listaRespostas) {
                            item.GravarAlteracoes();
                        }

                        return true;
                    }
                }
            }
            else {

                int aux = DbClass.SetPergunta(this);

                if (aux != -1) {
                    CQuestao temp = DbClass.GetPergunta(aux);
                    if (temp != null) {
                        id = temp.id;
                        pergunta = temp.pergunta;
                        nivel = temp.nivel;

                        foreach (CResposta item in listaRespostas) {
                            item.id_Questao = id;
                            item.GravarAlteracoes();
                        }
                        return true;
                    }
                }
            }

            return false;


        }
    }
}
