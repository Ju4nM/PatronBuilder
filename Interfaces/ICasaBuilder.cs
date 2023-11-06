using PatronBuilder.Objetos;
using PatronBuilder.Constructores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Interfaces {
    public interface ICasaBuilder {
        public CasaBuilder SetCuartos(int cantidad);
        public CasaBuilder SetPuertas(int cantidad);
        public CasaBuilder SetVentanas(int cantidad);
        public CasaBuilder SetJardin(bool tieneJardin);
        public CasaBuilder SetPicina(bool tienePicina);

        public Casa Build();
    }
}
