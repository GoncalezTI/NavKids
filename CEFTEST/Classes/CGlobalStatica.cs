using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavKids {
    class CGlobalStatica {
        public static CUsuario usuarioGlobal ;

        public static void AtualizaUsuarioGlobal() {
            usuarioGlobal.atualizaDados();
        }
    }
}
