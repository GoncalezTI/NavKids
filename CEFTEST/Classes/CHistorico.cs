using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavKids
{
    public class CHistorico
    {

        public string Id_Usuario { get; set; }
        public string Site { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int Id_Site { get; set; }

        //public string hora = DateTime.Now.Hour.ToString("HH:MM"), site;
        //public DateTime data = new DateTime();
        //public int id_hist, id_usuario;

        //public cHist(int id_usuario,int id_hist,DateTime data, string site, string hora)
        //{
        //    this.id_hist = id_hist;
        //    this.id_usuario = id_usuario;
        //    this.data = data;
        //    this.site = site;
        //    this.hora = hora;
        //}

        //public cHist(string site)
        //{
        //    this.site = site;
        //}

        public CHistorico() { }

        internal bool DeletarHistorico() {
            if (DbClass.delLinhaHisto(Id_Site)) {
                return true;
            }
            return false;
        }

    }
}
