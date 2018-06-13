using System;
using System.Collections.Generic;

namespace NavKids {
    public class CUsuario {
        //public string usuario, senha, hora;
        //public int id;
        //public list<chist> listahistorico = new list<chist>();

        int id;
        string usuario;
        string senha;
        bool administrador;
        string nivelJogo;
        bool[] diasSemana;
        string[] sites;
        List<CHistorico> historico;
        List<CSitePermitido> sitesPermitidos;

        string tempoMaxUso;
        int tempoUsado;
        string ultimaVezUsado;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string NivelJogo { get => nivelJogo; set => nivelJogo = value; }
        public bool[] DiasSemana { get => diasSemana; set => diasSemana = value; }
        public string[] Sites { get => sites; set => sites = value; }
        public string TempoMaxUso { get => tempoMaxUso; set => tempoMaxUso = value; }
        public int TempoUsado { get => tempoUsado; set => tempoUsado = value; }
        public string UltimaVezUsado { get => ultimaVezUsado; set => ultimaVezUsado = value; }
        public List<CHistorico> Historico { get => historico; set => historico = value; }
        public List<CSitePermitido> SitesPermitidos { get => sitesPermitidos; set => sitesPermitidos = value; }

        // public cUsuario(string usuario, string senha, int id, List<cHist> listaHistorico)
        //{
        //this.usuario = usuario;
        //this.senha = senha;
        //this.id = id;
        //this.listaHistorico = listaHistorico;
        //this.hora = DateTime.Now.Hour.ToString("HH:MM");
        //}

        public CUsuario() { }

        internal bool salvarConfigs() {
            return DbClass.setConfig(id, diasSemana, nivelJogo, tempoMaxUso);
        }

        internal bool salvarSenha() {
            return DbClass.updatePass(id, senha);
        }

        internal void AtualizaHistorico() {
            Historico = DbClass.GetHist(this.id);
        }

        internal bool DelLinhaHistorico(int id_historico) {

            CHistorico aux = Historico.Find(x => x.Id_Site == id_historico);

            if (DbClass.delLinhaHisto(aux.Id_Site)) {
                AtualizaHistorico();
                return true;
            }
            else {
                return false;
            }
        }

        internal bool SetSite(string site) {
            if (DbClass.SetSite(this.Id,site)) {
                AtualizaSitesPermitidos();
                return true;
            }
            return false;
        }

        internal bool DelSite(string site) {
            if (DbClass.deletSite(this.Id, site)) {
                AtualizaSitesPermitidos();
                return true;
            }
            return false;
        }

        internal void AtualizaSitesPermitidos() {
            this.Sites = DbClass.getSites(id);
            this.SitesPermitidos = DbClass.GetSites(id);
        }

        internal bool UpdateSitePermitido(string site) {
            if (DbClass.updateSitePermitido(Id,site)) {
                AtualizaSitesPermitidos();
                return true;
            }
            return false;
        }

        internal bool Delete() {
            if (DbClass.DeletUser(this)) {
                return true;
            }
            return false;
        }

        internal void atualizaDados() {
            CUsuario temp = DbClass.GetUser(id);
            id = temp.id;
            usuario = temp.usuario;
            senha = temp.senha;
            administrador = temp.administrador;
            nivelJogo = temp.nivelJogo;
            diasSemana = temp.diasSemana;
            sites = temp.sites;
            TempoMaxUso = temp.tempoMaxUso;
            tempoUsado = temp.tempoUsado;
            ultimaVezUsado = temp.ultimaVezUsado;
            historico = temp.historico;
            sitesPermitidos = temp.sitesPermitidos;
        }
    }
}
