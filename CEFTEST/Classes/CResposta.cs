using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavKids {
    public class CResposta {
        public int id_Resposta = -1;
        public int id_Questao;
        public string resposta;
        public bool certa;

        public CResposta() { }

        public bool GravarAlteracoes() {
            if (id_Resposta > -1) {
                if (DbClass.UpdateResposta(this)) {
                    CResposta temp = DbClass.GetResposta(id_Resposta);
                    if (temp != null) {
                        id_Resposta = temp.id_Resposta;
                        id_Questao = temp.id_Questao;
                        resposta = temp.resposta;
                        certa = temp.certa;

                        return true;
                    }
                }
            }
            else if (DbClass.SetResposta(this)) {
                CResposta temp = DbClass.GetResposta(id_Resposta);
                if (temp != null) {
                    id_Resposta = temp.id_Resposta;
                    id_Questao = temp.id_Questao;
                    resposta = temp.resposta;
                    certa = temp.certa;

                    return true;
                }
            }

            return false;
        }
    }
}
