using PatronBuilder.Constructores;
using PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Directores {
    public class CasaDirector {
        private ICasaBuilder constructor;
        public CasaDirector (ICasaBuilder constructor) {
            this.constructor = constructor;
        }

        public void ConstruirCasaInfonavit () {
            constructor
                .SetCuartos(2)
                .SetVentanas(4)
                .SetPuertas(4)
                .SetPicina(false)
                .SetJardin(false);
        }

        public void ConstruirCasaZonaNorte () {
            constructor
                .SetCuartos(7)
                .SetVentanas(14)
                .SetPuertas(9)
                .SetPicina(true)
                .SetJardin(true);
        }
    }
}
