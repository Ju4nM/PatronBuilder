using PatronBuilder.Interfaces;
using PatronBuilder.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Constructores {
    public class CasaBuilder: ICasaBuilder {
        private Casa casa = new Casa();
        public Casa Build() => casa;

        public CasaBuilder SetCuartos(int cantidad) {
            casa.NumeroCuartos = cantidad;
            return this;
        }

        public CasaBuilder SetJardin(bool tieneJardin) {
            casa.TieneJardin = tieneJardin;
            return this;
        }

        public CasaBuilder SetPicina(bool tienePicina) {
            casa.TienePicina = tienePicina;
            return this;
        }

        public CasaBuilder SetPuertas(int cantidad) {
            casa.NumeroPuertas = cantidad;
            return this;
        }

        public CasaBuilder SetVentanas(int cantidad) {
            casa.NumeroVentanas = cantidad;
            return this;
        }
    }
}
