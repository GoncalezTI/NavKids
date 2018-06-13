using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavKids {
    public class CSitePermitido {
        public int id_usuario, id_site;
        public string site;

        public CSitePermitido(int id_site, int id_usuario,string site) {
            this.id_site = id_site;
            this.id_usuario = id_usuario;
            this.site = site;
        }

        public CSitePermitido() { }
    }
}
